if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_LOAI_XE], [GHI_CHU]
	FROM [LOAI_XE]
	WHERE	[MA] = @MA
END
GO
