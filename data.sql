DROP DATABASE QuanlyCongViec;
GO

USE QuanLyCongViec;
GO
CREATE TABLE PhongBan (
    id NVARCHAR(255) PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE Quyen (
    id INT PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE NhanVien (
    manv VARCHAR(255) PRIMARY KEY,
    hoten NVARCHAR(255),
    ngaysinh DATE,
    gioitinh NVARCHAR(10),
    diachi NVARCHAR(255),
    didong VARCHAR(20),
    email VARCHAR(255),
    chucvu NVARCHAR(255),
    phongban NVARCHAR(255) REFERENCES PhongBan(id),
    luong FLOAT,
    trangthai NVARCHAR(255),
    trinhdohocvan NVARCHAR(255),
    loaihinh NVARCHAR(255),
    quyenhan INT REFERENCES Quyen(id)
);

CREATE TABLE Taikhoan (
    id NVARCHAR(255) PRIMARY KEY REFERENCES NhanVien(manv),
    mk VARCHAR(255),
    loaiTK INT REFERENCES Quyen(id)
);

CREATE TABLE LichSuHoatDong (
    id INT PRIMARY KEY IDENTITY(1,1),
    idNguoiDung NVARCHAR(255),
    hanhDong NVARCHAR(255),
    thoiGian DATETIME,
    FOREIGN KEY (idNguoiDung) REFERENCES NhanVien(manv)
);

CREATE TABLE DsCongViec (
    maCV INT PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE CuDan (
    maCD NVARCHAR(255) PRIMARY KEY,
    hinhthuc NVARCHAR(50),
    tenCH NVARCHAR(255),
    ngaysinh DATE,
    cccd VARCHAR(20),
    sdt VARCHAR(20),
    email VARCHAR(255),
    quoctich NVARCHAR(50),
    sothetamtru VARCHAR(20),
    sdt_nguoithan VARCHAR(20),
    tinhtrangcongno FLOAT,
    dk_thucung NVARCHAR(255)
);

CREATE TABLE CanHo (
    maCH NVARCHAR(255) PRIMARY KEY,
    maCD NVARCHAR(255) REFERENCES CuDan(maCD),
    ngaynhan DATE,
    ngaychuyenvao DATE,
    ngaychuyendi DATE,
    phidv FLOAT,
    phiql FLOAT,
    dien_nuoc_ngaynhan FLOAT
);

CREATE TABLE DVCanHo (
    maCH NVARCHAR(255),
    tinhtrang NVARCHAR(255),
    DV_dinhky NVARCHAR(255),
    maCV INT,
    FOREIGN KEY (maCH) REFERENCES CanHo(maCH),
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV)
);

CREATE TABLE CTCV (
    maCV INT,
    maNV NVARCHAR(255),  
    trangthai NVARCHAR(50),
    thoiGianHoanThanh DATE,
    songayhethan AS (DATEDIFF(day, GETDATE(), thoiGianHoanThanh)),
    Tuychonchiase NVARCHAR(50),--PUBLIC /PRIVATE
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv), 
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV) 
);

CREATE TABLE Tuychonchiase_MaNV (
    maCV INT,
    maNV NVARCHAR(255),
    maNV_duocchiase NVARCHAR(255),
    PRIMARY KEY (maCV, maNV), -- Khóa chính kết hợp
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV),
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv),
    FOREIGN KEY (maNV_duocchiase) REFERENCES NhanVien(manv)
);


CREATE TABLE ThanhVienCanHo (
    maTV INT PRIMARY KEY,
    maCD INT FOREIGN KEY REFERENCES CuDan(maCD),
    tenTV NVARCHAR(255),
    MoiQuanHe NVARCHAR(50)
);

CREATE TABLE DangKyDoXe (
    maDK INT PRIMARY KEY,
    maCH NVARCHAR(255) FOREIGN KEY REFERENCES CanHo(maCH),
    bienso NVARCHAR(20),
    chungloai NVARCHAR(50),
    loai NVARCHAR(50)
);

CREATE TABLE DichVuCuDan (
    maCD NVARCHAR(255) REFERENCES CuDan(maCD), 
    maCH NVARCHAR(255) FOREIGN KEY REFERENCES CanHo(maCH),
    CongNo FLOAT,
    TongChiPhiDien FLOAT,
    TongphiQuanLy FLOAT,
    TongPhiDichVu FLOAT
);

