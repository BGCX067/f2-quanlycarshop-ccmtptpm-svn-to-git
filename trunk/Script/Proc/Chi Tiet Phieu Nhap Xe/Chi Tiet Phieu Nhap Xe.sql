if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Update]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CT_PHIEU_NHAP_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_XE]
(
	@MA_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_PHIEU_NHAP_XE]
(
	@MA_PHIEU_NHAP_XE int
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Select]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Insert]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CT_PHIEU_NHAP_XE]
	(
		[MA_PHIEU_NHAP_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_NHAP_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
(
	@MA_PHIEU_NHAP_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Delete]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
