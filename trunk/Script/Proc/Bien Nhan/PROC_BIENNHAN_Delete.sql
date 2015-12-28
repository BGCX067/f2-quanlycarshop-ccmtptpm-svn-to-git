if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO
