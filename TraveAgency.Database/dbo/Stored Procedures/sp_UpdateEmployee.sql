﻿CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeID INT,
    @FirstName NVARCHAR(15),
    @LastName NVARCHAR(20),
    @Email VARCHAR(50),
    @AddressLine1 NVARCHAR(100),
    @AddressLine2 NVARCHAR(100) = NULL,
    @TourID INT,
    @PhoneNumber VARCHAR(24),
    @BirthDate DATE,
    @HireDate DATE,
    @PositionID INT,
	@ReportsTo INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID AND IsActive = 0)
    BEGIN
        RAISERROR('Record is not active', 16, 1);
        RETURN 1;
    END

    UPDATE Employees
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        AddressLine1 = @AddressLine1,
        AddressLine2 = @AddressLine2,
        TourID = @TourID,
        PhoneNumber = @PhoneNumber,
        BirthDate = @BirthDate,
        HireDate = @HireDate,
        PositionID = @PositionID,

        UpdateDate = GETDATE()
    WHERE 
        EmployeeID = @EmployeeID 
        AND (
            FirstName != @FirstName 
            OR LastName != @LastName 
            OR Email != @Email 
            OR AddressLine1 != @AddressLine1 
            OR COALESCE(AddressLine2, '') != COALESCE(@AddressLine2, '')
            OR TourID != @TourID 
            OR PhoneNumber != @PhoneNumber 
            OR BirthDate != @BirthDate
            OR HireDate != @HireDate 
            OR PositionID != @PositionID 
        );

    RETURN 0;
END