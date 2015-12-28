if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Update]
(
	@MA int,
	@MA_LOAI_XE int,
	@TEN_KIEU_XE nvarchar(30)
)

AS

BEGIN

	UPDATE [KIEU_XE]
	SET 
		[MA_LOAI_XE] = @MA_LOAI_XE, 
		[TEN_KIEU_XE] = @TEN_KIEU_XE
	WHERE [MA] = @MA
END
GO
