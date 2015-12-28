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