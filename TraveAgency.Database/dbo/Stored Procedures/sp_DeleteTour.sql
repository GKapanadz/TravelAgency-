CREATE PROCEDURE sp_DeleteTour
@TourID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM Tours WHERE TourID = @TourID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is already not active', 16, 1)
        RETURN 1;
    END

    UPDATE Tours
    SET IsActive = 0
    WHERE TourID = @TourID

    RETURN 0;
END