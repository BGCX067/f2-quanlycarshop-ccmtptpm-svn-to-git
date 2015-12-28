if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO
