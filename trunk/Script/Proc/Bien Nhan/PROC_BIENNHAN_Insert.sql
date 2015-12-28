if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Insert]
(
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS
BEGIN
	INSERT INTO [BIEN_NHAN]
	(
		[MA_HOA_DON],
		[NGAY_THANH_TOAN],
		[MA_NHAN_VIEN],
		[SO_TIEN]
	)
	VALUES
	(
	@MA_HOA_DON,
	@NGAY_THANH_TOAN,
	@MA_NHAN_VIEN,
	@SO_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO
