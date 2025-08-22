CREATE PROCEDURE sp_UpdateOrder
@OrderID INT,
@TouristID INT,
@TourID INT,
@NumberOfPeople INT,
@TotalPrice MONEY,
@IsPaid BIT,
@PaymentDate Date
AS
BEGIN 
    SET NOCOUNT ON;
    
    UPDATE Orders
    SET TouristID = @TouristID,
        TourID = @TourID,
        NumberOfPeople = @NumberOfPeople,
        TotalPrice = @TotalPrice,
        IsPaid = @IsPaid,
        PaymentDate = @PaymentDate

    WHERE OrderID = @OrderID AND (TouristID != @TouristID OR TourID != @TourID OR NumberOfPeople != @NumberOfPeople 
    OR TotalPrice != @TotalPrice OR IsPaid != @IsPaid OR  PaymentDate != @PaymentDate)

    RETURN 0;
END
