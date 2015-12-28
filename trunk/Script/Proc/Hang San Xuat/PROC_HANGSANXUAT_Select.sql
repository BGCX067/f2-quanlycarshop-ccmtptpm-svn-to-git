if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HANGSANXUAT_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HANGSANXUAT_Select]
GO

CREATE PROCEDURE [dbo].[PROC_HANGSANXUAT_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_HANG_XE]
	FROM [HANG_SAN_XUAT]
	WHERE	[MA] = @MA
END
GO
