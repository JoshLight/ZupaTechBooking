using System;

namespace Definitions
{
    public interface IBooking
    {
        DateTime BookingDate { get; }
        Guid SeatID { get; }
        Guid CustomerId { get; }
    }
}