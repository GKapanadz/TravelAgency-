
CREATE PROCEDURE sp_InsertTour
@Name NVARCHAR(20),
@Duration INT,
@TotalPrice MONEY,
@StartDate DATE,
@EndDate DATE,
@TourID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Tours(Name, Duration, TotalPrice, StartDate, EndDate)
    VALUES(@Name, @Duration, @TotalPrice, @StartDate, @EndDate);

    SET @TourID = SCOPE_IDENTITY();

    RETURN 0;
END