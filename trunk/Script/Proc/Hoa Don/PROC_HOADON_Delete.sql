if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA] = @MA
END
GO
