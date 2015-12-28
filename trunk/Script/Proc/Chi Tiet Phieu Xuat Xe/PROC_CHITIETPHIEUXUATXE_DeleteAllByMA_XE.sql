if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO
