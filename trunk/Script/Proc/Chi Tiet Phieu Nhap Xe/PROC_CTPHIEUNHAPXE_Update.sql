if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Update]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CT_PHIEU_NHAP_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
