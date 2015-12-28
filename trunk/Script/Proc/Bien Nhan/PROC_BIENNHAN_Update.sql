if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Update]
(
	@MA int,
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS

BEGIN

	UPDATE [BIEN_NHAN]
	SET 
		[MA_HOA_DON] = @MA_HOA_DON, 
		[NGAY_THANH_TOAN] = @NGAY_THANH_TOAN, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[SO_TIEN] = @SO_TIEN
	WHERE [MA] = @MA
END
GO
