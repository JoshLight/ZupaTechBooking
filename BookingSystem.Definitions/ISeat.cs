using System;

namespace Definitions
{
    public interface ISeat
    {
        Guid SeatId { get; }
        string Row { get; }
        string Column { get; }
    }
}