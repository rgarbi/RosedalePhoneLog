CREATE TABLE [dbo].[Employee] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeName]  NVARCHAR (MAX) NULL,
    [EmployeeEmail] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

