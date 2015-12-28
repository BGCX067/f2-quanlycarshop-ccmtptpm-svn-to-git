if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_KHACH_HANG], [MA_NHAN_VIEN], [NGAY_LAP], [KIEU_THANH_TOAN], [TONG_TIEN], [TIEN_TRA_MOI_DOT], [SO_LAN_TRA]
	FROM [HOA_DON]
END
GO
