if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_PHIEU_DAT]
(
	@MA_PHIEU_DAT int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_PHIEU_DAT] = @MA_PHIEU_DAT
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
(
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_DAT_XE]
	(
		[MA_PHIEU_DAT],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[TONG_TIEN]
	)
	VALUES
	(
	@MA_PHIEU_DAT,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@TONG_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
(
	@MA_PHIEU_DAT int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_PHIEU_DAT] = @MA_PHIEU_DAT
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Update]
(
	@MA int,
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_DAT_XE]
	SET 
		[MA_PHIEU_DAT] = @MA_PHIEU_DAT, 
		[MA_XE] = @MA_XE, 
		[MA_MAU] = @MA_MAU, 
		[SO_LUONG] = @SO_LUONG, 
		[TONG_TIEN] = @TONG_TIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA], [MA_PHIEU_DAT], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO
