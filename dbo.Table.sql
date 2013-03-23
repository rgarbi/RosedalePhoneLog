CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CallerName] VARCHAR(MAX) NULL, 
    [PhoneNumber] NVARCHAR(50) NULL, 
    [Date] DATETIME NULL, 
    [Message] VARCHAR(MAX) NULL, 
    [Employee] VARCHAR(50) NULL, 
    [CallType] NCHAR(10) NULL, 
    [FollowUp] BIT NULL
)
