if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAIXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAIXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_LOAIXE_Insert]
(
	@TEN_LOAI_XE nvarchar(30),
	@GHI_CHU nvarchar(200)
)

AS
BEGIN
	INSERT INTO [LOAI_XE]
	(
		[TEN_LOAI_XE],
		[GHI_CHU]
	)
	VALUES
	(
	@TEN_LOAI_XE,
	@GHI_CHU
	)

	SELECT SCOPE_IDENTITY()
END
GO
