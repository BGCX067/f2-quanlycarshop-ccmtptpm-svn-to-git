if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Insert]
(
	@NGAY_XUAT datetime,
	@MA_NHAN_VIEN int,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [PHIEU_XUAT_XE]
	(
		[NGAY_XUAT],
		[MA_NHAN_VIEN],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@NGAY_XUAT,
	@MA_NHAN_VIEN,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [PHIEU_XUAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_XUAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Update]
(
	@MA int,
	@NGAY_XUAT datetime,
	@MA_NHAN_VIEN int,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_XUAT_XE]
	SET 
		[NGAY_XUAT] = @NGAY_XUAT, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Insert]
(
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [PHIEU_NHAP_XE]
	(
		[MA_DON_DAT_HANG],
		[NGAY_NHAP],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@MA_DON_DAT_HANG,
	@NGAY_NHAP,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS

BEGIN

	DELETE FROM [PHIEU_NHAP_XE]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_NHAP_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Update]
(
	@MA int,
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_NHAP_XE]
	SET 
		[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG, 
		[NGAY_NHAP] = @NGAY_NHAP, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Insert]
(
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_DAT datetime,
	@NGAY_HEN_LAY smalldatetime,
	@TONG_TIEN money,
	@TIEN_TRA_TRUOC money
)

AS
BEGIN
	INSERT INTO [PHIEU_DAT_XE]
	(
		[MA_KHACH_HANG],
		[MA_NHAN_VIEN],
		[NGAY_DAT],
		[NGAY_HEN_LAY],
		[TONG_TIEN],
		[TIEN_TRA_TRUOC]
	)
	VALUES
	(
	@MA_KHACH_HANG,
	@MA_NHAN_VIEN,
	@NGAY_DAT,
	@NGAY_HEN_LAY,
	@TONG_TIEN,
	@TIEN_TRA_TRUOC
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Update]
(
	@MA int,
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_DAT datetime,
	@NGAY_HEN_LAY smalldatetime,
	@TONG_TIEN money,
	@TIEN_TRA_TRUOC money
)

AS

BEGIN

	UPDATE [PHIEU_DAT_XE]
	SET 
		[MA_KHACH_HANG] = @MA_KHACH_HANG, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[NGAY_DAT] = @NGAY_DAT, 
		[NGAY_HEN_LAY] = @NGAY_HEN_LAY, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TIEN_TRA_TRUOC] = @TIEN_TRA_TRUOC
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_SelectByUserNamePassword]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_SelectByUserNamePassword]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_SelectByUserNamePassword]
(
	@USERNAME NVARCHAR(256),
	@PASSWORD NVARCHAR(256)
)

AS
BEGIN

	SELECT [NHAN_VIEN].[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM [NHAN_VIEN], LOAI_NHAN_VIEN
	WHERE	USERNAME = @USERNAME AND USER_PASSWORD = @PASSWORD AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]
(
	@MA_HOA_DON int
)

AS
BEGIN

	SELECT NV.[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM NHAN_VIEN NV, HOA_DON HD, LOAI_NHAN_VIEN
	WHERE NV.MA = HD.MA_NHAN_VIEN AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_SelectAllByMA_LOAI_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_SelectAllByMA_LOAI_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_SelectAllByMA_LOAI_NHAN_VIEN]
(
	@MA_LOAI_NHAN_VIEN int
)

AS
BEGIN

	SELECT [NHAN_VIEN].[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM [NHAN_VIEN], LOAI_NHAN_VIEN
	WHERE	[MA_LOAI_NHAN_VIEN] = @MA_LOAI_NHAN_VIEN AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_SelectAll]

AS
BEGIN

	SELECT [NHAN_VIEN].[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM [NHAN_VIEN], LOAI_NHAN_VIEN
	WHERE	MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [NHAN_VIEN].[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM [NHAN_VIEN], LOAI_NHAN_VIEN
	WHERE	NHAN_VIEN.[MA] = @MA AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Insert]
(
	@HO_TEN nvarchar(30),
	@MA_LOAI_NHAN_VIEN int,
	@USERNAME nvarchar(256),
	@USER_PASSWORD nvarchar(256),
	@PHAI bit,
	@NGAY_SINH smalldatetime,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(11),
	@CMND char(9)
)

AS
BEGIN
	INSERT INTO [NHAN_VIEN]
	(
		[HO_TEN],
		[MA_LOAI_NHAN_VIEN],
		[USERNAME],
		[USER_PASSWORD],
		[PHAI],
		[NGAY_SINH],
		[DIA_CHI],
		[DIEN_THOAI],
		[CMND]
	)
	VALUES
	(
	@HO_TEN,
	@MA_LOAI_NHAN_VIEN,
	@USERNAME,
	@USER_PASSWORD,
	@PHAI,
	@NGAY_SINH,
	@DIA_CHI,
	@DIEN_THOAI,
	@CMND
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]
(
	@MA_LOAI_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [NHAN_VIEN]
	WHERE	[MA_LOAI_NHAN_VIEN] = @MA_LOAI_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Update]
(
	@MA int,
	@HO_TEN nvarchar(30),
	@MA_LOAI_NHAN_VIEN int,
	@PHAI bit,
	@NGAY_SINH smalldatetime,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(11),
	@CMND char(9)
)

AS

BEGIN

	UPDATE [NHAN_VIEN]
	SET 
		[HO_TEN] = @HO_TEN, 
		[MA_LOAI_NHAN_VIEN] = @MA_LOAI_NHAN_VIEN, 
		[PHAI] = @PHAI, 
		[NGAY_SINH] = @NGAY_SINH, 
		[DIA_CHI] = @DIA_CHI, 
		[DIEN_THOAI] = @DIEN_THOAI, 
		[CMND] = @CMND
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE	[MA_XE] = @MA_XE AND MAU.MA = MAU_XE.MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE	[MA_MAU] = @MA_MAU AND MAU.MA = MAU_XE.MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_SelectAll]

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE  MAU.MA = MAU_XE.MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Select]
(
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE	[MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU  AND MAU.MA = MAU_XE.MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Insert]
(
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [MAU_XE]
	(
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Delete]
(
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Update]
(
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG money
)

AS

BEGIN

	UPDATE [MAU_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO


if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_LOAI_XE], [GHI_CHU]
	FROM [LOAI_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Insert]
(
	@TEN_LOAI_XE nvarchar(30),
	@GHI_CHU nvarchar(200)
)

AS
BEGIN
	INSERT INTO [LOAI_XE]
	(
		[TEN_LOAI_XE],
		[GHI_CHU]
	)
	VALUES
	(
	@TEN_LOAI_XE,
	@GHI_CHU
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [LOAI_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Update]
(
	@MA int,
	@TEN_LOAI_XE nvarchar(30),
	@GHI_CHU nvarchar(200)
)

AS

BEGIN

	UPDATE [LOAI_XE]
	SET 
		[TEN_LOAI_XE] = @TEN_LOAI_XE, 
		[GHI_CHU] = @GHI_CHU
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_SelectAll]

AS
BEGIN

	SELECT [MA], [TEN_LOAI_XE], [GHI_CHU]
	FROM [LOAI_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Insert]
(
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS
BEGIN
	INSERT INTO [LOAI_NHAN_VIEN]
	(
		[TEN_LOAI_NHAN_VIEN]
	)
	VALUES
	(
	@TEN_LOAI_NHAN_VIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Update]
(
	@MA int,
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS

BEGIN

	UPDATE [LOAI_NHAN_VIEN]
	SET 
		[TEN_LOAI_NHAN_VIEN] = @TEN_LOAI_NHAN_VIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_SelectAll]

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_SelectAllByMA_LOAI_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_SelectAllByMA_LOAI_XE]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_SelectAllByMA_LOAI_XE]
(
	@MA_LOAI_XE int
)

AS
BEGIN

	SELECT [MA], [MA_LOAI_XE], [TEN_KIEU_XE]
	FROM [KIEU_XE]
	WHERE	[MA_LOAI_XE] = @MA_LOAI_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_LOAI_XE], [TEN_KIEU_XE]
	FROM [KIEU_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_LOAI_XE], [TEN_KIEU_XE]
	FROM [KIEU_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Insert]
(
	@MA_LOAI_XE int,
	@TEN_KIEU_XE nvarchar(30)
)

AS
BEGIN
	INSERT INTO [KIEU_XE]
	(
		[MA_LOAI_XE],
		[TEN_KIEU_XE]
	)
	VALUES
	(
	@MA_LOAI_XE,
	@TEN_KIEU_XE
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]
(
	@MA_LOAI_XE int
)

AS

BEGIN

	DELETE FROM [KIEU_XE]
	WHERE	[MA_LOAI_XE] = @MA_LOAI_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [KIEU_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Update]
(
	@MA int,
	@MA_LOAI_XE int,
	@TEN_KIEU_XE nvarchar(30)
)

AS

BEGIN

	UPDATE [KIEU_XE]
	SET 
		[MA_LOAI_XE] = @MA_LOAI_XE, 
		[TEN_KIEU_XE] = @TEN_KIEU_XE
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_SelectByThongTin]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_SelectByThongTin]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_SelectByThongTin]
(
	@HO_TEN NVARCHAR(40),
	@DIA_CHI NVARCHAR(50),
	@CMND CHAR(9)
)

AS
BEGIN
	IF @DIA_CHI = ''
		SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
		FROM [KHACH_HANG]
		WHERE	@HO_TEN = HO_TEN AND CMND = @CMND
	ELSE
		SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
		FROM [KHACH_HANG]
		WHERE	@HO_TEN = HO_TEN AND DIA_CHI = @DIA_CHI
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]
(
	@MA_HOA_DON INT
)

AS
BEGIN
	
	SELECT KH.MA, [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
	FROM KHACH_HANG KH, HOA_DON HD
	WHERE KH.MA = HD.MA_KHACH_HANG AND HD.MA = @MA_HOA_DON	
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_SelectAll]

AS
BEGIN

	SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
	FROM [KHACH_HANG]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
	FROM [KHACH_HANG]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Insert]
(
	@HO_TEN nvarchar(40),
	@PHAI bit,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(10),
	@CMND char(9),
	@LOAI_KHACH_HANG bit
)

AS
BEGIN
	INSERT INTO [KHACH_HANG]
	(
		[HO_TEN],
		[PHAI],
		[DIA_CHI],
		[DIEN_THOAI],
		[CMND],
		[LOAI_KHACH_HANG]
	)
	VALUES
	(
	@HO_TEN,
	@PHAI,
	@DIA_CHI,
	@DIEN_THOAI,
	@CMND,
	@LOAI_KHACH_HANG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [KHACH_HANG]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Update]
(
	@MA int,
	@HO_TEN nvarchar(40),
	@PHAI bit,
	@DIA_CHI nvarchar(50),
	@DIEN_THOAI char(10),
	@CMND char(9),
	@LOAI_KHACH_HANG bit
)

AS

BEGIN

	UPDATE [KHACH_HANG]
	SET 
		[HO_TEN] = @HO_TEN, 
		[PHAI] = @PHAI, 
		[DIA_CHI] = @DIA_CHI, 
		[DIEN_THOAI] = @DIEN_THOAI, 
		[CMND] = @CMND, 
		[LOAI_KHACH_HANG] = @LOAI_KHACH_HANG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Select]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Insert]
(
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_LAP datetime,
	@KIEU_THANH_TOAN bit,
	@TONG_TIEN money,
	@TIEN_TRA_MOI_DOT money,
	@SO_LAN_TRA int
)

AS
BEGIN
	INSERT INTO [HOA_DON]
	(
		[MA_KHACH_HANG],
		[MA_NHAN_VIEN],
		[NGAY_LAP],
		[KIEU_THANH_TOAN],
		[TONG_TIEN],
		[TIEN_TRA_MOI_DOT],
		[SO_LAN_TRA]
	)
	VALUES
	(
	@MA_KHACH_HANG,
	@MA_NHAN_VIEN,
	@NGAY_LAP,
	@KIEU_THANH_TOAN,
	@TONG_TIEN,
	@TIEN_TRA_MOI_DOT,
	@SO_LAN_TRA
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Update]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Update]
(
	@MA int,
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_LAP datetime,
	@KIEU_THANH_TOAN bit,
	@TONG_TIEN money,
	@TIEN_TRA_MOI_DOT money,
	@SO_LAN_TRA int
)

AS

BEGIN

	UPDATE [HOA_DON]
	SET 
		[MA_KHACH_HANG] = @MA_KHACH_HANG, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[NGAY_LAP] = @NGAY_LAP, 
		[KIEU_THANH_TOAN] = @KIEU_THANH_TOAN, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TIEN_TRA_MOI_DOT] = @TIEN_TRA_MOI_DOT, 
		[SO_LAN_TRA] = @SO_LAN_TRA
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Select]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_HANG_XE]
	FROM [HANG_SAN_XUAT]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Insert]
(
	@TEN_HANG_XE nvarchar(256)
)

AS
BEGIN
	INSERT INTO [HANG_SAN_XUAT]
	(
		[TEN_HANG_XE]
	)
	VALUES
	(
	@TEN_HANG_XE
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [HANG_SAN_XUAT]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Update]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Update]
(
	@MA int,
	@TEN_HANG_XE nvarchar(256)
)

AS

BEGIN

	UPDATE [HANG_SAN_XUAT]
	SET 
		[TEN_HANG_XE] = @TEN_HANG_XE
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_SelectAll]

AS
BEGIN

	SELECT [MA], [TEN_HANG_XE]
	FROM [HANG_SAN_XUAT]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [NGAY_DAT], [TONG_TIEN], [TONG_SO_LUONG]
	FROM [DON_DAT_HANG]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Insert]
(
	@NGAY_DAT smalldatetime,
	@TONG_TIEN money,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [DON_DAT_HANG]
	(
		[NGAY_DAT],
		[TONG_TIEN],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@NGAY_DAT,
	@TONG_TIEN,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [DON_DAT_HANG]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Update]
(
	@MA int,
	@NGAY_DAT smalldatetime,
	@TONG_TIEN money,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [DON_DAT_HANG]
	SET 
		[NGAY_DAT] = @NGAY_DAT, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_DAT], [TONG_TIEN], [TONG_SO_LUONG]
	FROM [DON_DAT_HANG]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]
(
	@MA_PHIEU_XUAT_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_XUAT_XE]
	(
		[MA_PHIEU_XUAT_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_XUAT_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
(
	@MA_PHIEU_XUAT_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Delete]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_XUAT_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Update]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CT_PHIEU_NHAP_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]
(
	@MA_PHIEU_NHAP_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Select]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Insert]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CT_PHIEU_NHAP_XE]
	(
		[MA_PHIEU_NHAP_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_NHAP_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
(
	@MA_PHIEU_NHAP_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Delete]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]
(
	@MA_PHIEU_DAT int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_PHIEU_DAT] = @MA_PHIEU_DAT
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
(
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_DAT_XE]
	(
		[MA_PHIEU_DAT],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[TONG_TIEN]
	)
	VALUES
	(
	@MA_PHIEU_DAT,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@TONG_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
(
	@MA_PHIEU_DAT int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_PHIEU_DAT] = @MA_PHIEU_DAT
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Update]
(
	@MA int,
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_DAT_XE]
	SET 
		[MA_PHIEU_DAT] = @MA_PHIEU_DAT, 
		[MA_XE] = @MA_XE, 
		[MA_MAU] = @MA_MAU, 
		[SO_LUONG] = @SO_LUONG, 
		[TONG_TIEN] = @TONG_TIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_SelectAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Insert]
(
	@MA_HOA_DON int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@THANH_TIEN money
)

AS
BEGIN
	INSERT INTO [CHI_TIET_HOA_DON]
	(
		[MA_HOA_DON],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[THANH_TIEN]
	)
	VALUES
	(
	@MA_HOA_DON,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@THANH_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Update]
(
	@MA int,
	@MA_HOA_DON int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@THANH_TIEN money
)

AS

BEGIN

	UPDATE [CHI_TIET_HOA_DON]
	SET 
		[MA_HOA_DON] = @MA_HOA_DON, 
		[MA_XE] = @MA_XE, 
		[MA_MAU] = @MA_MAU, 
		[SO_LUONG] = @SO_LUONG, 
		[THANH_TIEN] = @THANH_TIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Delete]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Update]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS

BEGIN

	UPDATE [CT_DON_DAT_HANG]
	SET 
		[SO_LUONG] = @SO_LUONG, 
		[TONG_TIEN] = @TONG_TIEN
	WHERE [MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAll]

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Select]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Insert]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS
BEGIN
	INSERT INTO [CT_DON_DAT_HANG]
	(
		[MA_DON_DAT_HANG],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[TONG_TIEN]
	)
	VALUES
	(
	@MA_DON_DAT_HANG,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@TONG_TIEN
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Update]
(
	@MA int,
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS

BEGIN

	UPDATE [BIEN_NHAN]
	SET 
		[MA_HOA_DON] = @MA_HOA_DON, 
		[NGAY_THANH_TOAN] = @NGAY_THANH_TOAN, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[SO_TIEN] = @SO_TIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Insert]
