-- Chèn dữ liệu vào bảng Khách hàng
INSERT INTO Customers (FullName, Email, PhoneNumber, Address, Password) VALUES
('Nguyen Van A', 'nguyenvana@example.com', '0123456789', '123 Đường ABC, Quận 1, TP.HCM', 'password123'),
('Tran Thi B', 'tranthib@example.com', '0987654321', '456 Đường XYZ, Quận 2, TP.HCM', 'password456');

-- Chèn dữ liệu vào bảng Sân bay
INSERT INTO Airports (Name, City, Country) VALUES
('Tan Son Nhat International Airport', 'Ho Chi Minh City', 'Vietnam'),
('Noi Bai International Airport', 'Hanoi', 'Vietnam');

-- Chèn dữ liệu vào bảng Hãng hàng không
INSERT INTO Airlines (Name, Logo) VALUES
('Vietnam Airlines', 'logo_vietnamairlines.png'),
('Bamboo Airways', 'logo_bambooairways.png');

-- Chèn dữ liệu vào bảng Chuyến bay
INSERT INTO Flights (FlightCode, DepartureTime, ArrivalTime, DepartureAirportID, ArrivalAirportID, AirlineID, Price) VALUES
('VN123', '2024-06-20 08:00:00', '2024-06-20 10:00:00', 1, 2, 1, 1500000),
('QH456', '2024-06-20 09:00:00', '2024-06-20 11:00:00', 2, 1, 2, 1200000);

-- Chèn dữ liệu vào bảng Hạng ghế
INSERT INTO SeatClasses (Name, Description) VALUES
('Economy Class', 'Ghế hạng phổ thông'),
('Business Class', 'Ghế hạng thương gia');

-- Chèn dữ liệu vào bảng Đặt chỗ
INSERT INTO Bookings (CustomerID, FlightID, BookingDate, Status) VALUES
(1, 1, GETDATE(), 'Confirmed'),
(2, 2, GETDATE(), 'Confirmed');

-- Chèn dữ liệu vào bảng Vé
INSERT INTO Tickets (BookingID, SeatNumber, SeatClassID, Price) VALUES
(1, '12A', 1, 1500000),
(2, '3C', 2, 3000000);

-- Chèn dữ liệu vào bảng Thanh toán
INSERT INTO Payments (BookingID, Amount, PaymentMethod, PaymentDate) VALUES
(1, 1500000, 'Credit Card', GETDATE()),
(2, 3000000, 'Bank Transfer', GETDATE());
