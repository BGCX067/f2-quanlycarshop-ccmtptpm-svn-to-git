if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Delete]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_PHIEU_NHAP_XE]
	WHERE	[MA_PHIEU_NHAP_XE] = @MA_PHIEU_NHAP_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
