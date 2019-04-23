create procedure GetSeatIds @row nvarchar(50), @column nvarchar(50)
as
select Seat.SeatId from Seat
where SeatColumn = @column
and SeatRow = @row