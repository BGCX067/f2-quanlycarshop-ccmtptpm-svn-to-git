if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
GO

CREATE PROCEDURE [dbo].[PROC_HOADON_DeleteAllByMA_KHACH_HANG]
(
	@MA_KHACH_HANG int
)

AS

BEGIN

	DELETE FROM [HOA_DON]
	WHERE	[MA_KHACH_HANG] = @MA_KHACH_HANG
END
GO
