--proc tìm kiếm hóa đơn
alter proc TimKiemHD(@Ten nvarchar(250))
as
begin
select HOADON.*,TenKH,TenNV from KHACHHANG,HOADON,NHANVIEN
where (KHACHHANG.TenKH like N'%'+@Ten+'%' or TenNV like N'%'+@Ten+'%') and KHACHHANG.IDKH = HOADON.IDKH and NHANVIEN.IDNV = HOADON.IDNV
end
-------------------
TimKiemHD N'Tuyền'
------------------------------------------------------------------------------
select * from 
HOADON join CHITIETHOADON on HOADON.IDHD = CHITIETHOADON.IDHD 
join SANPHAM on SANPHAM.IDSP = CHITIETHOADON.IDSP
where HOADON.IDHD = 15
--lấy chi tiết hóa đơn
alter proc SPTheoHD (@IDHD int)
as
begin
select CHITIETHOADON.*, TenSP,DVT 
from CHITIETHOADON join SANPHAM on SANPHAM.IDSP = CHITIETHOADON.IDSP
where CHITIETHOADON.IDHD = @IDHD
end


select * from SANPHAM
update SANPHAM set TenSP = N'Máy giặt' where IDSP = 16

-- proc tìm kiếm phiếu đổi trả

alter proc TimKiemPT(@Ten nvarchar(250))
as
begin
	select DOITRA.*,TenKH,TenNV from DOITRA join KHACHHANG on DOITRA.IDKH = KHACHHANG.IDKH join NHANVIEN on NHANVIEN.IDNV = DOITRA.IDNV
	where(KHACHHANG.TenKH like N'%'+@Ten+'%' or TenNV like N'%'+@Ten+'%')
end

TimKiemPT N''
select * from DOITRA
select * from KHACHHANG where IDKH = 21

-- lấy chi tiết phiếu đổi theo mã phiếu đổi
alter proc TimKiemCTPT (@IDPT int)
as
begin
	select CHITIETDOITRA.*,TenSP,CHITIETHOADON.Gia
	from CHITIETDOITRA join SANPHAM on SANPHAM.IDSP = CHITIETDOITRA.IDSP 
					   join CHITIETHOADON on CHITIETDOITRA.IDHoaDon = CHITIETHOADON.IDHD and CHITIETDOITRA.IDSP = CHITIETHOADON.IDSP
	where IDDoiTra = @IDPT
end

TimKiemCTPT 1