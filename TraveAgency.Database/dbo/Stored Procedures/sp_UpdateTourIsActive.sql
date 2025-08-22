CREATE PROCEDURE sp_UpdateTourIsActive
    @TourID INT,
    @IsActive BIT
AS
BEGIN
    UPDATE Tours
    SET IsActive = @IsActive
    WHERE TourID = @TourID
END