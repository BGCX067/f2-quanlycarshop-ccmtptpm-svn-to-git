if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_DeleteAllByMA_KIEU_XE]
(
	@MA_KIEU_XE int
)

AS

BEGIN

	DELETE FROM [XE]
	WHERE	[MA_KIEU_XE] = @MA_KIEU_XE
END
GO
