CREATE PROCEDURE sp_InsertTourStop
@TourID INT,
@CityID INT,
@DaysSpent INT,
@TourStopID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO TourStops(TourID, CityID, DaysSpent)
    VALUES(@TourID, @CityID, @DaysSpent);

    SET @TourStopID = SCOPE_IDENTITY();

    RETURN 0;
END