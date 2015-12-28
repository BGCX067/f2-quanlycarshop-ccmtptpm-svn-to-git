if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Insert]
(
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS
BEGIN
	INSERT INTO [LOAI_NHAN_VIEN]
	(
		[TEN_LOAI_NHAN_VIEN]
	)
	VALUES
	(
	@TEN_LOAI_NHAN_VIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO
