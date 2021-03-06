if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_XE_SelectAllByMA_HANG_XE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_XE_SelectAllByMA_HANG_XE]
GO

CREATE PROCEDURE [dbo].[PROC_XE_SelectAllByMA_HANG_XE]
(
	@MA_HANG_XE int
)

AS
BEGIN

	SELECT XE.[MA], [TEN_XE], [MA_KIEU_XE], KIEU_XE.TEN_KIEU_XE, [MA_HANG_XE], HANG_SAN_XUAT.TEN_HANG_XE, [DOI_XE], [CHI_SO_NHIEN_LIEU], [MAX_SPEED], [LOAI_DIA_HINH], [SO_CHO_NGOI], [GIA_TIEN_BAN], [GIA_TIEN_MUA], [SO_LUONG]
	FROM [XE], KIEU_XE, HANG_SAN_XUAT
	WHERE	[MA_HANG_XE] = @MA_HANG_XE
END
GO
