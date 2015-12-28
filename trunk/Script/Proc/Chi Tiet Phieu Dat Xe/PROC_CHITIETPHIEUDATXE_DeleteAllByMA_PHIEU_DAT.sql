if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_PHIEU_DAT]
(
	@MA_PHIEU_DAT int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_PHIEU_DAT] = @MA_PHIEU_DAT
END
GO
