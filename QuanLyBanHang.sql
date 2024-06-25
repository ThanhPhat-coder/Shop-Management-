Create database QuanLyBanHang
Go

Use QuanLyBanHang
Go
Set ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER ON
GO

Create table NhanVien(
	MaNhanVien nvarchar(255) primary key,
	TenNhanVien nvarchar(255) null,
	GioiTinh nvarchar(255) null,
	DiaChi nvarchar(255) null,
	SoDienThoai nvarchar(255) null,
	NgaySinh date,
	Email nvarchar(255) null,
	[Password] nvarchar(255) null
);
GO
--select* from NhanVien

ALTER TABLE NhanVien
	ALTER COLUMN NgaySinh date
ALTER TABLE NhanVien
	Add HinhAnh varchar(255) null

Create table SanPham(
	MaSanPham nvarchar(255) primary key,
	TenSanPham nvarchar(255) null,
	SoLuong float null,
	DonGiaNhap float null,
	DonGiaBan float null,
	Anh nvarchar(255) null,
	NgayNhap date,
	GhiChu nvarchar(255) null
);
--drop table SanPham

Create table KhachHang(
	MaKhachHang nvarchar(255) primary key,
	TenKhachHang nvarchar(255) Null,
	DiaChi nvarchar(255) Null,
	SoDienThoai nvarchar(255) null
);

Create table ChiTietHoaDon(
	MaHoaDon nvarchar(255) Not Null,
	MaSanPham nvarchar(255) Not Null,
	TenKhachHang nvarchar(255) Null,
	SoDienThoai nvarchar(255) Null,
	DiaChi nvarchar(255) Null,
	TenSanPham nvarchar(255) Null,
	SoLuong nvarchar(255) Null,
	DonGia nvarchar(255) Null,
	ThanhTien nvarchar(255) Null,
	TongTien nvarchar(255) null,
);
ALTER TABLE ChiTietHoaDon
ALTER COLUMN SoLuong int
create table HoaDon(
	MaHoaDon nvarchar(255) primary key,
	MaNhanVien nvarchar(255) Null,
	NgayBan date,
	MaKhachHang nvarchar(255) null,
	TongTien decimal(12,2) null,
);

--select *from ChiTietHoaDon


alter table HoaDon add constraint Fk_MaNhanVien Foreign key(MaNhanVien) REFERENCES NhanVien(MaNhanVien)

alter table HoaDon add constraint Fk_MaKhachHang Foreign key(MaKhachHang) REFERENCES KhachHang(MaKhachHang)

alter table ChiTietHoaDon add constraint Fk_MaSanPham Foreign key(MaSanPham) REFERENCES SanPham(MaSanPham)


-- Insert dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, DiaChi, SoDienThoai, NgaySinh, Email, [Password], HinhAnh)
VALUES ('NV001', N'Nguyễn Văn A', 'Nam', N'123 Đường ABC, Quận XYZ, Thành phố HCM', '0123456789', '1990-01-01', 'nv_a@example.com', 'password123', '1.jpg'),
       ('NV002', N'Trần Thị B', N'Nữ', N'456 Đường XYZ, Quận ABC, Thành phố HCM', '0987654321', '1995-05-05', 'tt_b@example.com', 'abc123', '2.jpg'),
       ('NV003', N'Lê Văn C', 'Nam', N'789 Đường DEF, Quận KLM, Thành phố HCM', '0369852147', '1988-10-10', 'lv_c@example.com', 'pass456', '3.jpg');

-- Insert dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGiaNhap, DonGiaBan, Anh, NgayNhap, GhiChu)
VALUES ('SP001', N'Áo thun nam', 100, 150000, 200000, 'C:\Courses\DOANTTLTA\DA\images\aothunnam.jpg', '2024-04-01', N'Mới về'),
       ('SP002', N'Váy nữ', 80, 250000, 350000, 'C:\Courses\DOANTTLTA\DA\images\vaynu.jpg', '2024-04-02', N'Giảm giá'),
       ('SP003', N'Áo thun nữ', 50, 5000000, 6000000, 'C:\Courses\DOANTTLTA\DA\images\aothunnu.jpg', '2024-04-03', N'Khuyến mãi');

INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGiaNhap, DonGiaBan, Anh, NgayNhap, GhiChu)
VALUES 
    ('SP004', N'Áo khoác nam', 120, 300000, 400000, 'link_anh_ao_khoac_nam.jpg', '2024-05-01', N'Mùa đông'),
    ('SP005', N'Váy dài nữ', 90, 400000, 500000, 'link_anh_vay_dai_nu.jpg', '2024-06-01', N'Tiệc tùng'),
    ('SP006', N'Laptop', 60, 8000000, 10000000, 'link_anh_laptop.jpg', '2024-07-01', N'Công việc'),
    ('SP007', N'Giày thể thao nam', 110, 200000, 300000, 'link_anh_giay_the_thao_nam.jpg', '2024-08-01', N'Thể thao'),
    ('SP008', N'Túi xách nữ', 80, 350000, 450000, 'link_anh_tui_xach_nu.jpg', '2024-09-01', N'Thời trang'),
    ('SP009', N'Điện thoại thông minh', 70, 7000000, 8000000, 'link_anh_dien_thoai_thong_minh.jpg', '2024-10-01', N'Công nghệ'),
    ('SP010', N'Áo len nam', 100, 250000, 350000, 'link_anh_ao_len_nam.jpg', '2024-11-01', N'Mùa đông'),
    ('SP011', N'Đồng hồ nữ', 90, 600000, 700000, 'link_anh_dong_ho_nu.jpg', '2024-12-01', N'Phụ kiện'),
	 ('SP012', N'Balo du lịch', 150, 400000, 500000, 'link_anh_balo_du_lich.jpg', '2025-01-01', N'Du lịch'),
    ('SP013', N'Mũ nón nam', 120, 100000, 150000, 'link_anh_mu_non_nam.jpg', '2025-02-01', N'Phụ kiện'),
    ('SP014', N'Áo thun nữ', 200, 200000, 250000, 'link_anh_ao_thun_nu.jpg', '2025-03-01', N'Thời trang'),
    ('SP015', N'Điện thoại gaming', 80, 12000000, 15000000, 'link_anh_dien_thoai_gaming.jpg', '2025-04-01', N'Giải trí'),
    ('SP016', N'Đèn trang trí', 100, 300000, 350000, 'link_anh_den_trang_tri.jpg', '2025-05-01', N'Trang trí nhà cửa'),
    ('SP017', N'Túi sách học sinh', 150, 150000, 200000, 'link_anh_tui_sach_hoc_sinh.jpg', '2025-06-01', N'Học tập'),
    ('SP018', N'Bàn chải điện', 90, 800000, 1000000, 'link_anh_ban_chai_dien.jpg', '2025-07-01', N'Chăm sóc sức khỏe'),
    ('SP019', N'Quần áo thể thao nữ', 120, 300000, 350000, 'link_anh_quan_ao_the_thao_nu.jpg', '2025-08-01', N'Thể thao'),
    ('SP020', N'Máy tính bảng', 100, 6000000, 7000000, 'link_anh_may_tinh_bang.jpg', '2025-09-01', N'Công nghệ'),
    ('SP021', N'Gối ôm', 200, 50000, 80000, 'link_anh_goi_om.jpg', '2025-10-01', N'Nội thất'),
    ('SP022', N'Bình nước thể thao', 150, 100000, 150000, 'link_anh_binh_nuoc_the_thao.jpg', '2025-11-01', N'Thể thao'),
    ('SP023', N'Đồ chơi trẻ em', 180, 200000, 250000, 'link_anh_do_choi_tre_em.jpg', '2025-12-01', N'Trẻ em');
--select * from SanPham

-- Insert dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai)
VALUES ('KH001', N'Nguyễn Văn X', N'987 Đường UVW, Quận MNO, Thành phố HCM', '0123456789'),
       ('KH002', N'Trần Thị Y', N'654 Đường PQR, Quận STU, Thành phố HCM', '0987654321'),
       ('KH003', N'Lê Văn Z', N'321 Đường JKL, Quận GHI, Thành phố HCM', '0369852147');
	
