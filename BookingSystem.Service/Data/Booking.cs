using Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace BookingSystem.Service.Data
{
    [DataContract]
    public class Booking : IBooking
    {
        [DataMember]
        public Guid SeatID { get; set; }
        [DataMember]
        public Guid CustomerId { get; set; }
        [DataMember]
        public DateTime BookingDate { get; set; }
        internal static Booking[] Create(ICustomer bookingCustomer, DateTime bookingDate, IEnumerable<Guid> seatsIds)
        {
            if (bookingCustomer == null || bookingDate == null)
                return null;

            if (seatsIds.Count() > 4)
                return null;

            var bookings = new Booking[seatsIds.Count()];

            for(var i = 0; i < seatsIds.Count(); i++)
            {
                bookings[i] = new Booking
                {
                    BookingDate = bookingDate,
                    CustomerId = bookingCustomer.CustomerId,
                    SeatID = seatsIds.ElementAt(i)
                };

            }
            return bookings;            
        }
    }
}