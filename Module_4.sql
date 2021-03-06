﻿--proc tìm kiếm hóa đơn
create proc TimKiemHD(@Ten nvarchar(250))
as
begin
select HOADON.*,TenKH,TenNV from KHACHHANG,HOADON,NHANVIEN
where (KHACHHANG.TenKH like N'%'+@Ten+'%' or TenNV like N'%'+@Ten+'%') and KHACHHANG.IDKH = HOADON.IDKH and NHANVIEN.IDNV = HOADON.IDNV
end
-------------------
TimKiemHD N''
------------------------------------------------------------------------------
select * from 
HOADON join CHITIETHOADON on HOADON.IDHD = CHITIETHOADON.IDHD 
join SANPHAM on SANPHAM.IDSP = CHITIETHOADON.IDSP
where HOADON.IDHD = 15
--lấy chi tiết hóa đơn
create proc SPTheoHD (@IDHD int)
as
begin
select CHITIETHOADON.*, TenSP,DVT 
from CHITIETHOADON join SANPHAM on SANPHAM.IDSP = CHITIETHOADON.IDSP
where CHITIETHOADON.IDHD = @IDHD
end


select * from SANPHAM
update SANPHAM set TenSP = N'Máy giặt' where IDSP = 16

-- proc tìm kiếm phiếu đổi trả

create proc TimKiemPT(@Ten nvarchar(250))
as
begin
	select DOITRA.*,TenKH,TenNV from DOITRA join KHACHHANG on DOITRA.IDKH = KHACHHANG.IDKH join NHANVIEN on NHANVIEN.IDNV = DOITRA.IDNV
	where(KHACHHANG.TenKH like N'%'+@Ten+'%' or TenNV like N'%'+@Ten+'%')
end

TimKiemPT N''
select * from DOITRA
select * from KHACHHANG where IDKH = 21

-- lấy chi tiết phiếu đổi theo mã phiếu đổi
create proc TimKiemCTPT (@IDPT int)
as
begin
	select CHITIETDOITRA.*,TenSP,CHITIETHOADON.Gia
	from CHITIETDOITRA join SANPHAM on SANPHAM.IDSP = CHITIETDOITRA.IDSP 
					   join CHITIETHOADON on CHITIETDOITRA.IDHoaDon = CHITIETHOADON.IDHD and CHITIETDOITRA.IDSP = CHITIETHOADON.IDSP
	where IDDoiTra = @IDPT
end

TimKiemCTPT 1

select * from KHACHHANG

select max(IDKH) as IDKH from KHACHHANG
select max(IDDoiTra) as IDDoiTra from DOITRA

--------------
create proc ThemCTPhieuTra(@IDDoiTra int,@IDSP int,@SoLuong int,@LyDo nvarchar(250),@IDHoaDon int,@IMEI nvarchar(250))
as
begin
	if(@IDSP not in (select IDSP from DOITRA join CHITIETDOITRA on DOITRA.IDDoiTra = CHITIETDOITRA.IDDoiTra
								where DOITRA.IDDoiTra = @IDDoiTra))
	begin
		insert into CHITIETDOITRA (IDDoiTra,IDSP,SoLuong,LyDo,IDHoaDon,IMEI) values(@IDDoiTra,@IDSP,@SoLuong,@LyDo,@IDHoaDon,@IMEI+ ' ')
		print 'insert'
	end
	else 
	begin
		update CHITIETDOITRA set SoLuong = SoLuong+1, LyDo = LyDo+ '|'+@LyDo, IMEI = IMEI+@IMEI+' ' where IDDoiTra = @IDDoiTra and IDSP = @IDSP
		print 'update'
	end
end
ThemCTPhieuTra 8,22,1, N'123123',13,'15100000123'
select IDSP from DOITRA join CHITIETDOITRA on DOITRA.IDDoiTra = CHITIETDOITRA.IDDoiTra
where DOITRA.IDDoiTra = 1

