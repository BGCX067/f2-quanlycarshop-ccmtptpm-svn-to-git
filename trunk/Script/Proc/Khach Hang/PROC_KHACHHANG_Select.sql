if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
	FROM [KHACH_HANG]
	WHERE	[MA] = @MA
END
GO
