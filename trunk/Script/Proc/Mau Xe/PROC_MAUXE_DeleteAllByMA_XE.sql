if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_DeleteAllByMA_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_DeleteAllByMA_XE]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_DeleteAllByMA_XE]
(
	@MA_XE int
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_XE] = @MA_XE
END
GO
