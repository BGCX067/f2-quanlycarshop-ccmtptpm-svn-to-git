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
