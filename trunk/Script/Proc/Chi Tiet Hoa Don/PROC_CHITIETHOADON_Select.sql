if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Select]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
	WHERE	[MA] = @MA
END
GO
