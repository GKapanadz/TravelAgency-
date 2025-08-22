CREATE PROCEDURE sp_UpdateTourist
@TouristID INT,
@TourID INT,
@FirstName NVARCHAR(30),
@LastName NVARCHAR(40),
@BirthDate DATE,
@ContactPhone VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tourists
    SET TourID = @TourID,
        FirstName = @FirstName,
        LastName = @LastName,
        BirthDate = @BirthDate,
        ContactPhone = @ContactPhone
    WHERE TouristID = @TouristID

    RETURN 0;
END