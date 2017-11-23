CREATE TABLE [Answers] (
    [Id] int NOT NULL IDENTITY,
    [FormId] int NOT NULL,
    [GroupId] int NOT NULL,
    [ISHidden] bit NOT NULL,
    [IsFreezed] bit NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_Answers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Specialities] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(10) NULL,
    [Name] nvarchar(70) NULL,
    CONSTRAINT [PK_Specialities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Groups] (
    [Id] int NOT NULL IDENTITY,
    [Course] int NOT NULL,
    [GroupCode] nvarchar(10) NULL,
    [SpecialityId] int NOT NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Groups_Specialities_SpecialityId] FOREIGN KEY ([SpecialityId]) REFERENCES [Specialities] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Groups_SpecialityId] ON [Groups] ([SpecialityId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171123133052_GroupsAndAnswersAdded', N'2.0.1-rtm-125');

GO

