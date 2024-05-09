CREATE DATABASE QuanlyCongViec;
GO

USE QuanLyCongViec;
GO
SET DATEFORMAT DMY;

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
    loaihinh NVARCHAR(255)
);

CREATE TABLE Taikhoan (
    id VARCHAR(50) PRIMARY KEY FOREIGN KEY REFERENCES NhanVien(manv),
    mk VARCHAR(255),
    loaiTK INT REFERENCES Quyen(id)
);


CREATE TABLE DsCongViec (
    maCV VARCHAR(50) PRIMARY KEY,
    ten NVARCHAR(255),
	ngayYC DATE
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

-- Tạo hàm để tạo giá trị cho cột maCV

-- Tạo bảng DVCanHo
CREATE TABLE DVCanHo (
	maCV VARCHAR(50) PRIMARY KEY,
    maCH VARCHAR(50),
    DV_dinhky NVARCHAR(255),
    ngayYC DATE,
    FOREIGN KEY (maCH) REFERENCES CanHo(maCH)
);
select * from DVCanHo

-- Thêm dữ liệu vào bảng DVCanHo
INSERT INTO DVCanHo (maCH, DV_dinhky, ngayYC)
VALUES ('W2910',  N'Vệ sinh','2024-01-01');
SELECT * FROM DVCanHo
CREATE TABLE CTCV (
    maCV VARCHAR(50),
    maNV VARCHAR(50),  
    trangthai NVARCHAR(50),
    thoiGianHoanThanh DATE,
    songayhethan AS (DATEDIFF(day, GETDATE(), thoiGianHoanThanh)),
    Tuychonchiase NVARCHAR(50),--PUBLIC /PRIVATE,
	ngaycapnhat DATE
    FOREIGN KEY (maNV) REFERENCES NhanVien(manv), 
    FOREIGN KEY (maCV) REFERENCES DsCongViec(maCV) 
);
CREATE TABLE DsUyQuyenCV (
	maNV_cu VARCHAR(50),
    maCV VARCHAR(50),
    maNV_moi VARCHAR(50),  
    trangthai NVARCHAR(50),
    thoiGianHoanThanh DATE,
    songayhethan AS (DATEDIFF(day, GETDATE(), thoiGianHoanThanh)),
    Tuychonchiase NVARCHAR(50),--PUBLIC /PRIVATE,
	ngayBanGiao DATE
    FOREIGN KEY (maNV_moi) REFERENCES NhanVien(manv), 
	FOREIGN KEY (maNV_cu) REFERENCES NhanVien(manv), 
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
);
CREATE TABLE DsUyQuyen(
	maUQ VARCHAR(50) FOREIGN KEY REFERENCES UyQuyen(maUQ),
	maNV VARCHAR(50) FOREIGN KEY REFERENCES NhanVien(maNV)
);


CREATE TABLE TinhTrangCanHo(
	maCH VARCHAR(50) PRIMARY KEY,
	tinhTrangNguoiO NVARCHAR(50),
	tinhTrangBanGiao NVARCHAR(50),
	tinhTrangNoiThat NVARCHAR(50)
);

CREATE TABLE DsTaiLieu (
    Id INT PRIMARY KEY IDENTITY,
    FileName NVARCHAR(255) NOT NULL,
    PdfData VARBINARY(MAX) NOT NULL
);

go
CREATE PROC proc_CV
@maCV VARCHAR(255),
@maNV VARCHAR(255)
AS 
BEGIN
    SELECT * FROM CTCV WHERE maCV = @maCV AND maNV = @maNV;
END;
GO

go
CREATE PROC proc_logic
@user VARCHAR(255),
@pass VARCHAR(255)
AS 
BEGIN
    SELECT * FROM Taikhoan WHERE id = @user AND mk = @pass;
END;
GO
-- Thêm dữ liệu vào bảng PhongBan và Quyen
INSERT INTO PhongBan  VALUES ('GD', N'CEO');
INSERT INTO PhongBan  VALUES ('VS', N'Bộ phận Vệ Sinh');
INSERT INTO PhongBan  VALUES ('DV', N'Hành chính Nhân sự & Dịch vụ Cư Dân');
INSERT INTO PhongBan  VALUES ('TC', N'Tài chính Kế toán');
INSERT INTO PhongBan  VALUES ('AN', N'An Ninh');
INSERT INTO PhongBan  VALUES ('KT', N'Kỹ Thuật Bảo Trì');
INSERT INTO PhongBan  VALUES ('XD', N'Xây Dựng');

INSERT INTO Quyen (id, ten)  
VALUES (1, N'CEO'),
       (2, N'Quản lý'),
	   (3, N'Nhân viên')

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (manv, hoten, ngaysinh, gioitinh, diachi, didong, email, chucvu, phongban, luong, trangthai, trinhdohocvan, loaihinh, quyenhan)
VALUES ('VS-301', N'Nguyễn Thị Quyên', '15/04/1993', N'Nữ', N'Hà Nội', '0987654321', 'trinhnhung183@gmail.com', N'Nhân viên vệ sinh', 'VS', 5000000, N'Đã nghĩ việc', N'Tốt nghiệp 12', N'Nhân viên Thử việc', 3),
       ('KT-501', N'Phạm Văn Hùng', '03/01/1990', N'Nam', N'Đà Nẵng', '0381276137', 'embemay772023@gmail.com', N'Nhân viên kỹ thuật', 'KT', 20000000, N'Đang làm', N'Tốt nghiệp đại học', N'Nhân viên Full-time', 3),
	   ('XD-603', N'Quách Minh Toàn', '21/12/1989', N'Nam', N'Lâm Đồng', '0356798212', 'parkjihyun187@gmail.com', N'Nhân viên xây dựng', 'XD', 15000000, N'Đang làm', N'Tốt nghiệp đại học', N'Nhân viên Full-time', 3),
	   ('XD-601', N'Ngô Ngọc Trọng', '24/10/1997', N'Nam', N'Tiền Giang', '0327431639', 'npminhtri24102004@gmail.com', N'Nhân viên xây dựng', 'XD', 10000000, N'Hẹn lại khách', N'Tốt nghiệp đại học', N'Nhân viên Full-time', 3),
	   ('KT-502', N'Lê Quang Hải', '22/11/1999', N'Nam', N'Lâm Đồng', '0342671089', 'trinhletuyetnhung.hvt@gmail.com', N'Nhân viên kỹ thuật', 'KT', 5000000, N'Đã xong', N'Tốt nghiệp đại học', N'Nhân viên Part-time', 3)
-- Thêm dữ liệu vào bảng Taikhoan
INSERT INTO Taikhoan (id, mk, loaiTK)
VALUES ('VS-301', '123', 1),
	   ('KT-501', '123', 2),
	   ('XD-603', '123', 3),
	   ('XD-601', '123', 3),
	   ('KT-502', '123', 3)

INSERT INTO DsCongViec (maCV, ten, ngayYC)
VALUES ('1', N'Kiểm tra hệ thống thoát nước', '2024-01-01'),
	   ('2', N'Sửa chuông cửa', '2024-01-30'),
	   ('3', N'Bảo dưỡng máy lạnh', '2024-02-01'),
	   ('4', N'Vệ sinh', '2024-02-05'),
	   ('5', N'Kiểm tra Sàn gỗ', '2024-02-07'),
	   ('6', N'Sửa điện', '2024-02-08'),
	   ('7', N'Chốt chỉ số điện', '2024-02-10'),
	   ('8', N'Chốt chỉ số nước', '2024-02-11'),
	   ('9', N'Kiểm tra hệ thống công tắc', '2024-02-13')
-- Thêm dữ liệu vào bảng CuDan
INSERT INTO CuDan (maCD, hinhthuc, tenCH,  ngaysinh, cccd, sdt, email, quoctich, sothetamtru, sdt_nguoithan, tinhtrangcongno, dk_thucung)
VALUES ('CD1', N'Căn hộ FS', N'Nguyễn Văn A', '01/01/1993', '123456789', '0123456788', 'nva@gmail.com', N'Việt Nam', 'c', '0987654322', 0, N'Không'),
	   ('CD2', N'Căn hộ GS', N'Đoàn Đăng B', '10/07/1985', '987654321', '0987654456', 'doandangb@gmail.com', N'Việt Nam', 'AA034569', '0128856789', 0, N'Có'),
	   ('CD3', N'Căn hộ Penthouse', N'Phạm Hoàng C', '05/07/1998', '456587764', '0379553745', 'phamhoangc98@gmail.com', N'Việt Nam', 'CC097654', '0128856789', 0, N'Có')

-- Thêm dữ liệu vào bảng CanHo
INSERT INTO CanHo (maCH, maCD, ngaynhan, ngaychuyenvao, ngaychuyendi, phidv, phiql, dienngaynhan, nuocngaynhan)
VALUES ('W2910', 'CD1', '01/02/2023', '02/02/2023', NULL, 500000, 100000, 100, 50),
       ('W3508', 'CD2', '15/02/2024', '17/02/2024', NULL, 600000, 120000, 150, 70)

-- Thêm dữ liệu vào bảng DVCanHo
INSERT INTO DVCanHo (maCH, DV_dinhky,ngayYC)
VALUES ('W2910',  N'Vệ sinh','CD-1','1/1/2024'),
('W2910', N'Vệ sinh','CD-2','1/1/2024'),
       ('W3508', N'Kiểm tra hệ thống công tắc','CD-3','1/1/2024')

-- Thêm dữ liệu vào bảng CTCV
INSERT INTO CTCV
VALUES ('4', 'VS-301', N'Chưa hoàn thành', '10/02/2024',  N'Công việc chung', '2024-02-09'),
	   ('2', 'KT-502', N'Đã hoàn thành', '02/02/2024', N'Bộ phận', '2024-04-20')


-- Thêm dữ liệu vào bảng ThanhVienCanHo
INSERT INTO ThanhVienCanHo(maTV, maCD, tenTV, MoiQuanHe) 
VALUES ('TV1', 'CD1', N'Nguyễn Thị Hồng', N'Vợ'),
       ('TV2', 'CD2', N'Nguyễn Văn B', N'Chồng')

-- Thêm dữ liệu vào bảng DangKyDoXe
INSERT INTO DangKyDoXe (maDK, maCH, bienSo, chungloai, loai) 
VALUES (01, 'W2910', '48AD- 17456', N'xe tay ga', N'Vision'),
	   (02, 'W3508', '456XYZ', N'Oto', N'Công ty')

