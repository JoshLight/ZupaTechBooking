CREATE TABLE [dbo].[Seat] (
    [SeatId]     UNIQUEIDENTIFIER NOT NULL,
    [SeatRow]    NVARCHAR (50)    NOT NULL,
    [SeatColumn] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Seat_1] PRIMARY KEY CLUSTERED ([SeatId] ASC)
);

