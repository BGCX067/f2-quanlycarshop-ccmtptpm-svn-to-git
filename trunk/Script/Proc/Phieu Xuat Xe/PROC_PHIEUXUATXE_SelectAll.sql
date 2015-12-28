if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUXUATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUXUATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUXUATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [NGAY_XUAT], [MA_NHAN_VIEN], [TONG_SO_LUONG]
	FROM [PHIEU_XUAT_XE]
END
GO
