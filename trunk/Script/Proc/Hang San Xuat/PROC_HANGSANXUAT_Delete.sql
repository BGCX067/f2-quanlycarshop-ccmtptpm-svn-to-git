if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [HANG_SAN_XUAT]
	WHERE	[MA] = @MA
END
GO
