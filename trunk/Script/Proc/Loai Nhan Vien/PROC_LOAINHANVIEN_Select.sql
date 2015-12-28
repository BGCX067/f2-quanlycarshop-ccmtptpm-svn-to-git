if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO
