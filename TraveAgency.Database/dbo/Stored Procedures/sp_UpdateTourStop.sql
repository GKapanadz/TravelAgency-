CREATE PROCEDURE sp_UpdateTourStop
@TourStopID INT,
@TourID INT,
@CityID INT,
@DaysSpent INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM TourStops WHERE TourStopID = @TourStopID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is not active', 16, 1)
        RETURN 1;
    END

    UPDATE TourStops
    SET TourID = @TourID,
        CityID = @CityID,
        DaysSpent = @DaysSpent,
        UpdateDate = GETDATE()
    WHERE TourStopID = @TourStopID AND 
          (TourID != @TourID OR CityID != @CityID OR DaysSpent != @DaysSpent)

    RETURN 0;
END