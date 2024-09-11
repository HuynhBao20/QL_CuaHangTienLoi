﻿create database [QL_CHTienLoi]
go
use [QL_CHTienLoi]
go
CREATE TABLE THONGTINCUAHANG
(
	MACH	NCHAR(10) PRIMARY KEY,
	DIACHI	NVARCHAR(200),
	SDT		NCHAR(11),
	EMAIL	NCHAR(40),
	HOTEN	NVARCHAR(40)
)
GO

insert into THONGTINCUAHANG values ('CH001', N'140 Lê Trọng Tấn, Phường Tây Thạnh, Quận Tân Phú, TPHCM', '0334661938', 'huynhthebao.201020020@gmail.com', N'Huỳnh Thế Bảo')
--bảng nhân viên
CREATE TABLE NHANVIEN
(
	MANV		NCHAR(10) PRIMARY KEY CHECK(MANV LIKE 'NV%'),
	HOTEN		NVARCHAR(50),
	NGAYSINH	DATE, --Ngày sinh
	NGAYVL		DATE, --Ngày vào làm
	SDT			NCHAR(11),
	CCCD		NCHAR(13),
	DIACHI		NVARCHAR(MAX)
)
GO

--bảng loại sản phẩm
CREATE TABLE LOAISP
(
	MALOAI	INT PRIMARY KEY,
	TENLOAI	NVARCHAR(50)
)

GO
CREATE TABLE PHIEUNHAP
(
	MAPN	NCHAR(10) PRIMARY KEY CHECK(MAPN LIKE 'N%'),
	NGAYNHAP	DATETIME DEFAULT GETDATE(),
	MANV	NCHAR(10),
	TRANGTHAI NVARCHAR(30) CHECK(TRANGTHAI = N'Đã duyệt' OR TRANGTHAI = N'Chưa duyệt') default N'Chưa duyệt',
	CONSTRAINT FK_PHIEUNHAP_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
)
--bảng kho
CREATE TABLE CTPHIEUNHAP
(
	MAPN	NCHAR(10) CHECK(MAPN LIKE 'N%'),
	MASP	NCHAR(10),
	SLNHAP	INT CHECK (SLNHAP >= 0),
	GIANHAP	FLOAT CHECK (GIANHAP >= 0),
	NGAYSX DATE,
	NGAYHH	DATE,
	DVT NVARCHAR(20),
	PRIMARY KEY (MAPN, MASP),
	FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
	FOREIGN KEY (MAPN) REFERENCES PHIEUNHAP(MAPN)
)
GO
--bảng sản phẩm
CREATE TABLE SANPHAM
(
	MASP	NCHAR(10) PRIMARY KEY CHECK(LEN(MASP) = 8 OR MASP like '%HT' OR MASP LIKE '%'),
	TENSP	NVARCHAR(100),
	MALOAI	INT,
	NGAYSX	DATE,
	NGAYHH	DATE, --Ngày hết hạn
	DONGIA	FLOAT CHECK (DONGIA > 0),
	CONSTRAINT FK_SANPHAM_MALOAI FOREIGN KEY (MALOAI) REFERENCES LOAISP(MALOAI)
)
GO

GO
--Bảng khách hàng
CREATE TABLE KHACHHANG
(
	MAKH	NCHAR(10) PRIMARY KEY CHECK(MAKH LIKE 'KH%' OR MAKH LIKE 'VL%'),
	HOTEN	NVARCHAR(50),
	SDT		CHAR(11) UNIQUE,
	DIACHI	NVARCHAR(MAX),
	LOAIKH	NVARCHAR(20) DEFAULT N'Khách vãng lai' CHECK(LOAIKH = N'Khách vãng lai' OR LOAIKH = N'Khách tích điểm')
)
GO
--Bảng hóa đơn
CREATE TABLE HOADON
(
	MAHD	NCHAR(10) PRIMARY KEY,
	MAKH	NCHAR(10),
	MANV	NCHAR(10),
	NGAYLAP	DATETIME DEFAULT GETDATE(),
	TRANGTHAI NVARCHAR(30) CHECK(TRANGTHAI = N'Đã xuất hóa đơn' or TRANGTHAI = N'Chưa xuất' OR TRANGTHAI = N'Đã hủy') default N'Chưa xuất',
	TIENKD	FLOAT DEFAULT 0, --Tiền khách đưa
	CONSTRAINT FK_HOADON_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_HOADON_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

GO
--Bảng chi tiết hóa đơn
CREATE TABLE CT_HOADON
(
	MAHD	NCHAR(10),
	MASP	NCHAR(10),
	SOLUONG	INT CHECK(SOLUONG > 0),
	CONSTRAINT PK_CT_HOADON PRIMARY KEY (MAHD, MASP),
	CONSTRAINT FK_CT_HOADON_MAHD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
	CONSTRAINT FK_CT_HOADON_MASP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)
)
GO
--bảng tích điểm
CREATE TABLE TICHDIEM
(
	MAKH	NCHAR(10),
	MAHD	NCHAR(10),
	NGAYTICH	DATETIME DEFAULT CAST(GETDATE() AS DATETIME),
	PRIMARY KEY(MAKH, MAHD),
	CONSTRAINT FK_TICHDIEM_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_TICHDIEM_MAHD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
)

GO
--Bảng Khuyến Mãi
CREATE TABLE KHUYENMAI
(
	MAKM	NCHAR(10) PRIMARY KEY CHECK(MAKM LIKE 'KM%'),
	TENKM	NVARCHAR(200) NOT NULL,
	MASP	NCHAR(10),
	NGAYBD	DATETIME DEFAULT GETDATE(),
	NGAYHH	DATETIME,
	SLMUA	INT CHECK(SLMUA > 0),
	SPTANG	NCHAR(10),
	CONSTRAINT FK_KHUYENMAI_MASP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
	CONSTRAINT FK_KHUYENMAI_SPTANG FOREIGN KEY (SPTANG) REFERENCES SANPHAM(MASP),
)
GO
--TRIGGER
--Summary: TRIGGER Này dùng để ràng buộc ngày sản xuất phải nhỏ hơn hạn sử dụng.
CREATE TRIGGER NgaySX 
ON SANPHAM
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NgaySX > NgayHH
    )
    BEGIN
        PRINT 'THÊM THẤT BẠI';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        PRINT 'THÊM THÀNH CÔNG'; 
    END
END
GO
--Summary: TRIGGER Này dùng để ràng buộc ngày sinh phải nhỏ hơn ngày hiện tại. (Update 5/8)
CREATE TRIGGER Is_Age
ON NHANVIEN
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS (
		SELECT 1
		FROM inserted
		WHERE NGAYSINH >= GETDATE()
	)
	BEGIN
		PRINT N'Ngày sinh phải bé hơn ngày hiện tại'
		ROLLBACK TRANSACTION;
	END
	ELSE 
	BEGIN
		IF(SELECT DATEDIFF(YEAR,NGAYSINH, CAST(GETDATE() as date)) FROM inserted) < 16
		BEGIN
			PRINT N'Chưa đủ tuổi lao động';
			ROLLBACK TRANSACTION;
		END
		ELSE
			PRINT N'Thêm thành công'
	END
END
GO
--Summary: TRIGGER Này dùng để ràng buộc sau khi xuất hóa đơn không được chỉnh sửa
CREATE TRIGGER IS_Bill_Cancle
ON CT_HOADON
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON
	if EXISTS (SELECT 1 
		FROM deleted, HOADON hd, CT_HOADON ct 
		WHERE hd.MAHD = ct.MAHD AND TRANGTHAI = N'Đã xuất hóa đơn') 
		BEGIN
			PRINT N'Đã xuất hóa đơn không được xóa';
			ROLLBACK TRANSACTION;
		END
	ELSE
		BEGIN
			PRINT 'Thành công';
			COMMIT TRANSACTION;
		END
END
DROP TRIGGER IS_Bill_Cancle
GO
CREATE TRIGGER Is_Bill
ON HOADON
AFTER UPDATE 
AS 
BEGIN
	IF EXISTS (SELECT 1 
               FROM INSERTED i 
               JOIN DELETED d ON i.MAHD = d.MAHD
               WHERE i.TRANGTHAI = N'Đã hủy' AND d.TRANGTHAI != N'Đã hủy')
    BEGIN
        -- Nếu có, thông báo và hủy giao dịch
        PRINT N'Hóa đơn đã xuất không được thay đổi';
        ROLLBACK TRAN;
    END
	ELSE
		BEGIN
			PRINT N'Thành công';
			COMMIT TRAN
		END
END
GO
--INSERT INTO NHANVIEN VALUES ('N0001''NV001', 'Huỳnh Thế Bảo', '2002-10-20', '2024-04-20', 'Admin', '0334661938', '083432122454', N'Thạnh Hóa, Long An')
--PROCEDURE STORE
--Xuất sản phẩm ra
ALTER PROC Select_CTHoaDon @MAHD NCHAR(10)
AS
BEGIN 
	SELECT ct.MASP AS N'Mã sản phẩm', 
	   sp.TENSP AS N'Tên sản phẩm', 
	   sp.DONGIA AS N'Đơn giá', 
	   ct.SOLUONG as N'Số lượng', 
	   ct.SOLUONG * sp.DONGIA as N'Thành tiền'
	FROM CT_HOADON ct, SANPHAM sp
	WHERE ct.MASP = sp.MASP AND MAHD = @MAHD
END
GO
--Tính tổng thành tiền
CREATE PROC Tong_ThanhTien @MAHD NCHAR(10)
AS
BEGIN
	SELECT ct.MAHD, sum(SOLUONG * DONGIA) as 'Thành tiền'
	FROM CT_HOADON ct, SANPHAM sp
	WHERE ct.MASP = sp.MASP AND MAHD = @MAHD
	GROUP BY ct.MAHD
END
GO
--Xuất hóa đơn 
CREATE PROC sp_XuatHoaDon @MAHD NCHAR(10)
AS
BEGIN
	SELECT	ct.MAHD, 
			nv.HOTEN,
			hd.NGAYLAP,
			sp.TENSP, 
			ct.SOLUONG, 
			sp.DONGIA, 
			ct.SOLUONG * sp.DONGIA AS N'Thành Tiền',
			hd.TIENKD
	FROM CT_HOADON ct, HOADON hd, NHANVIEN nv, SANPHAM sp
	where ct.MAHD = hd.MAHD AND hd.MANV = nv.MANV AND sp.MASP = ct.MASP AND ct.MAHD = @MAHD
END
GO
--Thống kê hóa đơn
CREATE PROC sp_ThongKe
AS 
BEGIN
	SELECT ct.MAHD as N'Mã hóa đơn', SUM(sp.DONGIA * ct.SOLUONG) as N'Tổng giá trị hóa đơn'
	FROM CT_HOADON ct, HOADON hd, SANPHAM sp
	WHERE ct.MAHD = hd.MAHD AND ct.MASP = sp.MASP AND TRANGTHAI = N'Đã xuất hóa đơn'
	GROUP BY ct.MAHD
END
EXEC sp_ThongKe 
GO
--Thống kê hóa đơn theo tháng
Alter PROC sp_ThongKeTheoThang
AS
BEGIN
	SELECT MONTH(NGAYLAP) AS 'Thang', YEAR(NGAYLAP) AS 'Nam', SUM(sp.DONGIA * ct.SOLUONG) as N'Tổng giá trị hóa đơn'
	FROM CT_HOADON ct, HOADON hd, SANPHAM sp
	WHERE ct.MAHD = hd.MAHD AND ct.MASP = sp.MASP AND TRANGTHAI = N'Đã xuất hóa đơn'
	GROUP BY MONTH(NGAYLAP), YEAR(NGAYLAP)
END
EXEC sp_ThongKeTheoThang
GO
--Theo ngày
CREATE PROC sp_ThongKeTheoNgay
AS
BEGIN
	SELECT DAY(NGAYLAP) AS N'Ngày lập', YEAR(NGAYLAP) AS N'Năm', SUM(sp.DONGIA * ct.SOLUONG) as N'Tổng giá trị hóa đơn'
	FROM CT_HOADON ct, HOADON hd, SANPHAM sp
	WHERE ct.MAHD = hd.MAHD AND ct.MASP = sp.MASP AND TRANGTHAI = N'Đã xuất hóa đơn'
	GROUP BY DAY(NGAYLAP), YEAR(NGAYLAP)
END
EXEC sp_ThongKeTheoNgay
GO
--Summary: Proc này dùng để tính sản phẩm được mua nhiều nhất (Mới)
CREATE PROC sp_SoSP
AS
BEGIN
	SELECT ct.MASP, TENSP, MONTH(NGAYLAP) as 'NGAYLAP', SUM(SOLUONG) AS 'SOLUONG' FROM CT_HOADON ct, SANPHAM sp, HOADON hd
	WHERE ct.MASP = sp.MASP AND hd.MAHD = ct.MAHD
	GROUP BY ct.MASP, TENSP, MONTH(NGAYLAP)
END
GO
--Lấy hóa đơn chưa xuất
CREATE PROC sp_HD_ChuaXuat
AS
BEGIN
	SELECT * FROM HOADON WHERE TRANGTHAI = N'Chưa xuất' AND CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)
END
GO

--Khi mua hàng giảm số lượng trong kho
CREATE PROC sp_GiamKho
AS
BEGIN
	SELECT * FROM PHIEUNHAP
END
GO
CREATE PROCEDURE drop_User 
    @MANV CHAR(10)
AS
BEGIN
    DECLARE @sql NVARCHAR(1000);
    SET @sql = 'DROP LOGIN [' + @MANV + ']';
    EXEC sp_executesql @sql;
    SET @sql = 'DROP USER [' + @MANV + ']';
    EXEC sp_executesql @sql;
END;
GO
--ALTER SERVER ROLE sysadmin ADD MEMBER NV001;

--CREATE ROLE NHANVIEN;
--GRANT SELECT  ON NHANVIEN TO NHANVIEN
--GRANT SELECT, INSERT, UPDATE ON HOADON TO NHANVIEN
--GRANT SELECT, INSERT, 
--CREATE ROLE QUANLY
--ALTER ROLE db_owner ADD MEMBER QUANLY;
--===============================================Mới===============================================
CREATE TABLE KHO
(
	MASP	NCHAR(10),
	NGAYSX DATE,
	SLTON	INT,
	NGAYHH DATE,
	PRIMARY KEY (MASP, NGAYSX),
	FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
)
go
ALTER PROC sp_Join_CTPN @MAPN char(10)
AS
BEGIN
	SELECT * FROM CTPHIEUNHAP ct, PHIEUNHAP p, SANPHAM sp
	WHERE ct.MAPN = p.MAPN AND ct.MASP = sp.MASP AND ct.MAPN = @MAPN
END
GO
CREATE TRIGGER tg_Update_SL
ON CT_HOADON
AFTER UPDATE
AS
BEGIN
	UPDATE KHO
    SET SLTON = k.SLTON - i.SOLUONG
    FROM KHO k, inserted i, HOADON hd
    WHERE k.MASP = i.MASP AND  hd.TRANGTHAI = N'Đã xuất hóa đơn';
END
GO
ALTER TRIGGER tg_Update_Kho
ON PHIEUNHAP
AFTER UPDATE
AS
BEGIN
	DECLARE @MASP NCHAR(10), @NGAYSX DATE, @NGAYHH DATE, @SLNHAP INT;
    DECLARE cur CURSOR FOR 
    SELECT ct.MASP, ct.NGAYSX, ct.NGAYHH, ct.SLNHAP
    FROM inserted i, CTPHIEUNHAP ct
    WHERE i.TRANGTHAI = N'Đã duyệt' AND i.MAPN = ct.MAPN;
    OPEN cur;
    FETCH NEXT FROM cur INTO @MASP, @NGAYSX, @NGAYHH, @SLNHAP;

    WHILE @@FETCH_STATUS = 0
    BEGIN
		SET NOCOUNT ON
        -- Kiểm tra nếu sản phẩm đã tồn tại trong kho
        IF EXISTS (SELECT 1 FROM KHO WHERE MASP = @MASP AND NGAYSX = @NGAYSX)
        BEGIN
            -- Cập nhật SLTON nếu sản phẩm đã tồn tại
            UPDATE KHO
            SET SLTON = SLTON + @SLNHAP
            WHERE MASP = @MASP AND NGAYSX = @NGAYSX AND NGAYHH = @NGAYHH;
        END
        ELSE
        BEGIN
            -- Chèn sản phẩm mới vào kho nếu chưa tồn tại
            INSERT INTO KHO (MASP, NGAYSX, NGAYHH, SLTON)
            VALUES (@MASP, @NGAYSX, @NGAYHH, @SLNHAP);
        END;

        FETCH NEXT FROM cur INTO @MASP, @NGAYSX, @NGAYHH, @SLNHAP;
    END;

    CLOSE cur;
    DEALLOCATE cur;

    PRINT N'Nhập kho thành công';
END;
GO
ALTER PROC sp_LamSachPhieu
AS
BEGIN
	DECLARE @MAPN NCHAR(10);
	DECLARE @COUNT INT;
	SET @COUNT = (SELECT COUNT(*) FROM PHIEUNHAP pn
									WHERE NOT EXISTS (
									SELECT 1
									FROM CTPHIEUNHAP ctpn
									WHERE pn.MAPN = ctpn.MAPN));

	DECLARE cur CURSOR FOR 
	SELECT MAPN
	FROM PHIEUNHAP pn
	WHERE NOT EXISTS (
		SELECT 1
		FROM CTPHIEUNHAP ctpn
		WHERE pn.MAPN = ctpn.MAPN
	)
	open cur 
	FETCH NEXT FROM cur INTO @MAPN
	WHILE @@FETCH_STATUS = 0
    BEGIN
		DELETE FROM PHIEUNHAP WHERE MAPN = @MAPN;
		FETCH NEXT FROM cur INTO @MAPN;
	END;
	CLOSE cur;
    DEALLOCATE cur;
    PRINT N'Lọc thành công: ' + cast(@COUNT AS NVARCHAR);
END;
GO
--====================================Mới====================================
ALTER TRIGGER tg_GopCTPN
ON CTPHIEUNHAP
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @MAPN NCHAR(10), 
			@MASP NCHAR(10), 
			@SL INT, 
			@GIANHAP INT, 
			@NGAYSX DATE,
			@NGAYHH DATE,
			@DVT NVARCHAR(20);
	DECLARE cur CURSOR FOR 
	SELECT MAPN, MASP, SLNHAP, GIANHAP,NGAYSX, NGAYHH, DVT FROM inserted
	OPEN cur;
	FETCH NEXT FROM cur INTO @MAPN, @MASP, @SL, @GIANHAP, @NGAYSX, @NGAYHH, @DVT
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS(SELECT 1
				  FROM CTPHIEUNHAP
				  WHERE MAPN = @MAPN AND MASP = @MASP)
			BEGIN
				UPDATE CTPHIEUNHAP 
				SET SLNHAP = SLNHAP + @SL
				WHERE MAPN = @MAPN AND MASP = @MASP;
				PRINT N'Cập nhật thành công';
			END;
			ELSE
				BEGIN
					INSERT INTO CTPHIEUNHAP(MAPN, MASP, SLNHAP, GIANHAP,NGAYSX, NGAYHH, DVT) 
					VALUES (@MAPN, @MASP, @SL, @GIANHAP, @NGAYSX, @NGAYHH, @DVT)
				END
			FETCH NEXT FROM cur INTO @MAPN, @MASP, @SL, @GIANHAP, @NGAYSX, @NGAYHH, @DVT;
	END
	CLOSE cur;
    DEALLOCATE cur;
