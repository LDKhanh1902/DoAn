-- Tạo bảng Khách hàng
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255),
    Password NVARCHAR(255)
);

-- Tạo bảng Sân bay
CREATE TABLE Airports (
    AirportID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    City NVARCHAR(100),
    Country NVARCHAR(100)
);

-- Tạo bảng Hãng hàng không
CREATE TABLE Airlines (
    AirlineID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Logo NVARCHAR(255) -- Đường dẫn tới file logo
);

-- Tạo bảng Chuyến bay
CREATE TABLE Flights (
    FlightID INT PRIMARY KEY IDENTITY,
    FlightCode NVARCHAR(20),
    DepartureTime DATETIME,
    ArrivalTime DATETIME,
    DepartureAirportID INT,
    ArrivalAirportID INT,
    AirlineID INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (DepartureAirportID) REFERENCES Airports(AirportID),
    FOREIGN KEY (ArrivalAirportID) REFERENCES Airports(AirportID),
    FOREIGN KEY (AirlineID) REFERENCES Airlines(AirlineID)
);

-- Tạo bảng Hạng ghế
CREATE TABLE SeatClasses (
    SeatClassID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Description NVARCHAR(255)
);

-- Tạo bảng Đặt chỗ
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY,
    CustomerID INT,
    FlightID INT,
    BookingDate DATETIME,
    Status NVARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID)
);

-- Tạo bảng Vé
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY IDENTITY,
    BookingID INT,
    SeatNumber NVARCHAR(10),
    SeatClassID INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID),
    FOREIGN KEY (SeatClassID) REFERENCES SeatClasses(SeatClassID)
);

-- Tạo bảng Thanh toán
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY,
    BookingID INT,
    Amount DECIMAL(10, 2),
    PaymentMethod NVARCHAR(50),
    PaymentDate DATETIME,
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
);
