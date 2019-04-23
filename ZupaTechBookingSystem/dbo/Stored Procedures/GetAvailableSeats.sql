CREATE PROCEDURE GetAvailableSeats @BookingDate Date
AS
SELECT SeatId, SeatRow, SeatColumn FROM Seat
WHERE SeatID NOT IN (SELECT SeatId FROM Booking WHERE BookingDate = @BookingDate)