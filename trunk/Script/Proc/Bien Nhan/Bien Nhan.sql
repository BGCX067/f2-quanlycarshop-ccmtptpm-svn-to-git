if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_DeleteAllByMA_HOA_DON]
(
	@MA_HOA_DON int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA_HOA_DON] = @MA_HOA_DON
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Update]
(
	@MA int,
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS

BEGIN

	UPDATE [BIEN_NHAN]
	SET 
		[MA_HOA_DON] = @MA_HOA_DON, 
		[NGAY_THANH_TOAN] = @NGAY_THANH_TOAN, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[SO_TIEN] = @SO_TIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [NGAY_THANH_TOAN], [MA_NHAN_VIEN], [SO_TIEN]
	FROM [BIEN_NHAN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_Insert]
(
	@MA_HOA_DON int,
	@NGAY_THANH_TOAN datetime,
	@MA_NHAN_VIEN int,
	@SO_TIEN money
)

AS
BEGIN
	INSERT INTO [BIEN_NHAN]
	(
		[MA_HOA_DON],
		[NGAY_THANH_TOAN],
		[MA_NHAN_VIEN],
		[SO_TIEN]
	)
	VALUES
	(
	@MA_HOA_DON,
	@NGAY_THANH_TOAN,
	@MA_NHAN_VIEN,
	@SO_TIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_BIENNHAN_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [BIEN_NHAN]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO