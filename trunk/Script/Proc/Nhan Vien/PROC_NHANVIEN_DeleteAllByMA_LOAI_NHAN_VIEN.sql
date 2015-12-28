if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_DeleteAllByMA_LOAI_NHAN_VIEN]
(
	@MA_LOAI_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [NHAN_VIEN]
	WHERE	[MA_LOAI_NHAN_VIEN] = @MA_LOAI_NHAN_VIEN
END
GO
