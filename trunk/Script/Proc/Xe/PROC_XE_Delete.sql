if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_XE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [XE]
	WHERE	[MA] = @MA
END
GO
