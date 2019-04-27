--proc tìm kiếm hóa đơn
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
alter proc ThemCTPhieuTra(@IDDoiTra int,@IDSP int,@SoLuong int,@LyDo nvarchar(250),@IDHoaDon int,@IMEI nvarchar(250))
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

select IDSP from DOITRA join CHITIETDOITRA on DOITRA.IDDoiTra = CHITIETDOITRA.IDDoiTra
where DOITRA.IDDoiTra = 1

update CHITIETDOITRA set SoLuong = SoLuong+1, LyDo = LyDo+ '|'+N'thích thì đổi', IMEI = IMEI+' ' where IDDoiTra = 1 and IDSP = 20
select * from CHITIETDOITRA where IDDoiTra = 2

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
