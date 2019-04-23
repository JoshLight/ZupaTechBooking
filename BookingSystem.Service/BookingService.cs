using BookingSystem.DataAccess;
using BookingSystem.Service.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace BookingSystem.Service
{
    [ServiceBehavior(Namespace = "http://zupatech.com/BookingService")]
    public class BookingService : IBookingService
    {
        private readonly IBookingSystemRepository bookingSystemRepository;

        public BookingService(IBookingSystemRepository bookingSystemRepository)
        {
            this.bookingSystemRepository = bookingSystemRepository;
        }

        async Task<Data.Seat[]> IBookingService.GetAvailableSeats(DateTime bookingDate)
            => (await bookingSystemRepository.GetAvailableSeats(bookingDate)).Select(Data.Seat.Create).ToArray();

        async Task IBookingService.MakeBooking(Data.Customer bookingCustomer, DateTime bookingDate, Data.Seat[] seatBookings)
        {
            var customer = await bookingSystemRepository.GetCustomerDetails(bookingCustomer.CustomerName, bookingCustomer.CustomerEmail);

            var seatIds = new List<Guid>();

            foreach (var booking in seatBookings)
            {
                var id = await bookingSystemRepository.GetSeatId(booking.Row, booking.Column);
                if (id.HasValue)
                    seatIds.Add((Guid)id);
            }

            var request = Data.Booking.Create(customer, bookingDate, seatIds);
            await bookingSystemRepository.MakeBookingRequest(request);
        }
    }
}