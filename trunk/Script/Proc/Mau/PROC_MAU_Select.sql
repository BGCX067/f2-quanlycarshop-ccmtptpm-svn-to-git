if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Select]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Select]
(
	@MA char(10)
)

AS
BEGIN

	SELECT [MA], [MAU]
	FROM [MAU]
	WHERE	[MA] = @MA
END
GO
