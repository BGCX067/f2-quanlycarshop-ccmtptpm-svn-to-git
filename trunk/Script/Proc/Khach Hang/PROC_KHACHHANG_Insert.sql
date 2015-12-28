if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Insert]
(
	@HO_TEN nvarchar(40),
	@PHAI bit,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(10),
	@CMND char(9),
	@LOAI_KHACH_HANG bit
)

AS
BEGIN
	INSERT INTO [KHACH_HANG]
	(
		[HO_TEN],
		[PHAI],
		[DIA_CHI],
		[DIEN_THOAI],
		[CMND],
		[LOAI_KHACH_HANG]
	)
	VALUES
	(
	@HO_TEN,
	@PHAI,
	@DIA_CHI,
	@DIEN_THOAI,
	@CMND,
	@LOAI_KHACH_HANG
	)

	SELECT SCOPE_IDENTITY()
END
GO
