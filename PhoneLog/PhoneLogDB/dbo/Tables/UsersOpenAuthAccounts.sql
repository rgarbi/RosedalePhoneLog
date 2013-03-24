CREATE TABLE [dbo].[UsersOpenAuthAccounts] (
    [ApplicationName]    NVARCHAR (128) NOT NULL,
    [ProviderName]       NVARCHAR (128) NOT NULL,
    [ProviderUserId]     NVARCHAR (128) NOT NULL,
    [ProviderUserName]   NVARCHAR (MAX) NOT NULL,
    [MembershipUserName] NVARCHAR (128) NOT NULL,
    [LastUsedUtc]        DATETIME       NULL,
    CONSTRAINT [PK_dbo.UsersOpenAuthAccounts] PRIMARY KEY CLUSTERED ([ApplicationName] ASC, [ProviderName] ASC, [ProviderUserId] ASC),
    CONSTRAINT [FK_dbo.UsersOpenAuthAccounts_dbo.UsersOpenAuthData_ApplicationName_MembershipUserName] FOREIGN KEY ([ApplicationName], [MembershipUserName]) REFERENCES [dbo].[UsersOpenAuthData] ([ApplicationName], [MembershipUserName]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ApplicationName_MembershipUserName]
    ON [dbo].[UsersOpenAuthAccounts]([ApplicationName] ASC, [MembershipUserName] ASC);

