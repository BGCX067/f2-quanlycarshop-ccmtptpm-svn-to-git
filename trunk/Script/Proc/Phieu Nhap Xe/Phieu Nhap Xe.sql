if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_SelectAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Insert]
(
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [PHIEU_NHAP_XE]
	(
		[MA_DON_DAT_HANG],
		[NGAY_NHAP],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@MA_DON_DAT_HANG,
	@NGAY_NHAP,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_DeleteAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS

BEGIN

	DELETE FROM [PHIEU_NHAP_XE]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_NHAP_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Update]
(
	@MA int,
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_NHAP_XE]
	SET 
		[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG, 
		[NGAY_NHAP] = @NGAY_NHAP, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO
