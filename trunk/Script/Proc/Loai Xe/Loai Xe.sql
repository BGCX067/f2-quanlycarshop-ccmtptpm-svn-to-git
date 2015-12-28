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
