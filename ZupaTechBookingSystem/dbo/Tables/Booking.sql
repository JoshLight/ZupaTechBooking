CREATE TABLE [dbo].[Booking] (
    [BookingDate] DATE             NOT NULL,
    [SeatID]      UNIQUEIDENTIFIER NOT NULL,
    [CustomerId]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([BookingDate] ASC, [SeatID] ASC)
);

