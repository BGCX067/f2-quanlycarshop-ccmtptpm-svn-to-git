if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_SelectAll]

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
END
GO
