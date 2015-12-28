if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Insert]
(
	@HO_TEN nvarchar(30),
	@MA_LOAI_NHAN_VIEN int,
	@USERNAME nvarchar(256),
	@USER_PASSWORD nvarchar(256),
	@PHAI bit,
	@NGAY_SINH smalldatetime,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(11),
	@CMND char(9)
)

AS
BEGIN
	INSERT INTO [NHAN_VIEN]
	(
		[HO_TEN],
		[MA_LOAI_NHAN_VIEN],
		[USERNAME],
		[USER_PASSWORD],
		[PHAI],
		[NGAY_SINH],
		[DIA_CHI],
		[DIEN_THOAI],
		[CMND]
	)
	VALUES
	(
	@HO_TEN,
	@MA_LOAI_NHAN_VIEN,
	@USERNAME,
	@USER_PASSWORD,
	@PHAI,
	@NGAY_SINH,
	@DIA_CHI,
	@DIEN_THOAI,
	@CMND
	)

	SELECT SCOPE_IDENTITY()
END
GO
