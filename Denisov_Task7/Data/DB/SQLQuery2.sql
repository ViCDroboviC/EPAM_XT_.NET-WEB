USE [Users&awards]
GO
/****** Object:  StoredProcedure [dbo].[Users_GetAll]    Script Date: 16.09.2020 22:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Users_GetAll]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		id, username, Name, DateOfBirth, Age, role
	FROM Users
END
