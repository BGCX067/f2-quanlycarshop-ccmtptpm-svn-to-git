if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAUXE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAUXE_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_MAUXE_Insert]
(
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int
)

AS
BEGIN
	INSERT INTO [MAU_XE]
	(
		[MA_XE],
		[MA_MAU],
		[SO_LUONG]
	)
	VALUES
	(
	@MA_XE,
	@MA_MAU,
	@SO_LUONG
	)
END
GO
