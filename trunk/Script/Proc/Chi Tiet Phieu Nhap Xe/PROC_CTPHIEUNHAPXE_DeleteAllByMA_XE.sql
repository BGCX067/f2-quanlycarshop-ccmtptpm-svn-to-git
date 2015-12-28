if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO
