CREATE PROCEDURE sp_UpdateUser
    @UserID INT,
    @Username VARCHAR(30),
    @Password VARCHAR(30) = NULL,
    @UserRole TINYINT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM Users WHERE UserID = @UserID AND IsActive = 0)
    BEGIN 
         RAISERROR('Record is not active', 16, 1)
         RETURN 1;
    END

    UPDATE Users
    SET 
        Username = @Username,
        UserRole = @UserRole,
        UpdateDate = GETDATE(),
        Password = CASE 
                     WHEN @Password IS NOT NULL THEN HASHBYTES('SHA2_256', @Password) 
                     ELSE Password  
                  END
    WHERE 
        UserID = @UserID 
        AND (
            Username != @Username 
            OR (@Password IS NOT NULL AND Password != HASHBYTES('SHA2_256', @Password))
            OR UserRole != @UserRole
        );

    RETURN 0;
END