CREATE PROCEDURE sp_GetTourist
@TouristID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Tourists 
    WHERE TouristID = @TouristID AND IsActive = 1;
END