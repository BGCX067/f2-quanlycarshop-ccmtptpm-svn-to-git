if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Insert]
(
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS
BEGIN
	INSERT INTO [LOAI_NHAN_VIEN]
	(
		[TEN_LOAI_NHAN_VIEN]
	)
	VALUES
	(
	@TEN_LOAI_NHAN_VIEN
	)

	SELECT SCOPE_IDENTITY()
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [LOAI_NHAN_VIEN]
	WHERE	[MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_Update]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_Update]
(
	@MA int,
	@TEN_LOAI_NHAN_VIEN nvarchar(50)
)

AS

BEGIN

	UPDATE [LOAI_NHAN_VIEN]
	SET 
		[TEN_LOAI_NHAN_VIEN] = @TEN_LOAI_NHAN_VIEN
	WHERE [MA] = @MA
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_LOAINHANVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_LOAINHANVIEN_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_LOAINHANVIEN_SelectAll]

AS
BEGIN

	SELECT [MA], [TEN_LOAI_NHAN_VIEN]
	FROM [LOAI_NHAN_VIEN]
END
GO
