if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CTPHIEUNHAPXE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CTPHIEUNHAPXE_SelectAll]

AS
BEGIN

	SELECT [MA_PHIEU_NHAP_XE], [MA_XE], [MA_MAU], [SO_LUONG]
	FROM [CT_PHIEU_NHAP_XE]
END
GO
