if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Update]
(
	@MA int,
	@MA_HOA_DON int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@THANH_TIEN money
)

AS

BEGIN

	UPDATE [CHI_TIET_HOA_DON]
	SET 
		[MA_HOA_DON] = @MA_HOA_DON, 
		[MA_XE] = @MA_XE, 
		[MA_MAU] = @MA_MAU, 
		[SO_LUONG] = @SO_LUONG, 
		[THANH_TIEN] = @THANH_TIEN
	WHERE [MA] = @MA
END
GO
