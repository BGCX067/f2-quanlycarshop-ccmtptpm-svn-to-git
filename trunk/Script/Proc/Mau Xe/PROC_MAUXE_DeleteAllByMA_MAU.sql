if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO
