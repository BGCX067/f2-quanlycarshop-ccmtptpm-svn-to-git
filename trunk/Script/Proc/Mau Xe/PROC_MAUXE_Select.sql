if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Select]
(
	@MA_XE int,
	@MA_MAU char(10)
)

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE	[MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU  AND MAU.MA = MAU_XE.MA_MAU
END
GO
