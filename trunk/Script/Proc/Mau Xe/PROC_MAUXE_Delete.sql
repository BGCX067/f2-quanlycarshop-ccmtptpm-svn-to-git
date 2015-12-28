if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Delete]
(
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [MAU_XE]
	WHERE	[MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
