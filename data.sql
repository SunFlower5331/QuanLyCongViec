CREATE DATABASE QuanlyCongViec


CREATE TABLE PhongBan(
	id nvarchar(255) PRIMARY KEY,
	ten nvarchar(255)
	)

CREATE TABLE Quyen (
    id INT PRIMARY KEY,
    ten NVARCHAR(255),
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
    id VARCHAR(255) PRIMARY KEY REFERENCES NhanVien(manv),
    mk VARCHAR(255),
    loaiTK INT REFERENCES Quyen(id),
);

-- Thêm dữ liệu vào bảng PhongBan và Quyen nếu chưa có
INSERT INTO PhongBan  VALUES ('PB001', 'Phòng Kế toán');
INSERT INTO PhongBan  VALUES ('PB002', 'Phòng Kỹ thuật');
INSERT INTO PhongBan  VALUES ('PB003', 'Phòng Kinh doanh');

INSERT INTO Quyen  VALUES (1, 'Quản lý');
INSERT INTO Quyen  VALUES (2, 'Nhân viên');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (manv, hoten, ngaysinh, gioitinh, diachi, didong, email, chucvu, phongban, luong, trangthai, trinhdohocvan, loaihinh, quyenhan)
VALUES ('NV001', N'Nguyễn Văn A', '1990-05-15', 'Nam', N'Hà Nội', '0987654321', 'nva@example.com', N'Nhân viên kỹ thuật', 'PB002', 15000000, N'Đang làm việc', N'Cử nhân CNTT', N'Thực tập', 2);

-- Thêm dữ liệu vào bảng Taikhoan
INSERT INTO Taikhoan (id, mk, loaiTK)
VALUES ('NV001', '123', 2);


CREATE TABLE LichSuHoatDong (
    id INT PRIMARY KEY IDENTITY(1,1),
    idNguoiDung	VARCHAR(255),
    hanhDong NVARCHAR(255),
    thoiGian DATETIME,
    FOREIGN KEY (idNguoiDung) REFERENCES NhanVien(manv)
);

/*Khách hàng*/
CREATE TABLE DsCongViec (
    maCV INT PRIMARY KEY,
    ten NVARCHAR(255)
);
CREATE TABLE CuDan (
    maCD INT PRIMARY KEY,
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
    maCH INT PRIMARY KEY,
    maCD INT REFERENCES CuDan(maCD),
    ngaynhan DATE,
    ngaychuyenvao DATE,
    ngaychuyendi DATE,
    phidv FLOAT,
    phiql FLOAT,
    dien_nuoc_ngaynhan FLOAT
);
CREATE TABLE DVCanHo (
    maCH INT PRIMARY KEY,
    tinhtrang NVARCHAR(255),
    DV_dinhky NVARCHAR(255),
    maCV INT,
    FOREIGN KEY (maCH) REFERENCES CanHo(maCH),
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV)
);


CREATE TABLE CTCV (
    maCV INT FOREIGN KEY REFERENCES DsCongViec(maCV),
    maNV VARCHAR(255),  
    trangthai NVARCHAR(50),
    thoiGianHoanThanh DATETIME,
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv)  
);
CREATE TABLE ThanhVienCanHo (
    maTV INT PRIMARY KEY,
    maCD INT FOREIGN KEY REFERENCES CuDan(maCD),
    tenTV NVARCHAR(255),
    MoiQuanHe NVARCHAR(50)
);
CREATE TABLE DangKyDoXe (
    maDK INT PRIMARY KEY,
    maCH INT FOREIGN KEY REFERENCES CanHo(maCH),
    bienso NVARCHAR(20),
    chungloai NVARCHAR(50),
    loai NVARCHAR(50)
);
CREATE TABLE DichVuCuDan(
	maCD INT PRIMARY KEY REFERENCES CuDan (maCD), 
	maCH INT FOREIGN KEY REFERENCES CanHo(maCH),
	CongNo FLOAT,
	TongChiPhiDien FLOAT,
	TongphiQuanLy FLOAT,
	TongPhiDichVu FLOAT,
	)	


CREATE PROC proc_logic
@user varchar(255),
@pass varchar(255)
AS 
BEGIN
	select * from Taikhoan where @user=id and @pass=mk 
END


-- Thêm nhân viên mới vào bảng NhanVien và Users
INSERT INTO NhanVien 
VALUES ('NV002', N'Trần Thị B', '1995-02-15', 'Nữ', N'Hồ Chí Minh', '0123456789', 'ttb@example.com', N'Nhân viên kinh doanh', 'PB003', 12000000, N'Đang làm việc', N'Cử nhân Kinh doanh', N'Thực tập', 2);

-- Thêm người dùng tương ứng vào bảng Users
INSERT INTO Taikhoan 
VALUES ('NV002', '123',2);

-- Thêm nhân viên khác
INSERT INTO NhanVien 
VALUES ('NV003', N'Lê Văn C', '1992-08-20', 'Nam', N'Hải Phòng', '0987654321', 'lvc@example.com', N'Nhân viên kỹ thuật', 'PB002', 15000000, N'Đang làm việc', N'Cử nhân CNTT', N'Thực tập', 2);

INSERT INTO Taikhoan
VALUES ('NV003', '123',2);
