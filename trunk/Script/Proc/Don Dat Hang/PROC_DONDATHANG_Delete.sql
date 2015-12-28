if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [DON_DAT_HANG]
	WHERE	[MA] = @MA
END
GO
