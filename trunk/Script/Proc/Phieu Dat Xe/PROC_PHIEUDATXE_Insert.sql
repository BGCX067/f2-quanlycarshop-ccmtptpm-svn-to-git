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
