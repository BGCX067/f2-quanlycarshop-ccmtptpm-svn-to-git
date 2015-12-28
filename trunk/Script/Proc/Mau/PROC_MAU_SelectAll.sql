if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_SelectAll]

AS
BEGIN

	SELECT [MA], [MAU]
	FROM [MAU]
END
GO
