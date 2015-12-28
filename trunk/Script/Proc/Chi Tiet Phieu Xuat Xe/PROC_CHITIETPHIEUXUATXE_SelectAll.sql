if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
END
GO
