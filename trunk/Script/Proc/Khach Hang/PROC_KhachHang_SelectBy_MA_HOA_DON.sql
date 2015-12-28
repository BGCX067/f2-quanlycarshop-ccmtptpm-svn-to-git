if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_KhachHang_SelectBy_MA_HOA_DON]
(
	@MA_HOA_DON INT
)

AS
BEGIN
	
	SELECT KH.MA, [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
	FROM KHACH_HANG KH, HOA_DON HD
	WHERE KH.MA = HD.MA_KHACH_HANG AND HD.MA = @MA_HOA_DON	
END
GO