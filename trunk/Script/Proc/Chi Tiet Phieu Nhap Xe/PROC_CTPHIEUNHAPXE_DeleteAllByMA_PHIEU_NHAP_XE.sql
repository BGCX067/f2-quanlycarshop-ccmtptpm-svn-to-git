if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_PHIEU_NHAP_XE]
(
	@MA_PHIEU_NHAP_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE
END
GO
