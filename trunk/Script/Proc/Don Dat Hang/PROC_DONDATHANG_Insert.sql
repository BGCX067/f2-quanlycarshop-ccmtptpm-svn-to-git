if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Insert]
(
	@NGAY_DAT smalldatetime,
	@TONG_TIEN money,
	@TONG_SO_LUONG int
)

AS
BEGIN
	INSERT INTO [DON_DAT_HANG]
	(
		[NGAY_DAT],
		[TONG_TIEN],
		[TONG_SO_LUONG]
	)
	VALUES
	(
	@NGAY_DAT,
	@TONG_TIEN,
	@TONG_SO_LUONG
	)

	SELECT SCOPE_IDENTITY()
END
GO
