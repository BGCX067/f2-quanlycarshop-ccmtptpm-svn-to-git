if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Select]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
	WHERE	[MA_DON_DAT_HANG] = @MA_DON_DAT_HANG	AND [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
