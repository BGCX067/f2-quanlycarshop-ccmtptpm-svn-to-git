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
