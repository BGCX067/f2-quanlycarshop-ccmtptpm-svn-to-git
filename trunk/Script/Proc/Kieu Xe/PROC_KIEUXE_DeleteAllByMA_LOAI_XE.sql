if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_DeleteAllByMA_LOAI_XE]
(
	@MA_LOAI_XE int
)

AS

BEGIN

	DELETE FROM [KIEU_XE]
	WHERE	[MA_LOAI_XE] = @MA_LOAI_XE
END
GO
