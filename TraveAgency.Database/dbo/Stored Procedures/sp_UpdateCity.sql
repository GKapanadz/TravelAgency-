CREATE PROCEDURE sp_UpdateCity
@CityID INT,
@Name VARCHAR(30),
@CountryID INT
AS
BEGIN 
    SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Cities WHERE CityID = @CityID AND IsActive = 0)
	BEGIN
	   RAISERROR('Record is not active', 16, 1)
	   RETURN 1;
	END

	UPDATE Cities
	SET Name = @Name,
	    CountryID = @CountryID,
		UpdateDate = GETDATE()
		
	WHERE CityID = @CityID AND (Name != @Name OR CountryID != @CountryID)

	RETURN 0;
END