(
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS
BEGIN
	INSERT INTO [BIEN_NHAN]
	(
		[MA_HOA_DON],
		[NGAY_THANH_TOAN],
		[MA_NHAN_VIEN],
		[SO_TIEN]
	)
	VALUES
	(
	@MA_HOA_DON,
	@NGAY_THANH_TOAN,
	@MA_NHAN_VIEN,
	@SO_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_SelectAllByMA_KIEU_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_SelectAllByMA_KIEU_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_SelectAllByMA_KIEU_XE]
(
	@MA_KIEU_XE int
)

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE	[MA_KIEU_XE] = @MA_KIEU_XE AND XE.MA_HANG_XE = HANG_SAN_XUAT.MA AND XE.MA_KIEU_XE = KIEU_XE.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_SelectAllByMA_HANG_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_SelectAllByMA_HANG_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_SelectAllByMA_HANG_XE]
(
	@MA_HANG_XE int
)

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE	[MA_HANG_XE] = @MA_HANG_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_XE_SelectAll]

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE XE.MA_HANG_XE = HANG_SAN_XUAT.MA AND XE.MA_KIEU_XE = KIEU_XE.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE	XE.[MA] = @MA AND XE.MA_HANG_XE = HANG_SAN_XUAT.MA AND XE.MA_KIEU_XE = KIEU_XE.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Insert]
(
	@TEN_XE nvarchar(50),
	@MA_KIEU_XE int,
	@MA_HANG_XE int,
	@DOI_XE int,
	@CHI_SO_NHIEN_LIEU decimal(18, 0),
	@MAX_SPEED int,
	@LOAI_DIA_HINH nvarchar(100),
	@SO_CHO_NGOI int,
	@GIA_TIEN_BAN money,
	@GIA_TIEN_MUA money,
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [XE]
	(
		[TEN_XE],
		[MA_KIEU_XE],
		[MA_HANG_XE],
		[DOI_XE],
		[CHI_SO_NHIEN_LIEU],
		[MAX_SPEED],
		[LOAI_DIA_HINH],
		[SO_CHO_NGOI],
		[GIA_TIEN_BAN],
		[GIA_TIEN_MUA],
		[SO_LUONG]
	)
	VALUES
	(
	@TEN_XE,
	@MA_KIEU_XE,
	@MA_HANG_XE,
	@DOI_XE,
	@CHI_SO_NHIEN_LIEU,
	@MAX_SPEED,
	@LOAI_DIA_HINH,
	@SO_CHO_NGOI,
	@GIA_TIEN_BAN,
	@GIA_TIEN_MUA,
	@SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]
(
	@MA_KIEU_XE int
)

AS

BEGIN

	DELETE FROM [XE]
	WHERE	[MA_KIEU_XE] = @MA_KIEU_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_DeleteAllByMA_HANG_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_DeleteAllByMA_HANG_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_DeleteAllByMA_HANG_XE]
(
	@MA_HANG_XE int
)

AS

BEGIN

	DELETE FROM [XE]
	WHERE	[MA_HANG_XE] = @MA_HANG_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Update]
(
	@MA int,
	@TEN_XE nvarchar(50),
	@MA_KIEU_XE int,
	@MA_HANG_XE int,
	@DOI_XE int,
	@CHI_SO_NHIEN_LIEU decimal(18, 0),
	@MAX_SPEED int,
	@LOAI_DIA_HINH nvarchar(100),
	@SO_CHO_NGOI int,
	@GIA_TIEN_BAN money,
	@GIA_TIEN_MUA money,
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [XE]
	SET 
		[TEN_XE] = @TEN_XE, 
		[MA_KIEU_XE] = @MA_KIEU_XE, 
		[MA_HANG_XE] = @MA_HANG_XE, 
		[DOI_XE] = @DOI_XE, 
		[CHI_SO_NHIEN_LIEU] = @CHI_SO_NHIEN_LIEU, 
		[MAX_SPEED] = @MAX_SPEED, 
		[LOAI_DIA_HINH] = @LOAI_DIA_HINH, 
		[SO_CHO_NGOI] = @SO_CHO_NGOI, 
		[GIA_TIEN_BAN] = @GIA_TIEN_BAN, 
		[GIA_TIEN_MUA] = @GIA_TIEN_MUA, 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_SelectByTenXe]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_SelectByTenXe]
GO

CREATE PROCEDURE [dbo].[PROC_XE_SelectByTenXe]
(
	@TEN_XE NVARCHAR(50)
)

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE	@TEN_XE = TEN_XE AND XE.MA_HANG_XE = HANG_SAN_XUAT.MA AND XE.MA_KIEU_XE = KIEU_XE.MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Delete]
(
	@MA char(10)
)

AS

BEGIN

	DELETE FROM [MAU]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Update]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Update]
(
	@MA char(10),
	@MAU nvarchar(15)
)

AS

BEGIN

	UPDATE [MAU]
	SET 
		[MAU] = @MAU
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_SelectAll]

AS
BEGIN

	SELECT [MA], [MAU]
	FROM [MAU]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Select]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Select]
(
	@MA char(10)
)

AS
BEGIN

	SELECT [MA], [MAU]
	FROM [MAU]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Insert]
(
	@MA char(10),
	@MAU nvarchar(15)
)

AS
BEGIN
	INSERT INTO [MAU]
	(
		[MA],
		[MAU]
	)
	VALUES
	(
	@MA,
	@MAU
	)
END
GO
