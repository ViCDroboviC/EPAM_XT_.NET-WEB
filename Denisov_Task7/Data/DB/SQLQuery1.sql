CREATE PROCEDURE dbo.Users_GetAll
	@id int
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		id, username, Name, DateOfBirth, Age, role
	FROM Users
END
GO