INSERT INTO DVCanHo
VALUES(123,'Chưa hoàn thành','BT','1'),(123,'Chưa hoàn thành','NHUNG','2'),
(123,'Chưa hoàn thành','BÁO CÁO','5')
select DSCV.maCV,DSCV.ten,DVCH.maCH,C.trangthai,C.thoiGianHoanThanh
,C.songayhethan,C.Tuychonchiase 
from CTCV C,DsCongViec DSCV,DVCanHo DVCH 
where C.maNV='NV001' AND C.maCV=DSCV.maCV AND DVCH.maCV=DSCV.maCV 
select * from CTCV C,DsCongViec DSCV,DVCanHo DVCH where C.maNV='NV001' AND DSCV.maCV=C.maCV AND DVCH.maCV=C.maCV

go
CREATE PROC proc_logic
@user VARCHAR(255),
@pass VARCHAR(255)
AS 
BEGIN
    SELECT * FROM Taikhoan WHERE id = @user AND mk = @pass;
END;
GO

-- Thêm dữ liệu vào bảng PhongBan
INSERT INTO PhongBan VALUES ('PB001', 'Phòng Kế toán');
INSERT INTO PhongBan VALUES ('PB002', 'Phòng Kỹ thuật');

-- Thêm dữ liệu vào bảng Quyen
INSERT INTO Quyen VALUES (1, 'Quản lý');
INSERT INTO Quyen VALUES (2, 'Nhân viên');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien VALUES ('NV001', N'Nguyễn Văn A', '1990-05-15', 'Nam', N'Hà Nội', '0987654321', 'nva@example.com', N'Nhân viên kỹ thuật', 'PB002', 15000000, N'Đang làm việc', N'Cử nhân CNTT', N'Thực tập', 1);
INSERT INTO NhanVien VALUES ('NV002', N'Trần Thị B', '1995-02-15', 'Nữ', N'Hồ Chí Minh', '0123456789', 'ttb@example.com', N'Nhân viên kinh doanh', 'PB001', 12000000, N'Đang làm việc', N'Cử nhân Kinh doanh', N'Thực tập', 2);

-- Thêm dữ liệu vào bảng Taikhoan
INSERT INTO Taikhoan VALUES ('NV001', '123', 1);
INSERT INTO Taikhoan VALUES ('NV002', '123', 2);

-- Thêm dữ liệu vào bảng DsCongViec
INSERT INTO DsCongViec VALUES (1, N'Lập kế hoạch dự án');
INSERT INTO DsCongViec VALUES (2, N'Thiết kế giao diện');

-- Thêm dữ liệu vào bảng CuDan
INSERT INTO CuDan VALUES (1, N'Căn hộ', N'Trần Văn Dũng', '1990-01-01', '123456789', '0123456789', 'dungtv@example.com', N'Việt Nam', 'Số 123, đường ABC', '0987654321', 0, N'Không');
INSERT INTO CuDan VALUES (2, N'Biệt thự', N'Nguyễn Thị Hằng', '1985-07-10', '987654321', '0987654321', 'hangnt@example.com', N'Việt Nam', 'Số 456, đường XYZ', '0123456789', 0, N'Có');

-- Thêm dữ liệu vào bảng CanHo
INSERT INTO CanHo VALUES (1, 1, '2024-01-01', '2024-01-15', NULL, 500000, 100000, 100);
INSERT INTO CanHo VALUES (2, 2, '2024-02-01', '2024-02-15', NULL, 600000, 120000, 120);

-- Thêm dữ liệu vào bảng DVCanHo
INSERT INTO DVCanHo VALUES (1, N'Đã hoàn thành', N'Vệ sinh chung cư', 1);
INSERT INTO DVCanHo VALUES (2, N'Chưa hoàn thành', N'Sửa chữa cơ bản', 2);

-- Thêm dữ liệu vào bảng CTCV
---CẦN SỬA


-- Thêm dữ liệu vào bảng ThanhVienCanHo
INSERT INTO ThanhVienCanHo VALUES (1, 1, N'Nguyễn Thị Hồng', N'Vợ');
INSERT INTO ThanhVienCanHo VALUES (2, 2, N'Nguyễn Văn B', N'Chồng');

-- Thêm dữ liệu vào bảng DangKyDoXe
INSERT INTO DangKyDoXe VALUES (1, 1, '123ABC', N'Oto', N'Cá nhân');
INSERT INTO DangKyDoXe VALUES (2, 2, '456XYZ', N'Oto', N'Công ty');

-- Thêm dữ liệu vào bảng DichVuCuDan
INSERT INTO DichVuCuDan VALUES (1, 1, 0, 500000, 100000, 100);
INSERT INTO DichVuCuDan VALUES (2, 2, 100000, 600000, 120000, 150);
