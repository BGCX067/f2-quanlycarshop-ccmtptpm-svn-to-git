if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Update]
(
	@MA int,
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

	UPDATE [XE]
	SET 
		[TEN_XE] = @TEN_XE, 
		[MA_KIEU_XE] = @MA_KIEU_XE, 
		[MA_HANG_XE] = @MA_HANG_XE, 
		[DOI_XE] = @DOI_XE, 
		[CHI_SO_NHIEN_LIEU] = @CHI_SO_NHIEN_LIEU, 
		[MAX_SPEED] = @MAX_SPEED, 
		[LOAI_DIA_HINH] = @LOAI_DIA_HINH, 
		[SO_CHO_NGOI] = @SO_CHO_NGOI, 
		[GIA_TIEN_BAN] = @GIA_TIEN_BAN, 
		[GIA_TIEN_MUA] = @GIA_TIEN_MUA, 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA] = @MA
END
GO
