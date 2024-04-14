create DATABASE QuanlyCongViec;
GO

USE QuanLyCongViec;
GO
CREATE TABLE PhongBan (
    id VARCHAR(50) PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE Quyen (
    id INT PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE NhanVien (
    manv VARCHAR(50) PRIMARY KEY,
    hoten NVARCHAR(255),
    ngaysinh DATE,
    gioitinh NVARCHAR(10),
    diachi NVARCHAR(255),
    didong VARCHAR(20),
    email VARCHAR(255),
    chucvu NVARCHAR(255),
    phongban VARCHAR(50) FOREIGN KEY REFERENCES PhongBan(id),
    luong FLOAT,
    trangthai NVARCHAR(255),
    trinhdohocvan NVARCHAR(255),
    loaihinh NVARCHAR(255),
    quyenhan INT FOREIGN KEY REFERENCES Quyen(id)
);

CREATE TABLE Taikhoan (
    id VARCHAR(50) PRIMARY KEY FOREIGN KEY REFERENCES NhanVien(manv),
    mk VARCHAR(255),
    loaiTK INT REFERENCES Quyen(id)
);


CREATE TABLE DsCongViec (
    maCV VARCHAR(50) PRIMARY KEY,
    ten NVARCHAR(255)
);

CREATE TABLE CuDan (
    maCD VARCHAR(50) PRIMARY KEY,
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
    maCH VARCHAR(50) PRIMARY KEY,
    maCD VARCHAR(50) FOREIGN KEY REFERENCES CuDan(maCD),
    ngaynhan DATE,
    ngaychuyenvao DATE,
    ngaychuyendi DATE,
    phidv FLOAT,
    phiql FLOAT,
    dienngaynhan FLOAT,
	nuocngaynhan FLOAT,
	
);

CREATE TABLE DVCanHo (
    maCH VARCHAR(50),
    tinhtrang NVARCHAR(255),
    DV_dinhky NVARCHAR(255),
    maCV VARCHAR(50),
    FOREIGN KEY (maCH) REFERENCES CanHo(maCH),
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV)
);

CREATE TABLE CTCV (
    maCV VARCHAR(50),
    maNV VARCHAR(50),  
    trangthai NVARCHAR(50),
    thoiGianHoanThanh DATE,
    songayhethan AS (DATEDIFF(day, GETDATE(), thoiGianHoanThanh)),
    Tuychonchiase NVARCHAR(50),--PUBLIC /PRIVATE
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv), 
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV) 
);

CREATE TABLE Tuychonchiase_MaNV (
    maCV VARCHAR(50),
    maNV VARCHAR(50),
    maNV_duocchiase VARCHAR(50),
    PRIMARY KEY (maCV, maNV), -- Khóa chính kết hợp
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV),
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv),
    FOREIGN KEY (maNV_duocchiase) REFERENCES NhanVien(manv)
);


CREATE TABLE ThanhVienCanHo (
    maTV VARCHAR(50) PRIMARY KEY,
    maCD VARCHAR(50) FOREIGN KEY REFERENCES CuDan(maCD),
    tenTV NVARCHAR(255),
    MoiQuanHe NVARCHAR(50)
);

CREATE TABLE DangKyDoXe (
    maDK VARCHAR(50) PRIMARY KEY,
    maCH VARCHAR(50) FOREIGN KEY REFERENCES CanHo(maCH),
    bienso NVARCHAR(20),
    chungloai NVARCHAR(50),
    loai NVARCHAR(50),
	
);

--bảng này để nhập/xuất về phần chi phí cư dân hàng tháng(Khánh)


CREATE TABLE Chiphicanho(
    maCD VARCHAR(50) FOREIGN KEY REFERENCES CuDan(maCD), 
    maCH VARCHAR(50) FOREIGN KEY REFERENCES CanHo(maCH),
    ngaybatdau DATE,
    ngayketthuc DATE,
    sodien FLOAT,
    sonuoc FLOAT,
	phidien FLOAT,
	phinuoc Float,
    CongNo FLOAT,
    TongphiQuanLy FLOAT,
    TongPhiDichVu FLOAT,
    TongChiPhiDienNuoc FLOAT
); 

CREATE TABLE UyQuyen(
	maUQ VARCHAR(50) PRIMARY KEY,
	tenchucnang NVARCHAR(255),
	)
CREATE TABLE DsUyQuyen(
	maUQ VARCHAR(50) FOREIGN KEY REFERENCES UyQuyen(maUQ),
	maNV VARCHAR(50) FOREIGN KEY REFERENCES NhanVien(maNV)
	)

go
CREATE PROC proc_logic
@user VARCHAR(255),
@pass VARCHAR(255)
AS 
BEGIN
    SELECT * FROM Taikhoan WHERE id = @user AND mk = @pass;
END;
GO

INSERT INTO PhongBan VALUES ('TC', 'Tài chính kế toán'),('VS', 'Vệ sinh'),('AN', 'An ninh'),('KT', 'Kỹ thuật')
,('XD', 'Xây dựng');

-- Thêm dữ liệu vào bảng Quyen
INSERT INTO Quyen VALUES (1, 'CEO');
INSERT INTO Quyen VALUES (2, 'Quản lý');
INSERT INTO Quyen VALUES (3, 'Nhân viên');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien VALUES ('KT001', N'Nguyễn Văn A', '1990-05-15', 'Nam', N'Hà Nội', '0987654321', 'nva@example.com', N'Nhân viên kỹ thuật', 'KT', 15000000, N'Đang làm việc', N'Cử nhân CNTT', N'Thực tập', 1);
INSERT INTO NhanVien VALUES ('TC002', N'Trần Thị B', '1995-02-15', 'Nữ', N'Hồ Chí Minh', '0123456789', 'ttb@example.com', N'Nhân viên kỹ thuật xây dựng', 'XD', 12000000, N'Đang làm việc', N'Cử nhân Kinh doanh', N'Thực tập', 2);

INSERT INTO NhanVien VALUES ('VS003', N'Nguyễn Văn AN', '1990-05-15', 'Nam', N'Hà Nội', '0987654321', 'nva@example.com', N'Nhân viên kỹ thuật', 'VS', 15000000, N'Đang làm việc', N'Cử nhân CNTT', N'Thực tập', 3);
INSERT INTO NhanVien VALUES ('AN004', N'Trần Thị BẢO', '1995-02-15', 'Nữ', N'Hồ Chí Minh', '0123456789', 'ttb@example.com', N'Nhân viên kỹ thuật xây dựng', 'AN', 12000000, N'Đang làm việc', N'Cử nhân Kinh doanh', N'Thực tập', 3);
-- Thêm dữ liệu vào bảng Taikhoan
INSERT INTO Taikhoan VALUES ('KT001', '123', 1);
INSERT INTO Taikhoan VALUES ('TC002', '123', 2);
INSERT INTO Taikhoan VALUES ('VS003', '123', 3),('ANNV004', '123', 3);
-- Thêm dữ liệu vào bảng DsCongViec
INSERT INTO DsCongViec VALUES (1, N'Sửa đèn');
INSERT INTO DsCongViec VALUES (2, N'Sửa nước');

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

