if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_PHIEUNHAPXE_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_PHIEUNHAPXE_Delete]
GO

CREATE PROCEDURE [dbo].[PROC_PHIEUNHAPXE_Delete]
(
	@MA int
)

AS

BEGIN

	DELETE FROM [PHIEU_NHAP_XE]
	WHERE	[MA] = @MA
END
GO
