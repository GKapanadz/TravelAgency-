CREATE PROCEDURE sp_InsertEmployee
    @FirstName NVARCHAR(30),
    @LastName NVARCHAR(32),
	@Email VARCHAR(50),
	@AddressLine1 NVARCHAR(100),
	@AddressLine2 NVARCHAR(100) = NULL,
	@TourID INT,
	@PhoneNumber VARCHAR(24),
	@BirthDate DATE,
	@HireDate DATE,
    @PositionID INT,
    @EmployeeID INT OUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Employees (FirstName, LastName, Email, AddressLine1, AddressLine2, TourID, PhoneNumber, BirthDate, HireDate, PositionID)
    VALUES (@FirstName, @LastName, @Email, @AddressLine1, @AddressLine2, @TourID, @PhoneNumber, @BirthDate, @HireDate, @PositionID);

    SET @EmployeeID = SCOPE_IDENTITY();

    RETURN 0;
END