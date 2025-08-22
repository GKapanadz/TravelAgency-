CREATE PROCEDURE sp_SeedDatabase
AS
BEGIN
    SET NOCOUNT ON;

    -- Clear the database before inserting new data
    EXEC sp_ClearDatabase;

    -- Insert Countries
    DECLARE @CountryID1 INT, @CountryID2 INT, @CountryID3 INT, @CountryID4 INT, @CountryID5 INT;
    EXEC sp_InsertCountry 'France', @CountryID1 OUTPUT;
    EXEC sp_InsertCountry 'Spain', @CountryID2 OUTPUT;
    EXEC sp_InsertCountry 'United States', @CountryID3 OUTPUT;
    EXEC sp_InsertCountry 'China', @CountryID4 OUTPUT;
    EXEC sp_InsertCountry 'United Kingdom', @CountryID5 OUTPUT;

    -- Insert Cities (using the correct CountryID values)
    DECLARE @CityID1 INT, @CityID2 INT, @CityID3 INT, @CityID4 INT, @CityID5 INT;
    EXEC sp_InsertCity 'Paris', @CountryID1, @CityID1 OUTPUT;
    EXEC sp_InsertCity 'Barcelona', @CountryID2, @CityID2 OUTPUT;
    EXEC sp_InsertCity 'New York', @CountryID3, @CityID3 OUTPUT;
    EXEC sp_InsertCity 'Beijing', @CountryID4, @CityID4 OUTPUT;
    EXEC sp_InsertCity 'London', @CountryID5, @CityID5 OUTPUT;

    -- Insert Tours (ensure correct date format)
    DECLARE @TourID1 INT, @TourID2 INT, @TourID3 INT, @TourID4 INT, @TourID5 INT;
    EXEC sp_InsertTour 'Asian Adventure', 5, 1050, '2025-04-01', '2025-04-06', @TourID1 OUTPUT;
    EXEC sp_InsertTour 'France Expedition', 6, 1500, '2025-04-03', '2025-04-09', @TourID2 OUTPUT;
    EXEC sp_InsertTour 'Spain Sojourn', 5, 2000, '2025-04-05', '2025-04-10', @TourID3 OUTPUT;
    EXEC sp_InsertTour 'American Escape', 6, 2300, '2025-04-05', '2025-04-11', @TourID4 OUTPUT;
    EXEC sp_InsertTour 'Royal Cruise', 7, 3000, '2025-04-10', '2025-04-17', @TourID5 OUTPUT;

    -- Insert Hotels (using correct CityID values)
    DECLARE @HotelID1 INT, @HotelID2 INT, @HotelID3 INT, @HotelID4 INT, @HotelID5 INT;
    EXEC sp_InsertHotel @CityID1, 'Paris Centre Eiffel', 4, 150, 1, 'Laundry, WiFi, Satellite television', @HotelID1 OUTPUT;
    EXEC sp_InsertHotel @CityID2, 'Casa Capel Barcelona', 5, 250, 1, 'WiFi, Satellite television', @HotelID2 OUTPUT;
    EXEC sp_InsertHotel @CityID3, 'Hotel Redison Time Square', 5, 300, 1, 'Laundry, WiFi, Satellite television', @HotelID3 OUTPUT;
    EXEC sp_InsertHotel @CityID4, 'Shangdu Hotel', 2, 80, 0, 'Satellite television', @HotelID4 OUTPUT;
    EXEC sp_InsertHotel @CityID5, 'Royal Lancaster', 5, 300, 1, 'Laundry, WiFi, Satellite television', @HotelID5 OUTPUT;

    -- Insert TourStops (using correct TourID and CityID)
    DECLARE @TourStopsID1 INT, @TourStopsID2 INT, @TourStopsID3 INT, @TourStopsID4 INT, @TourStopsID5 INT;
    EXEC sp_InsertTourStop @TourID1, @CityID4, 2, @TourStopsID1 OUTPUT;
    EXEC sp_InsertTourStop @TourID2, @CityID1, 3, @TourStopsID2 OUTPUT;
    EXEC sp_InsertTourStop @TourID3, @CityID2, 2, @TourStopsID3 OUTPUT;
    EXEC sp_InsertTourStop @TourID4, @CityID3, 3, @TourStopsID4 OUTPUT;
    EXEC sp_InsertTourStop @TourID5, @CityID5, 4, @TourStopsID5 OUTPUT;

    -- Insert Tourists (ensure correct date format)
    DECLARE @TouristID1 INT, @TouristID2 INT, @TouristID3 INT, @TouristID4 INT, @TouristID5 INT;
    EXEC sp_InsertTourist @TourID1, 'Jane', 'Smith', '1990-07-23', '234-567-8901', @TouristID1 OUTPUT;
    EXEC sp_InsertTourist @TourID2, 'Michael', 'Johnson', '1985-02-15', '345-678-9012', @TouristID2 OUTPUT;
    EXEC sp_InsertTourist @TourID3, 'Emily', 'Davis', '1995-11-09', '456-789-0123', @TouristID3 OUTPUT;
    EXEC sp_InsertTourist @TourID4, 'Daniel', 'Martinez', '1988-06-27', '567-890-1234', @TouristID4 OUTPUT;
    EXEC sp_InsertTourist @TourID5, 'Sophia', 'Brown', '1992-09-12', '678-901-2345', @TouristID5 OUTPUT;

    -- Insert Positions
    DECLARE @PositionID1 INT, @PositionID2 INT, @PositionID3 INT, @PositionID4 INT, @PositionID5 INT;
    EXEC sp_InsertPosition N'ტურ ოპერატორი', N'კლიენტებთან მუშაობა და ტურების მართვა', 2000, @PositionID1 OUTPUT;
    EXEC sp_InsertPosition N'მენეჯერი', N'ტურისტული სააგენტოს მენეჯმენტი', 3500, @PositionID2 OUTPUT;
    EXEC sp_InsertPosition N'ბუღალტერი', N'ფინანსური აღრიცხვა და ბიუჯეტირება', 3000, @PositionID3 OUTPUT;
    EXEC sp_InsertPosition N'გიდი', N'ექსკურსიების ჩატარება', 2500, @PositionID4 OUTPUT;
    EXEC sp_InsertPosition N'IT სპეციალისტი', N'სისტემების ტექნიკური მხარდაჭერა', 3200, @PositionID5 OUTPUT;

    -- Insert Employees
    DECLARE @EmployeeID1 INT, @EmployeeID2 INT, @EmployeeID3 INT, @EmployeeID4 INT, @EmployeeID5 INT;
    EXEC sp_InsertEmployee N'John', N'Doe', 'john.doe@example.com', N'123 Maple Street', N'Apt 4B', @TourID1, '555111222', '1990-04-12', '2024-01-01', @PositionID1, @EmployeeID1 OUTPUT;
    EXEC sp_InsertEmployee N'Sarah', N'Taylor', 'sarah.taylor@example.com', N'456 Oak Avenue', N'Suite 2A', @TourID2, '555222333', '1988-08-20', '2024-02-01', @PositionID2, @EmployeeID2 OUTPUT;
    EXEC sp_InsertEmployee N'Michael', N'Smith', 'michael.smith@example.com', N'789 Pine Road', N'Unit 9', @TourID3, '555333444', '1992-11-05', '2024-03-01', @PositionID3, @EmployeeID3 OUTPUT;
    EXEC sp_InsertEmployee N'Emily', N'Johnson', 'emily.johnson@example.com', N'321 Birch Blvd', N'Floor 3', @TourID4, '555444555', '1995-06-18', '2024-04-01', @PositionID4, @EmployeeID4 OUTPUT;
    EXEC sp_InsertEmployee N'David', N'Williams', 'david.williams@example.com', N'654 Cedar Lane', N'Building B', @TourID5, '555555666', '1987-02-27', '2024-05-01', @PositionID5, @EmployeeID5 OUTPUT;

    -- Insert Users
    DECLARE @UserID1 INT, @UserID2 INT, @UserID3 INT, @UserID4 INT, @UserID5 INT;
    EXEC sp_InsertUser @EmployeeID1, 'admin', 'admin123', 1, @UserID1 OUTPUT;
    EXEC sp_InsertUser @EmployeeID2, 'nino_operator', 'operator123', 2, @UserID2 OUTPUT;
    EXEC sp_InsertUser @EmployeeID3, 'lasha_accountant', 'accountant123', 3, @UserID3 OUTPUT;

    -- Insert Orders 
    DECLARE @OrderID1 INT, @OrderID2 INT, @OrderID3 INT, @OrderID4 INT, @OrderID5 INT;
    EXEC sp_InsertOrder @TouristID1, @TourID2, 15, 1500, 1, '2023-07-14', @OrderID1 OUT;
    EXEC sp_InsertOrder @TouristID2, @TourID1, 10, 2000, 0, '2025-01-30', @OrderID2 OUT;
    EXEC sp_InsertOrder @TouristID3, @TourID3, 17, 2500, 1, '2021-11-08', @OrderID3 OUT;
    EXEC sp_InsertOrder @TouristID4, @TourID5, 18, 2600, 1, '2024-03-27', @OrderID4 OUT;
    EXEC sp_InsertOrder @TouristID5, @TourID4, 17, 3000, 1, '2022-09-19', @OrderID5 OUT;

    RETURN 0;
END;