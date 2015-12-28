if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Update]
(
	@MA int,
	@NGAY_DAT smalldatetime,
	@TONG_TIEN money,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [DON_DAT_HANG]
	SET 
		[NGAY_DAT] = @NGAY_DAT, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO
