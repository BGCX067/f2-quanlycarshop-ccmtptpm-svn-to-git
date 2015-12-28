if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [KHACH_HANG]
	WHERE	[MA] = @MA
END
GO
