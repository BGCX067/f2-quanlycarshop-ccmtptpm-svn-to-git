if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Update]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Update]
(
	@MA char(10),
	@MAU nvarchar(15)
)

AS

BEGIN

	UPDATE [MAU]
	SET 
		[MAU] = @MAU
	WHERE [MA] = @MA
END
GO
