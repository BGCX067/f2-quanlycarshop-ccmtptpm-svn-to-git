if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Insert]
(
	@TEN_XE nvarchar(50),
	@MA_KIEU_XE int,
	@MA_HANG_XE int,
	@DOI_XE int,
	@CHI_SO_NHIEN_LIEU decimal(18, 0),
	@MAX_SPEED int,
	@LOAI_DIA_HINH nvarchar(100),
	@SO_CHO_NGOI int,
	@GIA_TIEN_BAN money,
	@GIA_TIEN_MUA money,
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [XE]
	(
		[TEN_XE],
		[MA_KIEU_XE],
		[MA_HANG_XE],
		[DOI_XE],
		[CHI_SO_NHIEN_LIEU],
		[MAX_SPEED],
		[LOAI_DIA_HINH],
		[SO_CHO_NGOI],
		[GIA_TIEN_BAN],
		[GIA_TIEN_MUA],
		[SO_LUONG]
	)
	VALUES
	(
	@TEN_XE,
	@MA_KIEU_XE,
	@MA_HANG_XE,
	@DOI_XE,
	@CHI_SO_NHIEN_LIEU,
	@MAX_SPEED,
	@LOAI_DIA_HINH,
	@SO_CHO_NGOI,
	@GIA_TIEN_BAN,
	@GIA_TIEN_MUA,
	@SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO
