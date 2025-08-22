CREATE PROCEDURE sp_InsertTourist
@TourID INT,
@FirstName NVARCHAR(30),
@LastName NVARCHAR(40),
@BirthDate DATE,
@ContactPhone VARCHAR(50),
@TouristID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Tourists(TourID, FirstName, LastName, BirthDate, ContactPhone)
    VALUES(@TourID, @FirstName, @LastName, @BirthDate, @ContactPhone);

    SET @TouristID = SCOPE_IDENTITY();

    RETURN 0;
END