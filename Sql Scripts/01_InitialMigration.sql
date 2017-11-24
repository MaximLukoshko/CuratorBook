IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AnswerRows] (
    [Id] int NOT NULL IDENTITY,
    [FormId] int NOT NULL,
    [GroupId] int NOT NULL,
    [ISHidden] bit NOT NULL,
    [IsFreezed] bit NOT NULL,
    CONSTRAINT [PK_AnswerRows] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Controls] (
    [Id] int NOT NULL IDENTITY,
    [Type] int NOT NULL,
    CONSTRAINT [PK_Controls] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Interviews] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    CONSTRAINT [PK_Interviews] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Pages] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    CONSTRAINT [PK_Pages] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Rights] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    CONSTRAINT [PK_Rights] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(15) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Specialities] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(10) NULL,
    [Name] nvarchar(70) NULL,
    CONSTRAINT [PK_Specialities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AnswerValues] (
    [Id] int NOT NULL IDENTITY,
    [AnswerRowsId] int NOT NULL,
    [ControlId] int NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AnswerValues] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AnswerValues_AnswerRows_AnswerRowsId] FOREIGN KEY ([AnswerRowsId]) REFERENCES [AnswerRows] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Forms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [PageId] int NOT NULL,
    CONSTRAINT [PK_Forms] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Forms_Pages_PageId] FOREIGN KEY ([PageId]) REFERENCES [Pages] ([Id]) ON DELETE CASCADE
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

CREATE TABLE [UsersRights] (
    [Id] int NOT NULL IDENTITY,
    [Permission] int NOT NULL,
    [RightId] int NOT NULL,
    [UserId] int NOT NULL,
    CONSTRAINT [PK_UsersRights] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UsersRights_Rights_RightId] FOREIGN KEY ([RightId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [PagesRights] (
    [Id] int NOT NULL IDENTITY,
    [PageId] int NOT NULL,
    [RightId] int NOT NULL,
    [RolesId] int NULL,
    CONSTRAINT [PK_PagesRights] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PagesRights_Rights_RightId] FOREIGN KEY ([RightId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PagesRights_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Groups] (
    [Id] int NOT NULL IDENTITY,
    [Course] int NOT NULL,
    [GroupCode] nvarchar(10) NULL,
    [SpecialityId] int NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Groups_Specialities_SpecialityId] FOREIGN KEY ([SpecialityId]) REFERENCES [Specialities] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [FormsControls] (
    [Id] int NOT NULL IDENTITY,
    [AnswerId] nvarchar(50) NULL,
    [ControlId] int NOT NULL,
    [FormId] int NOT NULL,
    [FormsId] int NULL,
    CONSTRAINT [PK_FormsControls] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_FormsControls_Controls_ControlId] FOREIGN KEY ([ControlId]) REFERENCES [Controls] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FormsControls_Forms_FormsId] FOREIGN KEY ([FormsId]) REFERENCES [Forms] ([Id]) ON DELETE NO ACTION
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
    CONSTRAINT [FK_Users_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [Groups] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Messages] (
    [Id] int NOT NULL IDENTITY,
    [NotifyViaEmail] bit NOT NULL,
    [ReceiverGroupId] int NULL,
    [ReceiverId] int NULL,
    [SenderId] int NOT NULL,
    [SentDate] datetime2 NOT NULL,
    [Text] nvarchar(max) NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Messages_Groups_ReceiverGroupId] FOREIGN KEY ([ReceiverGroupId]) REFERENCES [Groups] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Messages_Users_ReceiverId] FOREIGN KEY ([ReceiverId]) REFERENCES [Users] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Messages_Users_SenderId] FOREIGN KEY ([SenderId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AnswerValues_AnswerRowsId] ON [AnswerValues] ([AnswerRowsId]);

GO

CREATE INDEX [IX_Forms_PageId] ON [Forms] ([PageId]);

GO

CREATE INDEX [IX_FormsControls_ControlId] ON [FormsControls] ([ControlId]);

GO

CREATE INDEX [IX_FormsControls_FormsId] ON [FormsControls] ([FormsId]);

GO

CREATE INDEX [IX_Groups_SpecialityId] ON [Groups] ([SpecialityId]);

GO

CREATE INDEX [IX_Messages_ReceiverGroupId] ON [Messages] ([ReceiverGroupId]);

GO

CREATE INDEX [IX_Messages_ReceiverId] ON [Messages] ([ReceiverId]);

GO

CREATE INDEX [IX_Messages_SenderId] ON [Messages] ([SenderId]);

GO

CREATE INDEX [IX_PagesRights_RightId] ON [PagesRights] ([RightId]);

GO

CREATE INDEX [IX_PagesRights_RolesId] ON [PagesRights] ([RolesId]);

GO

CREATE INDEX [IX_RolesRights_RightId] ON [RolesRights] ([RightId]);

GO

CREATE INDEX [IX_Users_GroupId] ON [Users] ([GroupId]);

GO

CREATE INDEX [IX_Users_RoleId] ON [Users] ([RoleId]);

GO

CREATE INDEX [IX_UsersRights_RightId] ON [UsersRights] ([RightId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171124200230_CreateSchema', N'2.0.1-rtm-125');

GO

