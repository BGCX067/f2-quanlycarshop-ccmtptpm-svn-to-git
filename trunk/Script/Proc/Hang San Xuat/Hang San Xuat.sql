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
