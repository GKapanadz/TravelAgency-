CREATE PROCEDURE sp_InsertHotel
@CityID INT,
@Name NVARCHAR(20),
@Stars INT,
@PerNightPrice MONEY,
@Dining BIT,
@AdditionalServices VARCHAR(1000) Null,
@HotelID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Hotels(CityID, Name, Stars, PerNightPrice, Dining, AdditionalServices)
    VALUES(@CityID, @Name, @Stars, @PerNightPrice, @Dining, @AdditionalServices);

    SET @HotelID = SCOPE_IDENTITY();

    RETURN 0;
END