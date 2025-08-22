CREATE PROCEDURE sp_GetTourStop
@TourStopID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM TourStops 
    WHERE TourStopID = @TourStopID AND IsActive = 1
END