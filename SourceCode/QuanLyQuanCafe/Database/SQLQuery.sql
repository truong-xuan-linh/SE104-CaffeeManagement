--Thong ke top 10 do uong duoc mua nhieu nhat----------
select top(10) du.TenDoUong, SUM(SoLuong) AS N'Số lượng đã bán'
from ChiTietHoaDon cthd, DoUong du
where cthd.MaDoUong = du.MaDoUong
group by du.TenDoUong


--Thong ke doanh thu theo thang---------
select NgayLap, Sum(TongTien) AS N'Doanh thu'
from HoaDon
where MONTH(NgayLap) = 8 AND YEAR(NgayLap) = 2020
group by NgayLap

--Thong ke tu ngay den ngay-----------------
select NgayLap, Sum(TongTien) AS N'Doanh thu'
from HoaDon
where NgayLap >= '08/13/2020' AND NgayLap <= '08/14/2020'
group by NgayLap