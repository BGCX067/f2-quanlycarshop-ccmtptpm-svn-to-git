if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_DeleteAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO
