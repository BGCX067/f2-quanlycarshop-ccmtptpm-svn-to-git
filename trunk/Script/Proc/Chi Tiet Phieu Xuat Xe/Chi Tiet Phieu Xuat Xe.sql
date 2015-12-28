if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_PHIEU_XUAT_XE]
(
	@MA_PHIEU_XUAT_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_XUAT_XE]
	(
		[MA_PHIEU_XUAT_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_XUAT_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
(
	@MA_PHIEU_XUAT_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Delete]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_XUAT_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO
