if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_KHACHHANG_SelectByThongTin]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_KHACHHANG_SelectByThongTin]
GO

CREATE PROCEDURE [dbo].[PROC_KHACHHANG_SelectByThongTin]
(
	@HO_TEN NVARCHAR(40),
	@DIA_CHI NVARCHAR(50),
	@CMND CHAR(9)
)

AS
BEGIN
	IF @DIA_CHI = ''
		SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
		FROM [KHACH_HANG]
		WHERE	@HO_TEN = HO_TEN AND CMND = @CMND
	ELSE
		SELECT [MA], [HO_TEN], [PHAI], [DIA_CHI], [DIEN_THOAI], [CMND], [LOAI_KHACH_HANG]
		FROM [KHACH_HANG]
		WHERE	@HO_TEN = HO_TEN AND DIA_CHI = @DIA_CHI
END
GO
