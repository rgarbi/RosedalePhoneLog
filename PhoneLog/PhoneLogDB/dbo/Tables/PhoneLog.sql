CREATE TABLE [dbo].[PhoneLog] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [CallerName]    NVARCHAR (MAX) NULL,
    [CallDate]      DATETIME2 (7)  NULL,
    [PhoneNumber]   NVARCHAR (50)  NULL,
    [Message]       NVARCHAR (MAX) NULL,
    [FollowedUp]    BIT            NULL,
    [EmployeeEmail] NVARCHAR (MAX) NULL,
    [CallType]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

