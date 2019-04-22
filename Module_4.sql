
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
alter proc SPTheoHD (@IDHD int)
as
begin
select CHITIETHOADON.*, TenSP,DVT 
from CHITIETHOADON join SANPHAM on SANPHAM.IDSP = CHITIETHOADON.IDSP
where CHITIETHOADON.IDHD = @IDHD
end

SPTheoHD 14
select * from SANPHAM
update SANPHAM set TenSP = N'Máy giặt' where IDSP = 16