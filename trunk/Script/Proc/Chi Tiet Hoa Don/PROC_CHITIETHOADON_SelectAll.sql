if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_CHITIETHOADON_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_CHITIETHOADON_SelectAll]
GO

CREATE PROCEDURE [dbo].[PROC_CHITIETHOADON_SelectAll]

AS
BEGIN

	SELECT [MA], [MA_HOA_DON], [MA_XE], [MA_MAU], [SO_LUONG], [THANH_TIEN]
	FROM [CHI_TIET_HOA_DON]
END
GO
