using Definitions;

namespace BookingSystem.DataAccess
{
    public partial class GetAvailableSeats_Result : ISeat
    {
        public string Row => SeatRow;
        public string Column => SeatColumn;
    }
}