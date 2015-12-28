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
