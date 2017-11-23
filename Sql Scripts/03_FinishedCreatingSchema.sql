ALTER TABLE [PagesRights] ADD [RolesId] int NULL;

GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(15) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [RolesRights] (
    [Id] int NOT NULL IDENTITY,
    [Permission] int NOT NULL,
    [RightId] int NOT NULL,
    [RoleId] int NOT NULL,
    CONSTRAINT [PK_RolesRights] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RolesRights_Rights_RightId] FOREIGN KEY ([RightId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(30) NULL,
    [GroupId] int NOT NULL,
    [Login] nvarchar(20) NULL,
    [Password] nvarchar(20) NULL,
    [RoleId] int NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Users_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [Groups] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_PagesRights_RolesId] ON [PagesRights] ([RolesId]);

GO

CREATE INDEX [IX_RolesRights_RightId] ON [RolesRights] ([RightId]);

GO

CREATE INDEX [IX_Users_GroupId] ON [Users] ([GroupId]);

GO

CREATE INDEX [IX_Users_RoleId] ON [Users] ([RoleId]);

GO

ALTER TABLE [PagesRights] ADD CONSTRAINT [FK_PagesRights_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171123175210_FinishedCreatingSchema', N'2.0.1-rtm-125');

GO

