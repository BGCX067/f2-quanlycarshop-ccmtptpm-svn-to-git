if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [LOAI_XE]
	WHERE	[MA] = @MA
END
GO
