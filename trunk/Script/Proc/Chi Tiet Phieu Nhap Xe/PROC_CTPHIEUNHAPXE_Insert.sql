if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_Insert]
(
	@MA_PHIEU_NHAP_XE int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [CT_PHIEU_NHAP_XE]
	(
		[MA_PHIEU_NHAP_XE],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_PHIEU_NHAP_XE,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO
