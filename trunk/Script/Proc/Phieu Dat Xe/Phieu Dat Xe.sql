if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Insert]
(
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_DAT datetime,
	@NGAY_HEN_LAY smalldatetime,
	@TONG_TIEN money,
	@TIEN_TRA_TRUOC money
)

AS
BEGIN
	INSERT INTO [PHIEU_DAT_XE]
	(
		[MA_KHACH_HANG],
		[MA_NHAN_VIEN],
		[NGAY_DAT],
		[NGAY_HEN_LAY],
		[TONG_TIEN],
		[TIEN_TRA_TRUOC]
	)
	VALUES
	(
	@MA_KHACH_HANG,
	@MA_NHAN_VIEN,
	@NGAY_DAT,
	@NGAY_HEN_LAY,
	@TONG_TIEN,
	@TIEN_TRA_TRUOC
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_Update]
(
	@MA int,
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_DAT datetime,
	@NGAY_HEN_LAY smalldatetime,
	@TONG_TIEN money,
	@TIEN_TRA_TRUOC money
)

AS

BEGIN

	UPDATE [PHIEU_DAT_XE]
	SET 
		[MA_KHACH_HANG] = @MA_KHACH_HANG, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[NGAY_DAT] = @NGAY_DAT, 
		[NGAY_HEN_LAY] = @NGAY_HEN_LAY, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TIEN_TRA_TRUOC] = @TIEN_TRA_TRUOC
	WHERE [MA] = @MA
END
GO
