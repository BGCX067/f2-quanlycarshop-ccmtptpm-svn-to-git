if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Update]
(
	@MA int,
	@HO_TEN nvarchar(30),
	@MA_LOAI_NHAN_VIEN int,
	@PHAI bit,
	@NGAY_SINH smalldatetime,
	@DIA_CHI nvarchar(150),
	@DIEN_THOAI char(11),
	@CMND char(9)
)

AS

BEGIN

	UPDATE [NHAN_VIEN]
	SET 
		[HO_TEN] = @HO_TEN, 
		[MA_LOAI_NHAN_VIEN] = @MA_LOAI_NHAN_VIEN, 
		[PHAI] = @PHAI, 
		[NGAY_SINH] = @NGAY_SINH, 
		[DIA_CHI] = @DIA_CHI, 
		[DIEN_THOAI] = @DIEN_THOAI, 
		[CMND] = @CMND
	WHERE [MA] = @MA
END
GO
