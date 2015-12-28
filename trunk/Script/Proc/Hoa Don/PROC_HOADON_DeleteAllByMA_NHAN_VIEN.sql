if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO
