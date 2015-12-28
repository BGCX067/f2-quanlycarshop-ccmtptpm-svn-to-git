exec [PROC_MAU_Insert] 'Xanh', N'Màu Xanh'
exec [PROC_MAU_Insert] 'Do', N'Màu Đỏ'
exec [PROC_MAU_Insert] 'Xam', N'Màu Xám'
exec [PROC_MAU_Insert] 'Den', N'Màu Đen'
exec [PROC_MAU_Insert] 'Trang', N'Màu Trắng'
exec [PROC_MAU_Insert] 'Do_Den', N'Đỏ_Đen'
exec [PROC_MAU_Insert] 'Trang_Den', N'Trắng_Đen'

exec [PROC_LOAIXE_Insert] N'Xe con', N'4,5,6,7 chỗ'
exec [PROC_LOAIXE_Insert] N'Xe khách', N'9,15,22,36,45 chỗ'
exec [PROC_LOAIXE_Insert] N'Xe tải', N'800 Kg, 1,2 tấn, 1,5 tấn, 2,1 tấn, 3,5 tấn, 4,5 tấn, 7 tấn, 8 tấn, 10 tấn'

exec [PROC_KIEUXE_Insert] 1, N'Thường'--1

exec [PROC_KIEUXE_Insert] 1, N'Thể thao'--2

exec [PROC_KIEUXE_Insert] 2, N'Xe gia đình'--3

exec [PROC_KIEUXE_Insert] 2, N'Xe khách lớn'--4

exec [PROC_KIEUXE_Insert] 3, N'Xe tải nhẹ'--5

exec [PROC_KIEUXE_Insert] 3, N'Xe tải nặng'--6

exec [PROC_LOAINHANVIEN_Insert] N'Quản lý'
exec [PROC_LOAINHANVIEN_Insert] N'Thu ngân'
exec [PROC_LOAINHANVIEN_Insert] N'Bán hàng'

exec [PROC_NHANVIEN_Insert] N'Nguyễn Thanh An', 1, 'ntan', 'ntan', 1, '3/20/1978', N'83 Nguyễn Cư Trinh P5 Q1', '090243783', '2773289812'
exec [PROC_NHANVIEN_Insert] N'Mai Anh Thúy', 2, 'mathuy', 'mathuy', 0, '7/8/1986', N'101/2B An Dương Vương P7 Q5', '092459894', '277595894'
exec [PROC_NHANVIEN_Insert] N'Nguyễn Thị Ánh Tuyết', 2, 'ntatuyet', 'ntatuyet', 0, '9/30/1988', N'67 Nguyễn Trãi P6 Q5', '01223058870', '2779274797'
exec [PROC_NHANVIEN_Insert] N'Trần Quốc Tuấn', 3, 'tqtuan', 'tqtuan', 1, '1/6/1982', N'100 Phan Huy Ích P3 Q Gò Vấp', '0986722890', '2773398749'
exec [PROC_NHANVIEN_Insert] N'Võ Thành Nhật', 3, 'vtnhat', 'vtnhat', 1, '5/25/1983', N'8/2B Âu Cơ P14 Q Tân Bình', '0959989783', '271124422'

exec [PROC_HANGSANXUAT_Insert] N'WBM'--1
exec [PROC_HANGSANXUAT_Insert] N'Mitsubishi'--2
exec [PROC_HANGSANXUAT_Insert] N'Suzuki' --3
exec [PROC_HANGSANXUAT_Insert] N'Tozota' --4
exec [PROC_HANGSANXUAT_Insert] N'Chevrolet' --5
exec [PROC_HANGSANXUAT_Insert] N'Fiat' --6
exec [PROC_HANGSANXUAT_Insert] N'Ford' --7
exec [PROC_HANGSANXUAT_Insert] N'Honda' --8
exec [PROC_HANGSANXUAT_Insert] N'Isuzu'--9 


