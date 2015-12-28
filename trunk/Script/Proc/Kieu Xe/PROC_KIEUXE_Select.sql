if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_LOAI_XE], [TEN_KIEU_XE]
	FROM [KIEU_XE]
	WHERE	[MA] = @MA
END
GO
