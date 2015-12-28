if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Update]
(
	@MA int,
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_NHAP_XE]
	SET 
		[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG, 
		[NGAY_NHAP] = @NGAY_NHAP, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO
