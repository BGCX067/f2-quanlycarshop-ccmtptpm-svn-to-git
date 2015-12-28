if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Update]
(
	@MA int,
	@TEN_LOAI_XE nvarchar(30),
	@GHI_CHU nvarchar(200)
)

AS

BEGIN

	UPDATE [LOAI_XE]
	SET 
		[TEN_LOAI_XE] = @TEN_LOAI_XE, 
		[GHI_CHU] = @GHI_CHU
	WHERE [MA] = @MA
END
GO
