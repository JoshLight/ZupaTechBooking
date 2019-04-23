using Definitions;
using System;
using System.Runtime.Serialization;

namespace BookingSystem.Service.Data
{
    [DataContract]
    public class Customer : ICustomer
    {
        [DataMember]
        public Guid CustomerId { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; }
    }
}