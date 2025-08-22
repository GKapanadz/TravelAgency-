CREATE PROCEDURE sp_GetOrder
@OrderID INT
AS
BEGIN 
    SET NOCOUNT ON;

    SELECT * 
    FROM Orders
    WHERE OrderID = @OrderID
END
