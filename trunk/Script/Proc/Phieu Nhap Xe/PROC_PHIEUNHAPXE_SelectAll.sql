if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_DON_DAT_HANG], [NGAY_NHAP], [TONG_SO_LUONG]
	FROM [PHIEU_NHAP_XE]
END
GO
