CREATE PROCEDURE sp_ClearDatabase
AS
BEGIN
    SET NOCOUNT ON;

    -- Disable Foreign Key Constraints
    EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all";

    -- Delete Data from All Tables (Correct Order to Avoid FK Conflicts)
    DELETE FROM Orders;
    DELETE FROM Users;
    DELETE FROM Employees;
    DELETE FROM Positions;
    DELETE FROM TourStops;
    DELETE FROM Tourists;
    DELETE FROM Tours;
    DELETE FROM Hotels;
    DELETE FROM Cities;
    DELETE FROM Countries;

    -- Reset Identity Columns (Fixing Typo in CHECKIDENT)
    DBCC CHECKIDENT ('Orders', RESEED, 0);
    DBCC CHECKIDENT ('Employees', RESEED, 0);
    DBCC CHECKIDENT ('Positions', RESEED, 0);
    DBCC CHECKIDENT ('TourStops', RESEED, 0);
    DBCC CHECKIDENT ('Tourists', RESEED, 0);
    DBCC CHECKIDENT ('Tours', RESEED, 0);
    DBCC CHECKIDENT ('Hotels', RESEED, 0);
    DBCC CHECKIDENT ('Cities', RESEED, 0);
    DBCC CHECKIDENT ('Countries', RESEED, 0);

    -- Re-enable Foreign Key Constraints
    EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all";

END;