exec [PROC_KHACHHANG_Insert] N'Trần Hy Hữu', 1, N'10 Nguyễn Kiệm P9 Q Phú Nhuận', '089408094', '211877798', 1
exec [PROC_KHACHHANG_Insert] N'Nguyễn Thị Hoa', 0, N'131 Lạc Long Quân P2 Q11', '09492803', '13979983', 1
exec [PROC_KHACHHANG_Insert] N'Nguyễn Minh Thư', 0, N'67 Huỳnh Tấn Phất P10 Q7', '08246833', '22324248', 1
exec [PROC_KHACHHANG_Insert] N'Ngô Thị Bé', 0, N'245 Âu Cơ P9 Q Tân Bình', '089294923', '211877798', 1
exec [PROC_KHACHHANG_Insert] N'Ngô Quốc Dũng', 1, N'21/3B Hoàng Diệu P2 Q Phú Nhuận', '08980467', '21739934', 1
exec [PROC_KHACHHANG_Insert] N'Trần Minh Chánh', 1, N'198 Nguyễn Trãi P9 Q1', '009787433', '773931803', 1
exec [PROC_KHACHHANG_Insert] N'Quách Phú Thành', 1, N'234/12 Nơ Trang Long P8 Q Bình Thạnh', '0892892803', '217287273', 0
exec [PROC_KHACHHANG_Insert] N'Nguyễn Ngọc Thanh', 1, N'10 Nguyễn Kiệm P9 Q Phú Nhuận', '089408094', '211877798', 0
exec [PROC_KHACHHANG_Insert] N'Ngô Thừa Húc', 1, N'100 Phó Cơ Điều P9 Q11', '08353594', '25355598', 0
exec [PROC_KHACHHANG_Insert] N'Tạ Truyển Thanh', 1, N'109/1A Phạm Viết Chánh P3 Q1', '078889189', '2112425598', 0

exec [PROC_XE_Insert] N'320i', 1, 1, 2009, 12.4, 200, N'đường trường', 4, 62900, 62700, 3--1
exec [PROC_XE_Insert] N'730Li E60', 2, 1, 2009, 20.4, 200, N'vượt địa hình', 4, 199900, 199700, 1--2
exec [PROC_XE_Insert] N'X5 3.0 Si', 1, 1, 2009, 15.4, 200, N'đường trường', 7, 164000, 163800, 3--3

exec [PROC_XE_Insert] N'Gransis 2.4 AT', 1, 2, 2009, 12.4, 200, N'đường trường', 4, 47460, 47260, 2--4
exec [PROC_XE_Insert] N'Pajero Supreme', 1, 2, 2009, 18.4, 200, N'đường trường', 5, 52800, 52600, 2--5
exec [PROC_XE_Insert] N'ZingerGL', 1, 2, 2009, 16.4, 200, N'đường trường', 6, 29925, 29725, 1--6

exec [PROC_XE_Insert] N'APV GL-B', 2, 3, 2009, 30.4, 200, N'vượt địa hình', 4, 22422, 22222, 1--7
exec [PROC_XE_Insert] N'SWIFT 4MT', 3, 3, 2009, 20.4, 200, N'đường trường', 15, 29000, 28800, 2--8

exec [PROC_XE_Insert] N'ALTIS 1.8 AT', 4, 4, 2009, 26.2, 200, N'đường trường', 36, 35500, 35300, 2--9
exec [PROC_XE_Insert] N'CamRy 3.5Q', 5, 4, 2009,12.9, 200, N'đất, cát, sình', 3, 68700, 68500, 2--10
exec [PROC_XE_Insert] N'Innova G', 6, 4, 2009, 12.9, 200, N'đất, cát', 3, 32600, 32400, 2--11
exec [PROC_XE_Insert] N'Land cruiser', 4, 4, 2009, 23.8, 200, N'đường trường', 45, 125000, 124800, 2--12
exec [PROC_XE_Insert] N'VIS 1.5E', 3, 4, 2009, 17.7, 200, N'vượt địa hình', 4, 25100, 24900, 2--13

exec [PROC_XE_Insert] N'Captival LS', 3, 5, 2009, 12.9, 200, N'vượt địa hình', 4, 28400, 28200, 2--14
exec [PROC_XE_Insert] N'Vivan CDX', 5, 5, 2009, 23.9, 150, N'đất, cát, sình', 3, 23800, 23600, 2--15

exec [PROC_XE_Insert] N'Albea HLX 1.6', 3, 6, 2009, 18.5, 250, N'đất, cát, sình', 15, 20900, 20700, 2--16
exec [PROC_XE_Insert] N'Doblo 1.6', 6, 6, 2009, 22.1, 150, N'đất, cát', 2, 18200, 18000, 2--17

exec [PROC_XE_Insert] N'Escape XLS 4X2', 3, 7, 2009, 17.0, 150, N'đường trường', 9, 35100, 34900, 2--18
exec [PROC_XE_Insert] N'Ranger 4X4 XLT', 4, 7, 2009, 20.0, 150, N'đường trường', 22, 30300, 30100, 2--19
exec [PROC_XE_Insert] N'Everest diesel 4X2 AT TDCi', 3, 7, 2009, 19.0, 150, N'đất, cát, sình', 3, 39800, 39600, 2--20
exec [PROC_XE_Insert] N'Focus 1.8 AT',2, 7, 2009, 29.2, 150, N'vượt địa hình', 6, 27400, 27200, 2--21

exec [PROC_XE_Insert] N'Civic AT 1.8',1, 8, 2009, 12.2, 270, N'đường trường',7, 32800, 32800, 2--22
exec [PROC_XE_Insert] N'CRV AT',2, 8, 2009, 29.2, 400, N'đường trường',1, 49700, 49500, 2--23

exec [PROC_XE_Insert] N'FRR90N',5, 9, 2009, 14.3, 400, N'đất, cát, sình',3, 36394, 36294, 2--24
exec [PROC_XE_Insert] N'FVR34L',6, 9, 2009, 16.2, 400, N'đất, cát',3, 51090, 50890, 2--25
exec [PROC_XE_Insert] N'NLR55E',4, 9, 2009, 10.2, 400, N'đường trường',15, 18772, 18572, 2--26
exec [PROC_XE_Insert] N'XTreme AT',3, 9, 2009, 18.9, 400, N'đường trường',36, 26309, 26109, 2--27

exec [PROC_MAUXE_Insert] 1, 'Xanh', 1
exec [PROC_MAUXE_Insert] 1, 'Den', 2

exec [PROC_MAUXE_Insert] 2, 'Den', 1

exec [PROC_MAUXE_Insert] 4, 'Den', 1
exec [PROC_MAUXE_Insert] 4, 'Do_Den', 1

exec [PROC_MAUXE_Insert] 5, 'Den', 2
exec [PROC_MAUXE_Insert] 6, 'Trang', 1
exec [PROC_MAUXE_Insert] 7, 'Trang', 1

exec [PROC_MAUXE_Insert] 8, 'Trang_Den', 2
exec [PROC_MAUXE_Insert] 9, 'Xanh', 2
exec [PROC_MAUXE_Insert] 10, 'Trang_Den', 2
exec [PROC_MAUXE_Insert] 11, 'Trang', 2
exec [PROC_MAUXE_Insert] 12, 'Do', 2
exec [PROC_MAUXE_Insert] 13, 'Do', 2
exec [PROC_MAUXE_Insert] 14, 'Xanh', 2
exec [PROC_MAUXE_Insert] 15, 'Trang', 2
exec [PROC_MAUXE_Insert] 16, 'Do', 2
exec [PROC_MAUXE_Insert] 17, 'Den', 2
exec [PROC_MAUXE_Insert] 18, 'Xam', 2
exec [PROC_MAUXE_Insert] 19, 'Do_Den', 2
exec [PROC_MAUXE_Insert] 20, 'Trang', 2
exec [PROC_MAUXE_Insert] 21, 'Den', 2
exec [PROC_MAUXE_Insert] 22, 'Do', 2
exec [PROC_MAUXE_Insert] 23, 'Do', 2
exec [PROC_MAUXE_Insert] 24, 'Xanh', 2
exec [PROC_MAUXE_Insert] 25, 'Do_Den', 2
exec [PROC_MAUXE_Insert] 26, 'Xam', 2
exec [PROC_MAUXE_Insert] 27, 'Trang', 2


exec [PROC_DONDATHANG_Insert] '2/1/2009', 115700, 2
exec [PROC_DONDATHANG_Insert] '4/5/2009', 71722, 3
exec [PROC_DONDATHANG_Insert] '6/15/2009', 88872, 3
exec [PROC_DONDATHANG_Insert] '8/2/2009', 125000, 1

exec [PROC_CTDONDATHANG_Insert] 1, 1, 'Den', 1, 62900
exec [PROC_CTDONDATHANG_Insert] 1, 5, 'Den', 1, 52800

exec [PROC_CTDONDATHANG_Insert] 2, 7, 'Trang', 1, 22422
exec [PROC_CTDONDATHANG_Insert] 2, 14, 'Xanh', 1, 28400
exec [PROC_CTDONDATHANG_Insert] 2, 16, 'Do', 1, 20900

exec [PROC_CTDONDATHANG_Insert] 3, 22, 'Do', 1, 30300
exec [PROC_CTDONDATHANG_Insert] 3, 26, 'Xam', 1, 18772
exec [PROC_CTDONDATHANG_Insert] 3, 20, 'Trang', 1, 39800

exec [PROC_CTDONDATHANG_Insert] 4, 12, 'Do', 1, 125000


exec [PROC_HOADON_Insert] 1, 2, '3/3/2009', 0, 62900, 62900, 1--1
exec [PROC_HOADON_Insert] 2, 3, '4/19/2009', 1, 62900, 21000, 3--2
exec [PROC_HOADON_Insert] 3, 3, '4/20/2009', 0, 28400, 28400, 1--3
exec [PROC_HOADON_Insert] 4, 3, '5/20/2009', 0, 20900, 20900, 1--4
exec [PROC_HOADON_Insert] 5, 2, '5/25/2009', 1, 52800, 17600, 3--5
exec [PROC_HOADON_Insert] 6, 2, '6/10/2009', 1, 32800, 16400, 2--6
exec [PROC_HOADON_Insert] 7, 3, '6/20/2009', 0, 164000, 164000, 1--7
exec [PROC_HOADON_Insert] 8, 2, '7/1/2009', 0, 18772, 18772, 1--8
exec [PROC_HOADON_Insert] 9, 3, '7/17/2009', 1, 125000, 31250, 4--9
exec [PROC_HOADON_Insert] 10, 2, '8/2/2009', 1, 39800, 19900, 2--10

exec [PROC_CHITIETHOADON_Insert] 1, 1, 'Xanh', 1, 62900
exec [PROC_CHITIETHOADON_Insert] 2, 1, 'Den', 1, 21000
exec [PROC_CHITIETHOADON_Insert] 3, 14, 'Xanh', 1, 28400
exec [PROC_CHITIETHOADON_Insert] 4, 16, 'Do', 1, 20900
exec [PROC_CHITIETHOADON_Insert] 5, 5, 'Den', 1, 17600
exec [PROC_CHITIETHOADON_Insert] 6, 22, 'Trang', 1, 16400
exec [PROC_CHITIETHOADON_Insert] 7, 7, 'Trang', 1, 164000
exec [PROC_CHITIETHOADON_Insert] 8, 26, 'Xam', 1, 18772
exec [PROC_CHITIETHOADON_Insert] 9, 12, 'Do', 1, 31250
exec [PROC_CHITIETHOADON_Insert] 10, 20, 'Trang', 1, 19900


exec [PROC_PHIEUNHAPXE_Insert] 1, '3/7/2009', 2
exec [PROC_PHIEUNHAPXE_Insert] 2, '5/10/2009', 3
exec [PROC_PHIEUNHAPXE_Insert] 3, '7/20/2009', 3

exec [PROC_CTPHIEUNHAPXE_Insert] 1, 1, 'Den', 1
exec [PROC_CTPHIEUNHAPXE_Insert] 1, 5, 'Den', 1

exec [PROC_CTPHIEUNHAPXE_Insert] 2, 7, 'Trang', 1
exec [PROC_CTPHIEUNHAPXE_Insert] 2, 14, 'Xanh', 1
exec [PROC_CTPHIEUNHAPXE_Insert] 2, 16, 'Do', 1

exec [PROC_CTPHIEUNHAPXE_Insert] 3, 22, 'Do', 1
exec [PROC_CTPHIEUNHAPXE_Insert] 3, 26, 'Xam', 1
exec [PROC_CTPHIEUNHAPXE_Insert] 3, 20, 'Trang', 1

exec [PROC_PHIEUXUATXE_Insert] '3/3/2009', 1, 1--1
exec [PROC_PHIEUXUATXE_Insert] '4/19/2009', 1, 1--2
exec [PROC_PHIEUXUATXE_Insert] '4/20/2009', 1, 1--3
exec [PROC_PHIEUXUATXE_Insert] '5/20/2009', 1, 1--4
exec [PROC_PHIEUXUATXE_Insert] '5/25/2009', 1, 1--5
exec [PROC_PHIEUXUATXE_Insert] '6/10/2009', 1, 1--6
exec [PROC_PHIEUXUATXE_Insert] '6/20/2009', 1, 1--7
exec [PROC_PHIEUXUATXE_Insert] '7/1/2009', 1, 1--8
exec [PROC_PHIEUXUATXE_Insert] '7/17/2009', 1, 1--9
exec [PROC_PHIEUXUATXE_Insert] '8/2/2009', 1, 1--10

exec [PROC_CHITIETPHIEUXUATXE_Insert] 1, 1, 'Xanh', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 2, 1, 'Den', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 3, 14, 'Xanh', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 4, 16, 'Do', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 5, 5, 'Den', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 6, 22, 'Trang', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 7, 7, 'Trang', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 8, 26, 'Xam', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 9, 12, 'Do', 1
exec [PROC_CHITIETPHIEUXUATXE_Insert] 10, 20, 'Trang', 1

exec [PROC_PHIEUDATXE_Insert] 1, 1, '3/21/2009', '4/20/2009', 45889, 10000
exec [PROC_PHIEUDATXE_Insert] 2, 1, '3/29/2009', '4/19/2009', 32890, 10000
exec [PROC_PHIEUDATXE_Insert] 7, 2, '4/16/2009', '5/20/2009', 20890, 8000
exec [PROC_PHIEUDATXE_Insert] 8, 2, '5/18/2009', '6/10/2009', 34880, 12000
exec [PROC_PHIEUDATXE_Insert] 10, 1, '6/3/2009', '7/1/2009', 19000, 5000

exec [PROC_CHITIETPHIEUDATXE_Insert] 1, 9, 'Den', 1, 45889
exec [PROC_CHITIETPHIEUDATXE_Insert] 2, 9, 'Xanh', 1, 32890
exec [PROC_CHITIETPHIEUDATXE_Insert] 3, 9, 'Do', 1, 20890
exec [PROC_CHITIETPHIEUDATXE_Insert] 4, 9, 'Trang', 1, 34880
exec [PROC_CHITIETPHIEUDATXE_Insert] 5, 9, 'Xam', 1, 19000
