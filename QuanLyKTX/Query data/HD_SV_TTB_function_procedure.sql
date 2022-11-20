USE [QuanLyKTX]
GO
/****** Object:  UserDefinedFunction [dbo].[func_HoaDonQL]    Script Date: 11/18/2022 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Hóa đơn
ALTER function [dbo].[func_HoaDonQL] (@MaNQL char(10))
	returns table
		as
			return select HD.MaHoaDon as [Mã Hóa Đơn],
					HD.MaPhong as [Mã phòng],
					HD.TrangThai as [Trạng thái],
					HD.TienDien as [Tiền điện],
					HD.TienNuoc as [Tiền nước],
					HD.NgayTao as [Ngày tạo]
				from 
						Phong inner join Toa on Toa.TenToa = Phong.Toa
							  inner join HoaDonDienNuoc as HD on Phong.MaPhong = HD.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL

ALTER function [dbo].[func_PhongQuanLy] (@MaNQL char(10))
returns table
	as
		return 
			select Toa.TenToa ,Phong.MaPhong,Phong.SoLuongSinhVienHienTai from 
				Phong inner join Toa on Toa.TenToa = Phong.Toa
					  inner join SinhVien on Phong.MaPhong = SinhVien.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL 
				group by Phong.MaPhong , Phong.SoLuongSinhVienHienTai, Toa.TenToa

ALTER function [dbo].[func_HoaDonPhongQuanLy] (@MaNQL char(10) , @MaPhong char(10))
returns table
	as
		return select HD.MaHoaDon as [Mã Hóa Đơn],
					HD.MaPhong as [Mã phòng],
					HD.TrangThai as [Trạng thái],
					HD.TienDien as [Tiền điện],
					HD.TienNuoc as [Tiền nước],
					HD.NgayTao as [Ngày tạo]
				from 
						Phong inner join Toa on Toa.TenToa = Phong.Toa
							  inner join HoaDonDienNuoc as HD on Phong.MaPhong = HD.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL and HD.MaPhong = @MaPhong

ALTER function [dbo].[func_SoLuongHoaDonTheoMaPhong] (@MaNQL char(10), @MaPhong char(10))
returns int
as
begin 
	declare @soluong int
	select @soluong = count(MaHoaDon)
	from Phong inner join Toa on Toa.TenToa = Phong.Toa
				inner join HoaDonDienNuoc as HD on Phong.MaPhong = HD.MaPhong
	where Toa.MaNguoiQuanLy = @MaNQL and HD.MaPhong = @MaPhong
	return @soluong
end

ALTER procedure [dbo].[proc_ThemHoaDonDienNuoc]
(	@mahd char(10),
	@maphong char(10),
	@trangthai nvarchar(20),
	@td float,
	@tn float,
	@ngaytao Date)
as insert into HoaDonDienNuoc Values(@mahd, @maphong, @trangthai, @td, @tn, @ngaytao);

ALTER function [dbo].[func_HoaDonChuaThanhToanTheoPhong] (@MaNQL char(10))
returns table
	as
		return select HD.MaHoaDon as [Mã Hóa Đơn],
					HD.MaPhong as [Mã phòng],
					HD.TrangThai as [Trạng thái],
					HD.TienDien as [Tiền điện],
					HD.TienNuoc as [Tiền nước],
					HD.NgayTao as [Ngày tạo]
				from Phong inner join Toa on Toa.TenToa = Phong.Toa
							  inner join HoaDonDienNuoc as HD on Phong.MaPhong = HD.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL and HD.TrangThai = N'Chưa thanh toán'

ALTER procedure [dbo].[proc_SuaHoaDonDienNuoc] (@mahd char(10), @maphong char(10), @trangthai nvarchar(20), @td float,
						@tn float, @ngaytao Date)
as 
begin tran
if(@td is null and @tn is null)
begin
	raiserror('Tien dien va tien nuoc khong duoc de trong',16,1)
	rollback
	return
end
update HoaDonDienNuoc set MaHoaDon = @mahd,
						  MaPhong = @maphong,
						  TrangThai = @trangthai,
						  TienDien = @td,
						  TienNuoc = @tn,
						  NgayTao = @ngaytao
where MaHoaDon = @mahd
if(@@ERROR <> 0)
begin
	raiserror('Error',16,1)
	rollback
	return 
end
commit tran



-- Sinh viên
ALTER function [dbo].[func_SinhVienQuanLy] (@MaNQL char(10))
	returns table
		as
			return 
				select SV.MaSinhVien as [Mã Sinh Viên],
						SV.HoTen as [Họ Tên],
						SV.SoDienThoai as [Số Điện Thoại],
						SV.GioiTinh as [Giới Tính],
						SV.NamHoc as [Năm Học],
						SV.TonGiao as [Tôn Giáo],
						SV.QuocTich as [Quốc Tịch],
						SV.CMND_CCCD as [CMND/CCCD],
						SV.MaPhong as [Mã Phòng]
				from 
					   Phong inner join Toa on Toa.TenToa = Phong.Toa
							 inner join SinhVien as SV on Phong.MaPhong = SV.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL 

ALTER function [dbo].[func_GioiTinhSinhVienQuanLy] (@MaNQL char(10) , @gioitinh nvarchar(10))
	returns table
		as
			return 
				select SV.MaSinhVien as [Mã Sinh Viên],
						SV.HoTen as [Họ Tên],
						SV.SoDienThoai as [Số Điện Thoại],
						SV.GioiTinh as [Giới Tính],
						SV.NamHoc as [Năm Học],
						SV.TonGiao as [Tôn Giáo],
						SV.QuocTich as [Quốc Tịch],
						SV.CMND_CCCD as [CMND/CCCD]
				from 
					   Phong inner join Toa on Toa.TenToa = Phong.Toa
							 inner join SinhVien as SV on Phong.MaPhong = SV.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL and SV.GioiTinh = @gioitinh

ALTER function [dbo].[func_SoLuongSinhVienTheoGioiTinh] (@MaNQL char(10), @gioitinh nvarchar(5))
returns int
as
begin 
	declare @soluong int
	select @soluong = count(MaSinhVien)
	from Phong inner join Toa on Toa.TenToa = Phong.Toa
				inner join SinhVien as SV on Phong.MaPhong = SV.MaPhong
	where Toa.MaNguoiQuanLy = @MaNQL and SV.GioiTinh = @gioitinh
	return @soluong
end

ALTER procedure [dbo].[proc_ThemSinhVien]
(@masv char(10), @tensv nvarchar(50), @sdt nchar(50), @gioitinh nvarchar(10),
 @namhoc int, @tongiao nvarchar(10), @quoctich nvarchar(10), @cmnd_cccd char(15), @maphong char(10) )
as insert into SinhVien values(@masv, @tensv, @sdt, @gioitinh, @namhoc, @tongiao, @quoctich, @cmnd_cccd, @maphong);

ALTER procedure [dbo].[proc_XoaSinhVien]
( @masv char(10) )
as delete SinhVien where MaSinhVien = @masv;

ALTER procedure [dbo].[proc_SuaSinhVien]
(	@masv char(10) ,
	@tensv nvarchar(50),
	@sdt nchar(50),
	@gioitinh nvarchar(10),
	@namhoc int,
	@tongiao nvarchar(10),
	@quoctich nvarchar(10),
	@cmnd_cccd char(15),
	@maphong char(10) )
as update SinhVien
set MaSinhVien = @masv,
	HoTen = @tensv,
	SoDienThoai = @sdt,
	GioiTinh = @gioitinh,
	NamHoc = @namhoc,
	TonGiao = @tongiao,
	QuocTich = @quoctich,
	CMND_CCCD = @cmnd_cccd,
	MaPhong = @maphong
where MaSinhVien = @masv

ALTER function [dbo].[func_DanhSachSinhVienTheoMSSV](@MSSV char(10))
returns table as
return(select SV.MaSinhVien as [Mã Sinh Viên],
	   SV.HoTen as [Họ Tên],
	   SV.SoDienThoai as [Số Điện Thoại],
	   SV.GioiTinh as [Giới Tính],
	   SV.NamHoc as [Năm Học],
	   SV.TonGiao as [Tôn Giáo],
	   SV.QuocTich as [Quốc Tịch],
	   SV.CMND_CCCD as [CMND/CCCD],
	   SV.MaPhong as[Mã Phòng]
	   FROM SinhVien as SV
	   where SV.MaSinhVien = @MSSV);


-- Thiết bị trong phòng
ALTER function [dbo].[func_ThietBiQuanLy] (@MaNQL char(10))
returns table
	as
		return select	tb.MaThietBiTrongPhong as [Mã thiết bị],
						tb.MaPhong as [Mã phòng],
						tb.SoLuongHong as [Số lượng hỏng],
						tb.SoLuongTot as [Số lượng tốt],
						tb.SoLuongToiDa as [Số lượng tối đa]
				from Phong inner join Toa on Toa.TenToa = Phong.Toa
						   inner join ThietBiTrongPhong as tb on Phong.MaPhong = tb.MaPhong
				where Toa.MaNguoiQuanLy = @MaNQL

ALTER function [dbo].[func_MaThietBi] ()
returns table
	as
		return select	tb.MaThietBi 
				from  TrangThietBi as tb 

ALTER procedure [dbo].[proc_ThemThietBiTrongPhong]
(	@matb char(10),
	@maphong char(10),
	@soluonghong int,
	@soluongtot int,
	@soluongtoida int
	)
as insert into ThietBiTrongPhong Values(@matb, @maphong, @soluonghong, @soluongtot, @soluongtoida);

ALTER procedure [dbo].[proc_SuaThietBiTrongPhong]
(	@matb char(10),
	@maphong char(10),
	@soluonghong int,
	@soluongtot int,
	@soluongtoida int
	)
as update ThietBiTrongPhong
set MaThietBiTrongPhong = @matb,
	MaPhong = @maphong,
	SoLuongHong = @soluonghong,
	SoLuongTot = @soluongtot,
	SoLuongToiDa = @soluongtoida
where MaThietBiTrongPhong = @matb and MaPhong = @maphong;

ALTER procedure [dbo].[proc_XoaThietBiTrongPhong] (@matb char(10), @maphong char(10))
as delete ThietBiTrongPhong where MaThietBiTrongPhong = @matb and MaPhong = @maphong