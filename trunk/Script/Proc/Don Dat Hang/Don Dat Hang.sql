if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Select]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [NGAY_DAT], [TONG_TIEN], [TONG_SO_LUONG]
	FROM [DON_DAT_HANG]
	WHERE	[MA] = @MA
END
GO

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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [DON_DAT_HANG]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_Update]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_Update]
(
	@MA int,
	@NGAY_DAT smalldatetime,
	@TONG_TIEN money,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [DON_DAT_HANG]
	SET 
		[NGAY_DAT] = @NGAY_DAT, 
		[TONG_TIEN] = @TONG_TIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_DONDATHANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_DONDATHANG_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_DONDATHANG_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_DAT], [TONG_TIEN], [TONG_SO_LUONG]
	FROM [DON_DAT_HANG]
END
GO
