if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Select]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Insert]
(
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_LAP datetime,
	@KIEU_THANH_TOAN bit,
	@TONG_TIEN money,
	@TIEN_TRA_MOI_DOT money,
	@SO_LAN_TRA int
)

AS
BEGIN
	INSERT INTO [HOA_DON]
	(
		[MA_KHACH_HANG],
		[MA_NHAN_VIEN],
		[NGAY_LAP],
		[KIEU_THANH_TOAN],
		[TONG_TIEN],
		[TIEN_TRA_MOI_DOT],
		[SO_LAN_TRA]
	)
	VALUES
	(
	@MA_KHACH_HANG,
	@MA_NHAN_VIEN,
	@NGAY_LAP,
	@KIEU_THANH_TOAN,
	@TONG_TIEN,
	@TIEN_TRA_MOI_DOT,
	@SO_LAN_TRA
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Update]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Update]
(
	@MA int,
	@MA_KHACH_HANG int,
	@MA_NHAN_VIEN int,
	@NGAY_LAP datetime,
	@KIEU_THANH_TOAN bit,
	@TONG_TIEN money,
	@TIEN_TRA_MOI_DOT money,
	@SO_LAN_TRA int
)

AS

BEGIN

	UPDATE [HOA_DON]
	SET 
		[MA_KHACH_HANG] = @MA_KHACH_HANG, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[NGAY_LAP] = @NGAY_LAP, 
		[KIEU_THANH_TOAN] = @KIEU_THANH_TOAN, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TIEN_TRA_MOI_DOT] = @TIEN_TRA_MOI_DOT, 
		[SO_LAN_TRA] = @SO_LAN_TRA
	WHERE [MA] = @MA
END
GO