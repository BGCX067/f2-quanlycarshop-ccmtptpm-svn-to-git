if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Update]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS

BEGIN

	UPDATE [CHI_TIET_PHIEU_XUAT_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_PHIEU_XUAT_XE] = @MA_PHIEU_XUAT_XE	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
