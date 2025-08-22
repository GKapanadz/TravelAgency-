CREATE PROCEDURE sp_InsertCountry
@Name VARCHAR(30),
@CountryID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Countries(Name)
    VALUES(@Name);

    SET @CountryID = SCOPE_IDENTITY();

    RETURN 0;
END