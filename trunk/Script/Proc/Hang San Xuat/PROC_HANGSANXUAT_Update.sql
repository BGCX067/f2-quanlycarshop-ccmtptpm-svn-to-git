if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Update]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Update]
(
	@MA int,
	@TEN_HANG_XE nvarchar(256)
)

AS

BEGIN

	UPDATE [HANG_SAN_XUAT]
	SET 
		[TEN_HANG_XE] = @TEN_HANG_XE
	WHERE [MA] = @MA
END
GO
