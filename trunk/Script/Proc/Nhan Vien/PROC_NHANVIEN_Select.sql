if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_NHANVIEN_Select]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_NHANVIEN_Select]
GO

CREATE PROCEDURE [dbo].[PROC_NHANVIEN_Select]
(
	@MA int
)

AS
BEGIN

	SELECT [NHAN_VIEN].[MA], [HO_TEN], [MA_LOAI_NHAN_VIEN], USERNAME, USER_PASSWORD, TEN_LOAI_NHAN_VIEN, [PHAI], [NGAY_SINH], [DIA_CHI], [DIEN_THOAI], [CMND]
	FROM [NHAN_VIEN], LOAI_NHAN_VIEN
	WHERE	NHAN_VIEN.[MA] = @MA AND MA_LOAI_NHAN_VIEN = LOAI_NHAN_VIEN.MA
END
GO
