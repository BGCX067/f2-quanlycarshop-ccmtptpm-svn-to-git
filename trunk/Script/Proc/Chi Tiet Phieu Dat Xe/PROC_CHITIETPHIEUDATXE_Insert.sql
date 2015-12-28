if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Insert]
(
	@MA_PHIEU_DAT int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS
BEGIN
	INSERT INTO [CHI_TIET_PHIEU_DAT_XE]
	(
		[MA_PHIEU_DAT],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[TONG_TIEN]
	)
	VALUES
	(
	@MA_PHIEU_DAT,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@TONG_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO
