CREATE TABLE [dbo].[Customer] (
    [CustomerId]    UNIQUEIDENTIFIER NOT NULL,
    [CustomerName]  NVARCHAR (50)    NOT NULL,
    [CustomerEmail] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Customer_1] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

