if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUXUATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUXUATXE_Insert]
(
	@MA_PHIEU_XUAT_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_XUAT_XE]
	(
		[MA_PHIEU_XUAT_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_XUAT_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO
