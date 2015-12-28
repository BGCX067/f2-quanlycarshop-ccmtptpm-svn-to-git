if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO
