CREATE PROCEDURE sp_UpdateHotel
@HotelID INT,
@CityID INT,
@Name NVARCHAR(40),
@Stars INT,
@PerNightPrice MONEY,
@Dining BIT,
@AdditionalServices NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Hotels WHERE HotelID = @HotelID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is not active', 16, 1)
        RETURN 1;
    END

    UPDATE Hotels
    SET CityID = @CityID,
        Name = @Name,
        Stars = @Stars,
        PerNightPrice = @PerNightPrice,
        Dining = @Dining,
        AdditionalServices = @AdditionalServices,
        UpdateDate = GETDATE()
    WHERE HotelID = @HotelID AND 
          (CityID != @CityID OR Name != @Name OR Stars != @Stars OR 
           PerNightPrice != @PerNightPrice OR Dining != @Dining OR 
           AdditionalServices IS DISTINCT FROM @AdditionalServices)

    RETURN 0;
END