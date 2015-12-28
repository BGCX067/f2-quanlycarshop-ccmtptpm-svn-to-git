if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Delete]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
