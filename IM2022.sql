use master
go
if exists (select name from sysdatabases where name = N'IM2022')
	drop database IM2022

go
CREATE DATABASE IM2022
go
USE IM2022
GO

create table CHUCVU
(
	MaCV char(2) primary key,
	TenCV nvarchar(40),
)

create table NHANVIEN
(
	MaNV char(5) primary key,
	TenNV nvarchar(40),
	MaCV char(2) foreign key (MaCV) references CHUCVU(MaCV)	on update cascade on delete set null,
	GioiTinh bit default 1,
	NTNS date,
	CCCD char(12),
	SDT char(10),
	DiaChi nvarchar(50),
	Email nvarchar(50)
)

create table TAIKHOAN
(
	TaiKhoan char(5) primary key,
	MatKhau nvarchar(50),
	MaNV char(5) foreign key (MaNV) references NHANVIEN(MaNV) on update cascade on delete set null
)

create table KHACHHANG
(
	MaKH char(6) primary key,
	TenKH nvarchar(40),
	DiemTL decimal default ('0'),
	SDT char(10),
	DiaChi nvarchar(50)
)

create table LOAIHANGHOA
(
	MaLHH char(5) primary key,
	TenLHH nvarchar(40),
)

create table DONVITINH
(
	MaDVT char(5) primary key,
	TenDVT nvarchar(40)
)

create table NHACUNGCAP
(
	MaNCC char(5) primary key,
	TenNCC nvarchar(40),
	DiaChi nvarchar(50),
	SDT char(10)
)

create table HANGHOA
(
	MaHH char(5) primary key,
	TenHH nvarchar(200),
	MaLHH char(5) foreign key (MaLHH) references LOAIHANGHOA(MaLHH) on update cascade on delete set null,
	GiaBan int,
	MaDVT char(5) foreign key (MaDVT) references DONVITINH(MaDVT) on update cascade on delete set null,
	SlTon int,
)

create table PHIEUNHAP
(
	MaPN char(5) primary key,
	MaNV char(5) foreign key (MaNV) references NHANVIEN(MaNV),
	MaNCC char(5) foreign key (MaNCC) references NHACUNGCAP(MaNCC)	,
	NgayLap date
)

create table CTPN
(
	MaPN char(5) foreign key (MaPN) references PHIEUNHAP(MaPN),	
	MaHH char(5) foreign key (MaHH) references HANGHOA(MaHH),
	primary key (MaPN,MaHH),
	SoLuong int
	
)

create table HOADON
(
	MaHD char(5) primary key,
	MaNV char(5) foreign key (MaNV) references NHANVIEN(MaNV),	
	MaKH char(6) foreign key (MaKH) references KHACHHANG(MaKH) null,	
	NTT date default getdate(),
	DiemTL decimal default ('0'),
	TienKM decimal default ('0'), 
	TongTien decimal default ('0')
)

create table CHITIETHOADON
(
	MaHD char(5) foreign key (MaHD) references HOADON(MaHD),	
	MaHH char(5) foreign key (MaHH) references HANGHOA(MaHH),	
	primary key (MaHD,MaHH),
	SoLuong int,
)
go
-- nhập dữ liệu	bảng chức vụ
insert into CHUCVU
    (MaCV, TenCV)
values
    ('QL', N'Quản Lý')
insert into CHUCVU
    (MaCV, TenCV)
values
    ('NV', N'Nhân viên')
go
--Nhập dữ liệu bảng nhân viên
insert into NHANVIEN
    (MaNV, TenNV, MaCV, GioiTinh, NTNS, CCCD, SDT, DiaChi,Email)
values
    ('QL001', N'Nguyễn Kim Phước', 'QL','1','2001/03/12','142335253678','0352479375','TP.HCM','abc@gmail.com')
insert into NHANVIEN
    (MaNV, TenNV, MaCV, GioiTinh, NTNS, CCCD, SDT, DiaChi,Email)
values
    ('NV001', N'Phạm Bá Trường', 'NV','1','2002/06/12','142334537265','0944177030',N'Hà Nội','as@gmail.com')
insert into NHANVIEN
    (MaNV, TenNV, MaCV, GioiTinh, NTNS, CCCD, SDT, DiaChi,Email)
values
    ('NV002', N'Trương Khắc Dĩ', 'NV','1','2003/08/26','142331233453','0357459374','TP.HCM','tkhacdi.26@gmail.com')
insert into NHANVIEN
    (MaNV, TenNV, MaCV, GioiTinh, NTNS, CCCD, SDT, DiaChi,Email)
values
    ('NV003', N'Lý Minh Nhựt', 'NV','0','2002/07/02','152333253478','0353459385','TP.HCM','nhutly19@gmail.com')
go
-- insert tài khoản
insert into TAIKHOAN
	(TaiKhoan, MatKhau, MaNV)
values
	('QL001','123456', 'QL001')
insert into TAIKHOAN
	(TaiKhoan, MatKhau, MaNV)
values
	('NV001','123456', 'NV001')
insert into TAIKHOAN
	(TaiKhoan, MatKhau, MaNV)
values
	('NV002','123456', 'NV002')
insert into TAIKHOAN
	(TaiKhoan, MatKhau, MaNV)
values
	('NV003','123456', 'NV003')
go
--insert loại hàng hóa
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('SPTS1',N'Sản phẩm tươi sống')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('R&C&Q',N'Rau, củ, quả')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('B&NGK',N'Bia, NGK')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('SPSUA',N'Sữa')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('B&KEO',N'Bánh, kẹo')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('MMCPG',N'Mì, Miến, Cháo, Phở')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('D&N&G',N'Dầu ăn, nước chấm, gia vị')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('GBDK',N'Gạo, bột, đồ khô')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('TP&DM',N'Thực phẩm đông mát')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('SPCMB',N'Sản phẩm cho mẹ và bé')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('CSCAN',N'Chăm sốc cá nhân')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('VSN&C',N'Vệ sinh nhà cửa')
insert into LOAIHANGHOA
	(MaLHH, TenLHH)
values
	('DDCGD',N'Đồ dùng gia đình')

go
-- insert đơn vị tính 
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('XKHAY',N'Khay')

insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVT1G',N'Gram')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('THUNG',N'Thùng')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVGOI',N'Gói')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVTUI',N'Túi')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('1CHAI',N'Chai')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVHOP',N'Hộp')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVTKG',N'Kilo gram')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVLON',N'Lon')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVCAI',N'Cái')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVTRA',N'Trái')
insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVLOC',N'Lốc')
	insert into DONVITINH
	(MaDVT, TenDVT)
values
	('DVQUE',N'Que')

go
-- sản phẩm tươi sống
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01001',N'Đầu cá hồi đông lạnh khay 500g','SPTS1','21000','XKHAY','20')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01002',N'Vay cá hồi đông lạnh khay 200g','SPTS1','20000','XKHAY','25')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01003',N'Cá saba nguyên con đông lạnh túi 350g','SPTS1','20000','DVTUI','20')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01004',N'Cá chạch khay 300g','SPTS1','35000','XKHAY','30')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01005',N'Cá kèo khay 200g','SPTS1','35000','XKHAY','34')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01006',N'Cá nục làm sạch túi 500g','SPTS1','40000','DVTUI','30')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01007',N'Cua thịt nguyên con hộp 2 con','SPTS1','204000','DVHOP','30')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01008',N'Tôm sú nguyên con khay 500g','SPTS1','158000','XKHAY','50')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01009',N'Thịt ba rọi heo khay 300g','SPTS1','64000','XKHAY','27')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('01010',N'Cánh gà khay 500g','SPTS1','54000','XKHAY','33')
-- rau củ quả
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02001',N'Cải ngọt baby gói 300g','R&C&Q','14500','DVGOI','15')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02002',N'Bắp mỹ (từ 300g trở lên)','R&C&Q','7500','DVTRA','23')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02003',N'Nho xanh hộp 500g','R&C&Q','126000','DVHOP','35')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02004',N'Cải thìa gói 500g','R&C&Q','9900','DVGOI','9')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02005',N'Cam vàng Úc hộp 1kg','R&C&Q','49000','DVHOP','45')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02006',N'Tỏi cô đơn túi 300g','R&C&Q','32000','DVTUI','67')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02007',N'Rau má gói 200g','R&C&Q','8500','DVGOI','53')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02008',N'Rau cần tàu (cần ta) gói 200g','R&C&Q','7500','DVGOI','83')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02009',N'Rau mồng tơi baby gói 300g','R&C&Q','12500','DVGOI','38')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('02010',N'Cà rốt Đà Lạt túi 500g','R&C&Q','13900','DVTUI','49')
-- bia, nước giải khát
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03001',N'Lốc 6 lon Fanta cam 330ml','B&NGK','49000','DVLOC','57')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03002',N'Lốc 6 chai trà sữa đài loan C2 280ml','B&NGK','63000','DVLOC','52')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03003',N'Lốc 6 lon trà bí đao Fuze Tea 320ml','B&NGK','55000','DVLOC','37')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03004',N'Cà phê nguyên hạt Nón Lá RobustaDark500g','B&NGK','49000','DVTUI','57')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03005',N'Nước ngọt CocaCola 600ml','B&NGK','6000','1CHAI','200')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03006',N'Thùng 24 lon bia Bia Việt 330ml','B&NGK','255000','THUNG','98')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03007',N'Thùng 24 lon bia Tiger Crystal 330ml','B&NGK','410000','THUNG','46')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03008',N'Thùng 24 chai nước Dasani 500ml','B&NGK','115000','THUNG','64')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03009',N'Nước khoáng La Vie 500ml','B&NGK','4000','1CHAI','84')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('03010',N'Cà phê hòa tan MacchiatoLion 3 in 1 180g','B&NGK','21000','DVHOP','29')
-- sữa các loại
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04001',N'Sữa bột Dielac Grow Plus 1+ đỏ lon 900g','SPSUA','330000','DVLON','92')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04002',N'Sữa bột Dielac Alpha Gold IQ 4 lon 900g','SPSUA','288000','DVLON','65')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04003',N'Sữa chua uống Dutch Lady hộp 1 lít','SPSUA','34000','DVHOP','77')
-- chua them
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04004',N'Thùng 48 bịch sữa tiệt trùng có đường Dutch Lady Canxi & Protein 220ml','SPSUA','278000','THUNG','100')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04005',N'Thùng 48 hộp thức uống lúa mạch Milo Active Go 115ml','SPSUA','322000','THUNG','100')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04006',N'Lốc 4 hộp sữa chua Vinamilk nha đam 100g','SPSUA','28200','DVLOC','145')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04007',N'Lốc 4 hộp sữa chua Vinamilk lựu đỏ 100g','SPSUA','30000','DVLOC','105')

insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04008',N'Thùng 12 hộp sữa chua uống vị việt quất bạc hà Dutch Lady 1 lít','SPSUA','427000','THUNG','113')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04009',N'Lốc 4 hộp sữa chua uống hương việt quất TH True Yogurt 180ml','SPSUA','29000','DVLOC','33')		
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('04010',N'Bột thức uống lúa mạch Milo Active Go hũ 400g','SPSUA','73000','DVHOP','73')				
	

insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05001',N'Bánh Choco-pie hộp 396g (12 cái)','B&KEO','47500','DVHOP','123')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05002',N'Bánh gạo nướng vị cá Nhật thượng hạng Orion An gói 100.8g','B&KEO','27000','DVGOI','23')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05003',N'Bánh kem trứng Custas hộp 188g (8 cái)','B&KEO','30500','DVHOP','230')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05004',N'Bánh xốp sầu riêng Janscorp hộp 150g','B&KEO','32000','DVHOP','30')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05005',N'Bánh xốp nhân phô mai Nabati hộp 340g','B&KEO','39000','DVHOP','39')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05006',N'Kẹo gum Lotte Xylitol hương dưa hấu hũ 58g','B&KEO','25000','DVHOP','25')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05007',N'Kẹo gum không đường Lotte Xylitol hương Fresh Mint hũ 58g','B&KEO','29300','DVHOP','29')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05008',N'Snack vị cua Kinh Đô gói 32g','B&KEO','6500','DVGOI','65')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05009',N'Snack mực tẩm gia vị cay Bento gói 6g','B&KEO','6500','DVGOI','56')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('05010',N'Bánh xốp KitKat phủ socola gói 204g','B&KEO','74000','DVGOI','74')
	--Mì, Miến, Cháo, Phở
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06001',N'Thùng 30 gói mì Hảo Hảo tôm chua cay 75g','MMCPG','108000','THUNG','74')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06002',N'Mì Hảo Hảo vị tôm chua cay gói 75g','MMCPG','4000','DVGOI','200')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06003',N'Mì xào Hảo Hảo tôm xào chua ngọt gói 75g','MMCPG','4000','DVGOI','200')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06004',N'Thùng 30 gói mì xào Hảo Hảo tôm xào chua ngọt 75g','MMCPG','112000','THUNG','34')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06005',N'Thùng 30 gói mì xào Nissin vị gà cay Hàn Quốc 71g','MMCPG','236000','THUNG','46')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06006',N'Mì xào Nissin vị gà cay Hàn Quốc gói 71g','MMCPG','236000','DVGOI','104')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06007',N'Thùng 30 gói cháo yến trẻ em Yến Việt Nest IQ Kids thịt bằm 50g','MMCPG','280000','THUNG','40')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06008',N'Cháo yến trẻ em Yến Việt Nest IQ Kids thịt bằm gói 50g','MMCPG','10300','DVGOI','140')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06009',N'Thùng 24 gói miến Phú Hương sườn heo 55g','MMCPG','244000','THUNG','40')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('06010',N'Miến Phú Hương sườn heo gói 55g','MMCPG','10300','DVGOI','130')


insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('07001',N'Dầu thực vật hương mè Nakydaco chai 1 lít','D&N&G','58000','1CHAI','130')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('07002',N'Dầu mè thơm nguyên chất Nakydaco chai 250ml','D&N&G','63000','1CHAI','30')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('07003',N'Dầu olive Extra Virgin Naturel chai 500ml','D&N&G','100700','1CHAI','60')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('07004',N'Đường mía thượng hạng Biên Hòa gói 1kg','D&N&G','28600','DVGOI','190')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('07005',N'Muối I-ốt Visaco gói 500g','D&N&G','6500','DVGOI','190')	


--gạo
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('08001',N'Gạo Ông Táo hương lài hướng dương Delifarm ST21 túi 5kg','GBDK ','109000','DVTUI','90')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('08002',N'Cá saba Nhật xốt cà 3 Cô Gái hộp 300g','GBDK ','32000','DVHOP','210')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('08003',N'Xúc xích heo dinh dưỡng Vissan gói 175g','GBDK ','18400','DVGOI','202')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('08004',N'Rong biển giòn O`food trộn hải sản gói 30g','GBDK ','30000','DVGOI','30')	

	--TP&DM
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('09001',N'Kem que Topten Socola Wall`s 57g','TP&DM','10000','DVQUE','20')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('09002',N'Lốc 5 tặng 1 bánh flan caramel trứng sữa Yess hũ lớn 100g','TP&DM','10000','DVLOC','30')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('09003',N'Phô mai lát Zott Sandwich gói 200g (12 lát)','TP&DM','46000','DVGOI','50')	

--sp cho me va be
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10001',N'Tã quần Pampers giữ dáng size XL 96 miếng','SPCMB','499000','THUNG','150')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10002',N'Sữa bột Nutricare 100 Gold lon 900g','SPCMB','260000','DVLON','10')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10003',N'Tắm gội toàn thân cho bé Johnson`s Baby 500ml','SPCMB','110000','1CHAI','120')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10004',N'Nước giặt cho bé OMO Matic dịu nhẹ cho quần áo bé yêu với công thức màn chắn kháng bẩn loại bỏ mùi hôi túi 3.4 lít','SPCMB','184000','DVTUI','84')	
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10005',N'Bàn chải cho bé 3 - 12 tuổi Oribaby lông siêu mềm','SPCMB','27000','DVCAI','20')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('10006',N'Ly mag mag núm vú Pigeon 180ml','SPCMB','64000','DVCAI','67')
--cscn
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11001',N'Dầu gội Head & Shoulders làm sạch gàu cho da đầu ngứa 1.8 lít','CSCAN','370000','1CHAI','73')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11002',N'Khăn ướt Wake-Up Cool hương bạc hà gói 20 miếng','CSCAN','12000','DVGOI','21')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11003',N'Sữa tắm Palmolive tinh dầu hoa hồng nhân sâm 750ml','CSCAN','105000','1CHAI','51')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11004',N'Mặt nạ bùn biển Mild Sea Clay Pack Tsururi 150g','CSCAN','211000','1CHAI','12')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11005',N'Kem đánh răng Colgate MaxFresh hương trà xanh 230g','CSCAN','32500','1CHAI','52')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11006',N'Băng vệ sinh Kotex Gardenia siêu mỏng có cánh 8 miếng','CSCAN','18500','DVGOI','58')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11007',N'Hộp 3 cái bao cao su Durex Kingtex 49mm','CSCAN','39000','DVHOP','93')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('11008',N'Khẩu trang Bông Bạch Tuyết 4 lớp hộp 50 cái xanh','CSCAN','34000','DVHOP','34')

-- ve sinh nha cua
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('12001',N'Nước giặt Downy vườn hoa thơm ngát túi 2 lít','VSN&C','126000','DVTUI','62')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('12002',N'Nước rửa chén Sunlight thiên nhiên muối khoáng và lô hội an toàn cho chén dĩa trẻ em túi 2 lít','VSN&C','60000','DVTUI','60')
--DDCGD
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('13001',N'Nồi đúc tráng men xanh ngọc Green Cook GCS05-24IH 24cm','DDCGD','60000','DVCAI','10')
insert into HANGHOA
	(MaHH, TenHH, MaLHH, GiaBan, MaDVT, SlTon)
values 
	('13002',N'Lốc 3 cuộn túi rác đen tự huỷ sinh học Bách Hóa XANH 64x78cm (1kg)','DDCGD','56000','DVLOC','65')

-- nhà cung cấp
go
insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('COCCL',N'Coca Cola',N'TP.HCM','0354687185')
insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('TIGER',N'Tiger',N'TP.HCM','0363687128')
insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('CTCVN',N'Công ty TNHH Cá Việt Nam',N'TP. Cần Thơ','0292533991')
insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('CTFVN',N'Công ty CP Famfood Việt Nam',N'TP. Hà Nội','0826005007')

insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('NLSTN',N'Công Ty TNHH MTV Nông Lâm Sản Thành Nam',N'Bình Dương','0985331399')

insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('URCVN',N'Công Ty TNHH URC Việt Nam',N'Bình Dương','0274376702')

insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('CFTKD ',N'Công Ty TNHH Coffee TKD',N'Long An','0352457359')

insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('BIAVI',N'Công Ty TNHH Bia Việt',N'Đồng Nai','0274743702')
insert into NHACUNGCAP
	(MaNCC, TenNCC, DiaChi, SDT)
values 
	('DUTCH',N'FrieslandCampina Việt Nam',N'Bình Dương','6503754422')
go
-- phiếu nhập
insert into PHIEUNHAP
	(MaPN, MaNV,MaNCC , NgayLap)
values
	('01001','NV001','CTCVN','2022/06/13')

insert into PHIEUNHAP
	(MaPN, MaNV, NgayLap)
values
	('01002','NV003','2022/07/10')

insert into PHIEUNHAP
	(MaPN, MaNV, NgayLap)
values
	('01003','NV002','2022/06/13')
go
-- chi tiết phiếu nhập

insert into	CTPN
	(MaPN, MaHH, SoLuong)
values
	('01001','01001','10')

insert into	CTPN
	(MaPN, MaHH, SoLuong)
values
	('01002','03005','120')

insert into	CTPN
	(MaPN, MaHH, SoLuong)
values
	('01003','02006','7')
go
-- Khách hàng
insert into KHACHHANG
	(MaKH, TenKH, DiemTL, SDT, DiaChi)
values 
	('123001',N'Nguyễn Huỳnh Văn A','839', '0352455345',N'TP.HCM')

-- Hóa đơn
--insert into HOADON
--	(MaHD, MaNV, MaKH, NTT, DiemTL, TienKM, TongTien)
--values
--	('12399','NV003','123001','2022/09/13','839','0','161800')
-- chi tiết hóa đơn
--insert into CHITIETHOADON
--	(MaHD, MaHH, SoLuong)
--values
--	('12399','02010','2')
--insert into CHITIETHOADON
--	(MaHD, MaHH, SoLuong)
--values
--	('12399','01009','2')
--insert into CHITIETHOADON
--	(MaHD, MaHH, SoLuong)
--values
--	('12399','03005','1')

go
 --Thanh toán tự động trừ sản phẩm
create or alter trigger NhapHang_trg
on CHITIETHOADON
after insert 
as
	declare @SoLuong int
	select @SoLuong = i.SoLuong from inserted i
	begin
		update HANGHOA 
		set SlTon = SlTon - @SoLuong
	end
	-- các combobox 
		--Lấy tên loại hàng hóa vào combobox
--select l.TenLHH from LOAIHANGHOA l
		--Lấy tên đơn vị tính vào combobox
--select d.TenDVT from DONVITINH d
		--Lấy chức vụ vào combobox
--select c.TenCV from CHUCVU c

	--danh sách hiển thị
		--hàng hóa
--select * from HANGHOA h, LOAIHANGHOA l, DONVITINH d where h.MaDVT=d.MaDVT and h.MaLHH=l.MaLHH
		--tài khoản
--select * from TAIKHOAN
		--Nhân viên
select n.MaNV,n.TenNV,c.TenCV,case when n.GioiTinh = 1 then 'Nam' when n.GioiTinh = 0 then N'Nữ' end as GioiTinh, n.NTNS,n.CCCD,n.SDT,n.DiaChi,n.Email from NHANVIEN n ,CHUCVU c where n.MaCV=c.MaCV
	--nhà cung cấp
--select * from NHACUNGCAP
	--Hoá đơn 
--select * from HANGHOA
	--Phiếu nhập 
--select * from PHIEUNHAP
