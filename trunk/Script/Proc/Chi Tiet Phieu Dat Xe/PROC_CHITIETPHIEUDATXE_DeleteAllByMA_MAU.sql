if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_DeleteAllByMA_MAU]
(
	@MA_MAU char(10)
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA_MAU] = @MA_MAU
END
GO
