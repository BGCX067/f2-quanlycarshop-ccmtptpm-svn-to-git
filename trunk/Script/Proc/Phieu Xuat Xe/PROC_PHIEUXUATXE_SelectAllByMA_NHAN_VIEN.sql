if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAllByMA_NHAN_VIEN]
(
	@MA_NHAN_VIEN int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA_NHAN_VIEN] = @MA_NHAN_VIEN
END
GO
