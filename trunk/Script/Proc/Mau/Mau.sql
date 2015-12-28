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