-- Insert dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES ('HD001', 'NV001', '2024-04-01', 'KH001', 450000),
       ('HD002', 'NV002', '2024-04-02', 'KH002', 900000),
       ('HD003', 'NV003', '2024-04-03', 'KH003', 1500000);
INSERT INTO HoaDon (MaHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES 
    ('HD004', 'NV001', '2024-01-01', 'KH001', 600000),
    ('HD005', 'NV002', '2024-02-01', 'KH002', 1200000),
    ('HD006', 'NV003', '2024-03-01', 'KH003', 2000000),
    ('HD007', 'NV001', '2024-04-01', 'KH001', 700000),
    ('HD008', 'NV002', '2024-05-01', 'KH002', 1400000),
    ('HD009', 'NV003', '2024-06-01', 'KH003', 2500000),
    ('HD010', 'NV001', '2024-07-01', 'KH001', 800000),
    ('HD011', 'NV002', '2024-08-01', 'KH002', 1600000),
    ('HD012', 'NV003', '2024-09-01', 'KH003', 2800000),
    ('HD013', 'NV001', '2024-10-01', 'KH001', 900000),
    ('HD014', 'NV002', '2024-11-01', 'KH002', 1800000),
    ('HD015', 'NV003', '2024-12-01', 'KH003', 3000000),
	('HD016', 'NV001', '2025-01-01', 'KH001', 650000),
    ('HD017', 'NV002', '2025-02-01', 'KH002', 1300000),
    ('HD018', 'NV003', '2025-03-01', 'KH003', 2200000),
    ('HD019', 'NV001', '2025-04-01', 'KH001', 750000),
    ('HD020', 'NV002', '2025-05-01', 'KH002', 1500000),
    ('HD021', 'NV003', '2025-06-01', 'KH003', 2600000),
    ('HD022', 'NV001', '2025-07-01', 'KH001', 850000),
    ('HD023', 'NV002', '2025-08-01', 'KH002', 1700000),
    ('HD024', 'NV003', '2025-09-01', 'KH003', 3000000),
    ('HD025', 'NV001', '2025-10-01', 'KH001', 950000),
    ('HD026', 'NV002', '2025-11-01', 'KH002', 1900000),
    ('HD027', 'NV003', '2025-12-01', 'KH003', 3200000);
	INSERT INTO HoaDon (MaHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES ('HD029', 'NV003', '2024-05-20', 'KH003', 3200000);
	select * from HoaDon
-- Insert dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, TenKhachHang, SoDienThoai, DiaChi,	TenSanPham, SoLuong, DonGia, ThanhTien, TongTien)
VALUES ('HD001', 'SP001', N'Nguyễn Văn X' ,'0123456789',N'987 Đường UVW, Quận MNO, Thành phố HCM',N'Áo thun nam',2, 200000, 400000, 400000),
       ('HD001', 'SP002', N'Nguyễn Văn X' ,'0123456789',N'987 Đường UVW, Quận MNO, Thành phố HCM',N'Váy nữ',1, 350000, 350000, 350000),
       ('HD002', 'SP001', N'Trần Thị B','0987654321',N'654 Đường PQR, Quận STU, Thành phố HCM',N'Áo thun nam', 3, 200000, 600000, 600000),
       ('HD002', 'SP002', N'Trần Thị B','0987654321',N'654 Đường PQR, Quận STU, Thành phố HCM',N'Váy nữ', 2, 350000, 700000, 700000),
       ('HD002', 'SP003', N'Trần Thị B','0987654321',N'654 Đường PQR, Quận STU, Thành phố HCM',N'Áo thun nữ',1, 6000000, 6000000,6000000),
       ('HD003', 'SP003', N'Lê Văn Z','0369852147', N'789 Đường DEF, Quận KLM, Thành phố HCM',N'Áo thun nữ', 5, 6000000, 30000000, 30000000);
		   select * from ChiTietHoaDon

	 
	   

