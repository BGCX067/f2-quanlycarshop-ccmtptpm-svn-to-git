if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Update]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Update]
(
	@MA int,
	@NGAY_XUAT datetime,
	@MA_NHAN_VIEN int,
	@TONG_SO_LUONG int
)

AS

BEGIN

	UPDATE [PHIEU_XUAT_XE]
	SET 
		[NGAY_XUAT] = @NGAY_XUAT, 
		[MA_NHAN_VIEN] = @MA_NHAN_VIEN, 
		[TONG_SO_LUONG] = @TONG_SO_LUONG
	WHERE [MA] = @MA
END
GO
