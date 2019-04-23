using BookingSystem.Service.Data;
using Definitions;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace BookingSystem.Service.Operations
{
    [ServiceContract(Name = "Booking Service", ConfigurationName = "BookingService", Namespace = "http://zupatech.com/BookingService")]
    public interface IBookingService
    {
        [OperationContract]
        Task<Data.Seat[]> GetAvailableSeats(DateTime bookingDate);
        [OperationContract]
        Task MakeBooking(Customer bookingCustomer, DateTime bookingDate, Seat[] seatBookings);
    }
}