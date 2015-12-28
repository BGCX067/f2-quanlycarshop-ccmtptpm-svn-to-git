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
