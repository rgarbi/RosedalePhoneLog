CREATE TABLE [dbo].[UsersOpenAuthData] (
    [ApplicationName]    NVARCHAR (128) NOT NULL,
    [MembershipUserName] NVARCHAR (128) NOT NULL,
    [HasLocalPassword]   BIT            NOT NULL,
    CONSTRAINT [PK_dbo.UsersOpenAuthData] PRIMARY KEY CLUSTERED ([ApplicationName] ASC, [MembershipUserName] ASC)
);

