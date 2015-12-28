if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]
GO

CREATE PROCEDURE [dbo].[PROC_NhanVien_SelectBy_MA_HOA_DON]
(
	@MA_HOA_DON int
)

AS
BEGIN

	SELECT NV.[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM NHAN_VIEN NV, HOA_DON HD, LOAI_NHAN_VIEN
	WHERE NV.MA = HD.MA_NHAN_VIEN AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO
