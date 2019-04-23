using Definitions;
using System;
using System.Runtime.Serialization;

namespace BookingSystem.Service.Data
{
    [DataContract]
    public class Seat : ISeat
    {
        [DataMember]
        public Guid SeatId { get; set; }

        [DataMember]
        public string Row { get; set; }

        [DataMember]
        public string Column { get; set; }

        internal static Seat Create(ISeat input)
        {
            return input != null ? new Seat
            {
                Column = input.Column,
                Row = input.Row,
                SeatId = input.SeatId
            } : null;
        }
    }
}