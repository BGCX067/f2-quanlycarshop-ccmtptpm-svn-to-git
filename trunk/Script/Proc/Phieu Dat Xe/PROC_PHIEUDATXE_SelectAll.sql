if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUDATXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUDATXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUDATXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_DAT], [NGAY_HEN_LAY], [TONG_TIEN], [TIEN_TRA_TRUOC]
	FROM [PHIEU_DAT_XE]
END
GO
