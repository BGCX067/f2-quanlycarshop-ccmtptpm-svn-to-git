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
