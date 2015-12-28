if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Update]
(
	@MA int,
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS

BEGIN

	UPDATE [LOAI_NHAN_VIEN]
	SET 
		[TEN_LOAI_NHAN_VIEN] = @TEN_LOAI_NHAN_VIEN
	WHERE [MA] = @MA
END
GO
