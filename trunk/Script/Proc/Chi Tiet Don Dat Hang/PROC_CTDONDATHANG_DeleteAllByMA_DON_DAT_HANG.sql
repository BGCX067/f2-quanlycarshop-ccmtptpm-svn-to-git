if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_DeleteAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO
