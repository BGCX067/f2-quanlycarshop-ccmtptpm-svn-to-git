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
