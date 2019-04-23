using Definitions;

namespace BookingSystem.DataAccess
{
    public partial class Booking : IBooking
    {
        public static Booking Transform(IBooking input)
        {
            return (input != null) ? new Booking
            {
                BookingDate = input.BookingDate,
                CustomerId = input.CustomerId,
                SeatID = input.SeatID
            } : null;
        }
    }
}