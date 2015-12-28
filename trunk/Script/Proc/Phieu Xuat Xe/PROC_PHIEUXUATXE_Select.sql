if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_Select]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
	WHERE	[MA] = @MA
END
GO
