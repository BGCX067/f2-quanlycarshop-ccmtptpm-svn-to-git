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
