if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Select]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_PHIEU_XUAT_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CHI_TIET_PHIEU_XUAT_XE]
	WHERE	[MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
