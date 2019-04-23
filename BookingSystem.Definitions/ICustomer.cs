using System;

namespace Definitions
{
    public interface ICustomer
    {
        Guid CustomerId { get; }
        string CustomerName { get; }
        string CustomerEmail { get; }
    }
}