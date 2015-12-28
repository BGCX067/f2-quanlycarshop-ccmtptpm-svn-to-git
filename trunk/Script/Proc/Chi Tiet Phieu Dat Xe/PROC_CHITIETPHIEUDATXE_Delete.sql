if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETPHIEUDATXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETPHIEUDATXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [CHI_TIET_PHIEU_DAT_XE]
	WHERE	[MA] = @MA
END
GO
