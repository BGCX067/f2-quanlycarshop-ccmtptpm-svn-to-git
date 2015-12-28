if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_Insert]
(
	@MA_HOA_DON int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@THANH_TIEN money
)

AS
BEGIN
	INSERT INTO [CHI_TIET_HOA_DON]
	(
		[MA_HOA_DON],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[THANH_TIEN]
	)
	VALUES
	(
	@MA_HOA_DON,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@THANH_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO
