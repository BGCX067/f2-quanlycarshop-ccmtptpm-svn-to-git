if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTDONDATHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTDONDATHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_CTDONDATHANG_Insert]
(
	@MA_DON_DAT_HANG int,
	@MA_XE int,
	@MA_MAU char(10),
	@SO_LUONG int,
	@TONG_TIEN money
)

AS
BEGIN
	INSERT INTO [CT_DON_DAT_HANG]
	(
		[MA_DON_DAT_HANG],
		[MA_XE],
		[MA_MAU],
		[SO_LUONG],
		[TONG_TIEN]
	)
	VALUES
	(
	@MA_DON_DAT_HANG,
	@MA_XE,
	@MA_MAU,
	@SO_LUONG,
	@TONG_TIEN
	)
END
GO
