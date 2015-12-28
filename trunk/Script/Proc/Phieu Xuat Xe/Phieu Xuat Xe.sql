if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Insert]
(
	@NGAY_XUAT datetime,
	@MA_NHAN_VIEN int,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [PHIEU_XUAT_XE]
	(
		[NGAY_XUAT],
		[MA_NHAN_VIEN],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@NGAY_XUAT,
	@MA_NHAN_VIEN,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [PHIEU_XUAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_XUAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Update]
(
	@MA int,
	@NGAY_XUAT datetime,
	@MA_NHAN_VIEN int,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_XUAT_XE]
	SET 
		[NGAY_XUAT] = @NGAY_XUAT, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
END
GO
