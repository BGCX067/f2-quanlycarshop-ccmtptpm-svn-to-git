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
