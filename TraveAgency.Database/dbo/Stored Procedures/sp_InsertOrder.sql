CREATE PROCEDURE sp_InsertOrder
@TouristID INT,
@TourID INT,
@NumberOfPeople INT,
@TotalPrice MONEY,
@IsPaid BIT,
@PaymentDate DATE,
@OrderID INT OUT
AS
BEGIN    
     SET NOCOUNT ON;
     
     INSERT INTO Orders(TouristID, TourID, NumberOfPeople, TotalPrice, IsPaid, PaymentDate)
     VALUES(@TouristID, @TourID, @NumberOfPeople, @TotalPrice, @IsPaid, @PaymentDate);
     
     SET @OrderID = SCOPE_IDENTITY()
     
     RETURN 0;
END
