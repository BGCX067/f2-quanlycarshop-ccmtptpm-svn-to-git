if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Update]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS

BEGIN

	UPDATE [CT_DON_DAT_HANG]
	SET 
		[SO_LUONG] = @SO_LUONG, 
		[TONG_TIEN] = @TONG_TIEN
	WHERE [MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
