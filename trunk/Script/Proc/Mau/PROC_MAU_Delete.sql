if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Delete]
(
	@MA char(10)
)

AS

BEGIN

	DELETE FROM [MAU]
	WHERE	[MA] = @MA
END
GO
