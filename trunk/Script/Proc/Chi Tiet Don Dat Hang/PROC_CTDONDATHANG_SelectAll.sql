if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_SelectAll]

AS
BEGIN

	SELECT [MA_DON_DAT_HANG], [MA_XE], [MA_MAU], [SO_LUONG], [TONG_TIEN]
	FROM [CT_DON_DAT_HANG]
END
GO
