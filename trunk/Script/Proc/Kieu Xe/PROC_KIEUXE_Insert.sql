if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KIEUXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KIEUXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_KIEUXE_Insert]
(
	@MA_LOAI_XE int,
	@TEN_KIEU_XE nvarchar(30)
)

AS
BEGIN
	INSERT INTO [KIEU_XE]
	(
		[MA_LOAI_XE],
		[TEN_KIEU_XE]
	)
	VALUES
	(
	@MA_LOAI_XE,
	@TEN_KIEU_XE
	)

	SELECT SCOPE_IDENTITY()
END
GO
