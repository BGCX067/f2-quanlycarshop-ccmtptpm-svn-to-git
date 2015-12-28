if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_DeleteAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS

BEGIN

	DELETE FROM [PHIEU_DAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO
