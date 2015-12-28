if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Insert]
(
	@TEN_HANG_XE nvarchar(256)
)

AS
BEGIN
	INSERT INTO [HANG_SAN_XUAT]
	(
		[TEN_HANG_XE]
	)
	VALUES
	(
	@TEN_HANG_XE
	)

	SELECT SCOPE_IDENTITY()
END
GO
