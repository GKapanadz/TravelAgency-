CREATE PROCEDURE sp_DeleteHotel
@HotelID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM Hotels WHERE HotelID = @HotelID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is already not active', 16, 1)
        RETURN 1;
    END

    UPDATE Hotels
    SET IsActive = 0
    WHERE HotelID = @HotelID

    RETURN 0;
END