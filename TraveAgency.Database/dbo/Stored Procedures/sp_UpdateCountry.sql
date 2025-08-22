CREATE PROCEDURE sp_UpdateCountry
@CountryID INT,
@Name VARCHAR(30) 
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Countries WHERE CountryID = @CountryID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is not active', 16, 1)
        RETURN 1;
    END

    IF @Name IS NULL
        BEGIN
        RAISERROR('Name cannot be null', 16, 1)
        RETURN 1;
    END

    UPDATE Countries
    SET Name = @Name,
        UpdateDate = GETDATE()
    WHERE CountryID = @CountryID AND Name != @Name

    RETURN 0;
END