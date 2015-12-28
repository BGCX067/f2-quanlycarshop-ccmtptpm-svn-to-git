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
