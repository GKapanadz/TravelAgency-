CREATE PROCEDURE sp_GetHotel
@HotelID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Hotels 
    WHERE HotelID = @HotelID AND IsActive = 1
END