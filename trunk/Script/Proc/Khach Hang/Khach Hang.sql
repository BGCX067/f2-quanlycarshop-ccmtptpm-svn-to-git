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
