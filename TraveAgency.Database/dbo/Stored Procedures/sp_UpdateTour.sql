CREATE PROCEDURE sp_UpdateTour
@TourID INT,
@Name NVARCHAR(20),
@Duration INT,
@TotalPrice MONEY,
@StartDate DATE,
@EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Tours WHERE TourID = @TourID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is not active', 16, 1)
        RETURN 1;
    END

    UPDATE Tours
    SET Name = @Name,
        Duration = @Duration,
        TotalPrice = @TotalPrice,
        StartDate = @StartDate,
        EndDate = @EndDate,
        UpdateDate = GETDATE()
    WHERE TourID = @TourID AND 
          (Name != @Name OR Duration != @Duration OR 
           TotalPrice != @TotalPrice OR StartDate != @StartDate OR 
           EndDate != @EndDate)

    RETURN 0;
END