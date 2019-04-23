using Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem.DataAccess
{
    public class BookingSystemRepository : IBookingSystemRepository
    {
        private string connectionString;

        public BookingSystemRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private BookingSystemEntities GetDbContext() => new BookingSystemEntities();

        private async Task<TResult> ExecuteFakeAsync<TResult>(Func<BookingSystemEntities, TResult> procedure)
        {
            using (var db = GetDbContext())
                return await Task.Run(() => procedure(db));
        }

        async Task<IEnumerable<ISeat>> IBookingSystemRepository.GetAvailableSeats(DateTime bookingDate)
            => await ExecuteFakeAsync(db => db.GetAvailableSeats(bookingDate).ToList());

        async Task<ICustomer> IBookingSystemRepository.GetCustomerDetails(string name, string email)
            => await ExecuteFakeAsync(db => db.GetCustomerDetails(name, email).FirstOrDefault());

        async Task IBookingSystemRepository.MakeBookingRequest(IEnumerable<IBooking> bookings)
        {
            using (var db = GetDbContext())
            {
                foreach (var booking in bookings)
                {
                    db.Bookings.Add(Booking.Transform(booking));
                }
                await db.SaveChangesAsync();
            }
        }

        async Task<Guid?> IBookingSystemRepository.GetSeatId(string seatRow, string seatColumn)
            => await ExecuteFakeAsync(db => db.GetSeatIds(seatRow, seatColumn).FirstOrDefault());


    }
}