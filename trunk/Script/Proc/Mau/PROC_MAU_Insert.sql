if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROC_MAU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[PROC_MAU_Insert]
GO

CREATE PROCEDURE [dbo].[PROC_MAU_Insert]
(
	@MA char(10),
	@MAU nvarchar(15)
)

AS
BEGIN
	INSERT INTO [MAU]
	(
		[MA],
		[MAU]
	)
	VALUES
	(
	@MA,
	@MAU
	)
END
GO
