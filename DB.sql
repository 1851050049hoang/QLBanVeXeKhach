create database QuanLyBanVeXeKhach
go

use QuanLyBanVeXeKhach
go


create table LoaiNhanVien(
	MaLoaiNV int IDENTITY primary key not null,
	TenLoaiNV nchar(30) not null,
)

create table NhanVien(
	MaNV int IDENTITY(1851050001,1) primary key not null,
	HoTen nchar(30) not null,
	NgaySinh date not null,
	GioiTinh nchar(15) not null,
	DiaChi nchar(100) not null,
	CMND varchar(12) not null,
	DienThoai varchar(10) not null,
	MaLoaiNV int not null

	foreign key(MaLoaiNV) references dbo.LoaiNhanVien(MaLoaiNV)
)

create table LoaiXe(
	MaLoaiXe int IDENTITY primary key not null,
	TenLoaiXe nchar(30) not null,
)

create table Xe(
	MaXe int IDENTITY primary key not null,
	BienSo varchar(10) not null,
	SoGhe int not null,
	MaLoaiXe int not null

	foreign key(MaLoaiXe) references dbo.LoaiXe(MaLoaiXe)
)

create table ChuyenXe(
	MaCX int IDENTITY primary key not null,
	TenCX varchar(30) not null,
	DiemDi varchar(30) not null,
	ChiTietDiemDi varchar(100) not null,
	DiemDen varchar(30) not null,
	ChiTietDiemDen varchar(100) not null,
	GioDi varchar(5) not null,
	BangGia Money not null,
	MaXe int not null,
	MaNV int not null,

	foreign key(MaXe) references dbo.Xe(MaXe),
	foreign key(MaNV) references dbo.NhanVien(MaNV)
)

create table VeXe(
	MaVX int IDENTITY primary key not null,
	TenKH nchar(30) not null,
	SDTKH varchar(10) not null,
	MaCX int not null,
	MaNV int not null

	foreign key(MaCX) references dbo.ChuyenXe(MaCX),
	foreign key(MaNV) references dbo.NhanVien(MaNV)
)