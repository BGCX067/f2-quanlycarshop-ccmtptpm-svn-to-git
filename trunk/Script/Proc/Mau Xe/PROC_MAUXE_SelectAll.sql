if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_SelectAll]

AS
BEGIN

	SELECT [MA_XE], [MA_MAU], MAU, [SO_LUONG]
	FROM [MAU_XE], MAU
	WHERE  MAU.MA = MAU_XE.MA_MAU
END
GO
