if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAllByMA_DON_DAT_HANG]
(
	@MA_DON_DAT_HANG int
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG
END
GO
