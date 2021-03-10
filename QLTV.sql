create database QLTV
go
use QLTV
go
create table ThuThu(
mathuthu nvarchar(10) primary key,
hoten nvarchar(50),
ngaysinh date,
gioitinh bit default 0,
diachi nvarchar(50),
sdt int
)
go
create table LoaiSach(
maloaisach nvarchar(10) primary key,
tenloaisach nvarchar(50),
mota nvarchar(50)
)
go

create table TacGia(
matg nvarchar(10) primary key,
tentg nvarchar(50),
lienhe nvarchar(50)
)
go
 create table Sach(
masach nvarchar(10) primary key,
maloaisach nvarchar(10),
matg nvarchar(10),
manxb nvarchar(10),
tensach nvarchar(50),
tinhtrang bit default 0,
ngaynhap date,
foreign key(maloaisach) references dbo.LoaiSach(maloaisach),
foreign key(matg) references dbo.TacGia(matg)

)
go
create table DocGia(
madocgia nvarchar(10) primary key,
hoten nvarchar(50),
ngaysinh date,
gioitinh bit default 1,
diachi nvarchar(50),
sdt int
)
go
create table Muon(
mamuon nvarchar(10) primary key,
mathuthu nvarchar(10),
madocgia nvarchar(10),
masach nvarchar(10),
ngaymuon date,
ngaytra date,
tinhtrangmuon bit default 1
foreign key(mathuthu) references dbo.ThuThu(mathuthu),
foreign key(madocgia) references dbo.DocGia(madocgia),
foreign key(masach) references dbo.Sach(masach)
)
go
create table Account(
mathuthu nvarchar(10) primary key,
username nvarchar(50),
pass varchar(50),
foreign key(mathuthu) references dbo.ThuThu(mathuthu)
)
