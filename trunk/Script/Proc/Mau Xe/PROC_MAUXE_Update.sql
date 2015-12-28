if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Update]
(
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG money
)

AS

BEGIN

	UPDATE [MAU_XE]
	SET 
		[SO_LUONG] = @SO_LUONG
	WHERE [MA_XE] = @MA_XE	AND [MA_MAU] = @MA_MAU
END
GO
