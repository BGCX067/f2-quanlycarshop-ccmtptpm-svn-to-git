if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_DeleteAllByMA_PHIEU_XUAT_XE]
(
	@MA_PHIEU_XUAT_XE int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE
END
GO