END;

GO
CREATE PROC sp_GomKho
AS
BEGIN
	DECLARE @MASP NCHAR(10);
	DECLARE cur CURSOR FOR
	SELECT MASP FROM KHO
	OPEN cur;
	FETCH NEXT FROM cur INTO @MASP
	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		FETCH NEXT FROM cur INTO @MASP;
	END;
	CLOSE cur;
    DEALLOCATE cur;

END;
GO
CREATE PROC sp_HoaDon_DoanhThu @NGAYLAP DATE
AS
BEGIN
	SELECT hd.MAHD AS N'Mã hóa đơn', NGAYLAP as N'Ngày lập', MAKH AS N'Mã khách hàng', COUNT(sp.MASP) AS N'Số sản phẩm', SUM(SOLUONG * DONGIA) AS N'Thành tiền' 
	FROM HOADON hd, CT_HOADON ct, SANPHAM sp
	WHERE hd.MAHD = ct.MAHD 
	AND ct.MASP = sp.MASP 
	AND TRANGTHAI = N'Đã xuất hóa đơn'
	AND CAST(NGAYLAP AS DATE) = @NGAYLAP
	GROUP BY hd.MAHD, NGAYLAP, MAKH
END
go
CREATE PROC sp_DoanhThu
AS
BEGIN
	SELECT hd.MAHD AS N'Mã hóa đơn', NGAYLAP as N'Ngày lập', MAKH AS N'Mã khách hàng', COUNT(sp.MASP) AS N'Số sản phẩm', SUM(SOLUONG * DONGIA) AS N'Thành tiền' 
	FROM HOADON hd, CT_HOADON ct, SANPHAM sp
	WHERE hd.MAHD = ct.MAHD 
	AND ct.MASP = sp.MASP 
	AND TRANGTHAI = N'Đã xuất hóa đơn'
	GROUP BY hd.MAHD, NGAYLAP, MAKH
END
go
CREATE VIEW Tong_DoanhThu
as
	SELECT hd.MAHD AS N'Mã hóa đơn', NGAYLAP as N'Ngày lập', MAKH AS N'Mã khách hàng', COUNT(sp.MASP) AS N'Số sản phẩm', SUM(SOLUONG * DONGIA) AS N'Thành tiền' 
	FROM HOADON hd, CT_HOADON ct, SANPHAM sp
	WHERE hd.MAHD = ct.MAHD 
	AND ct.MASP = sp.MASP 
	AND TRANGTHAI = N'Đã xuất hóa đơn'
	GROUP BY hd.MAHD, NGAYLAP, MAKH
GO
CREATE PROC sp_ThanhTienTheoNgay @NL DATE
AS
BEGIN
	SELECT CAST([Ngày lập] AS DATE) as N'NGAY', SUM([Thành tiền]) AS 'TT' 
	FROM Tong_DoanhThu 
	WHERE CAST([Ngày lập] AS DATE) = @NL 
	GROUP BY CAST([Ngày lập] AS DATE)
END
GO
CREATE PROC sp_LocHD
AS
BEGIN
	DECLARE @MAHD NCHAR(10);
	DECLARE cs CURSOR FOR
	SELECT MAHD FROM HOADON h
	WHERE NOT EXISTS (SELECT 1 FROM CT_HOADON ct WHERE ct.MAHD = h.MAHD)
	OPEN cs;
	FETCH NEXT FROM cs INTO @MAHD
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DELETE FROM HOADON WHERE MAHD = @MAHD
		Print 'Đã xóa hóa đơn: ' + @MAHD
		FETCH NEXT FROM cs INTO @MAHD
	END
	CLOSE cs;
    DEALLOCATE cs;
END
GO