update CHITIETDOITRA set SoLuong = SoLuong+1, LyDo = LyDo+ '|'+N'thích thì đổi', IMEI = IMEI+' ' where IDDoiTra = 1 and IDSP = 20
select * from CHITIETDOITRA where IDDoiTra = 2
--trigger xóa Phiếu đổi
create trigger XoaPhieuDoiTra on DoiTra instead of delete
as 
declare @IDPT int
begin
	select @IDPT = IDDoiTra from deleted
	delete from CHITIETDOITRA where IDDoiTra = @IDPT
	delete from DOITRA where IDDoiTra = @IDPT
end

select * from DOITRA
delete from DOITRA where IDDoiTra = 7
select * from CHITIETDOITRA where IDDoiTra = 8
update CHITIETDOITRA set SoLuong = 1 where IDDoiTra = 8 and IDSP = 25
select * from DOITRA join CHITIETDOITRA on DOITRA.IDDoiTra = CHITIETDOITRA.IDDoiTra where DOITRA.IDDoiTra = 8
update CHITIETDOITRA set LyDo = N'333333' where CHITIETDOITRA.IDDoiTra = 8 and IDSP = 25
--proc sửa thông tin phiếu đổi

create proc SuaPhieuDoi(@IDPhieuTra int, @NgayTra Date,@IDKH int,@TenKH nvarchar(250),@IDNhanVien int)
as
begin
	update KHACHHANG set TenKH = @TenKH where IDKH = @IDKH
	update DOITRA set IDNV = @IDNhanVien, NgayDoi = @NgayTra where IDDoiTra = @IDPhieuTra
end



--proc tìm kiếm khách hàng

create proc TimKiemKH(@param nvarchar(250))
as
begin
	select * from KHACHHANG
	where CONVERT(nvarchar(250),IDKH) = @param
		or TenKH like CONCAT('%',@param,'%')  
		or SoDT like CONCAT('%',@param,'%') 
		or TenDV like CONCAT('%',@param,'%') 
		or MaSoThue like CONCAT('%',@param,'%') 
		or DiaChi like CONCAT('%',@param,'%') 
		or SoTK like CONCAT('%',@param,'%') 

end

TimKiemKH N'07'
-- tạo trigger xóa khách hàng
create trigger XoaKH on Khachhang instead of delete
as
declare @maKH int
begin
	select @maKH = IDKH from deleted
	update HOADON set IDKH = null where IDKH = @maKH
	update DOITRA set IDKH = null where IDKH = @maKH
	update BAOHANH set IDKH = null where IDKH = @maKH
	delete from KHACHHANG where IDKH = @maKH
end
select * from KHACHHANG where IDKH = 32
update KHACHHANG set TenKH = N'Nguyễn Ngọc Hiệp', TenDV = N'MTA',MaSoThue = '5629423651', DiaChi = N'Hà Nội',SoTK = '0711000296950',SoDT = N'0968958647' where IDKH = 32
select TenKH from DOITRA,KHACHHANG where DOITRA.IDKH = KHACHHANG.IDKH and IDDoiTra = 1
select TenKH from DOITRA,KHACHHANG where DOITRA.IDKH = KHACHHANG.IDKH and IDDoiTra = 3
select SoDT from DOITRA,KHACHHANG where DOITRA.IDKH = KHACHHANG.IDKH and IDDoiTra = 1 
select sum(CHITIETDOITRA.SoLuong*CHITIETHOADON.Gia) from CHITIETDOITRA join CHITIETHOADON on CHITIETDOITRA.IDHoaDon = CHITIETHOADON.IDHD and CHITIETHOADON.IDSP = CHITIETDOITRA.IDSP where IDDoiTra = 2
select * from CHITIETDOITRA where IDDoiTra = 1
TRUNCATE TABLE CHITIETDOITRA
select TenNV from DOITRA,NHANVIEN where DOITRA.IDNV = NHANVIEN.IDNV and IDDoiTra = 3
select max(IDDoiTra) as IDDoiTra from DOITRA