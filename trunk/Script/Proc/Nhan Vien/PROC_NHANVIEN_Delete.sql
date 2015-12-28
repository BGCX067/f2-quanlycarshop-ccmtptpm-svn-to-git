if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO
