using Definitions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingSystem.DataAccess
{
    public interface IBookingSystemRepository
    {
        Task<ICustomer> GetCustomerDetails(string name, string email);
        Task<IEnumerable<ISeat>> GetAvailableSeats(DateTime bookingDate);
        Task MakeBookingRequest(IEnumerable<IBooking> bookings);
        Task<Guid?> GetSeatId(string seatRow, string seatColumn);
    }
}