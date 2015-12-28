if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Update]
(
	@MA int,
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_DAT_XE]
	SET 
		[MA_PHIEU_DAT] = @MA_PHIEU_DAT, 
		[MA_XE] = @MA_XE, 
		[MA_MAU] = @MA_MAU, 
		[SO_LUONG] = @SO_LUONG, 
		[TONG_TIEN] = @TONG_TIEN
	WHERE [MA] = @MA
END
GO
