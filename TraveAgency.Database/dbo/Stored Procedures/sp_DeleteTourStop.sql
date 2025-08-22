CREATE PROCEDURE sp_DeleteTourStop
@TourStopID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM TourStops WHERE TourStopID = @TourStopID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is already not active', 16, 1)
        RETURN 1;
    END

    UPDATE TourStops
    SET IsActive = 0
    WHERE TourStopID = @TourStopID

    RETURN 0;
END