if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Insert]
(
	@MA_DON_DAT_HANG int,
	@NGAY_NHAP smalldatetime,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [PHIEU_NHAP_XE]
	(
		[MA_DON_DAT_HANG],
		[NGAY_NHAP],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@MA_DON_DAT_HANG,
	@NGAY_NHAP,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO
