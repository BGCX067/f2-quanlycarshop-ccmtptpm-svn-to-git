if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_DAT], [TONG_TIEN], [TONG_SO_LUONG]
	FROM [DON_DAT_HANG]
END
GO
