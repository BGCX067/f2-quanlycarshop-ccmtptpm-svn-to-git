if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_HOA_DON]
	WHERE	[MA] = @MA
END
GO
