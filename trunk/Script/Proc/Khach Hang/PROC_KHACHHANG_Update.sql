if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Update]
(
	@MA int,
	@HO_TEN nvarchar(40),
	@PHAI bit,
	@DIA_CHI nvarchar(50),
	@DIEN_THOAI char(10),
	@CMND char(9),
	@LOAI_KHACH_HANG bit
)

AS

BEGIN

	UPDATE [KHACH_HANG]
	SET 
		[HO_TEN] = @HO_TEN, 
		[PHAI] = @PHAI, 
		[DIA_CHI] = @DIA_CHI, 
		[DIEN_THOAI] = @DIEN_THOAI, 
		[CMND] = @CMND, 
		[LOAI_KHACH_HANG] = @LOAI_KHACH_HANG
	WHERE [MA] = @MA
END
GO
