IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Controls] (
    [Id] int NOT NULL IDENTITY,
    [Type] int NOT NULL,
    CONSTRAINT [PK_Controls] PRIMARY KEY ([Id])
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

CREATE TABLE [Forms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [PageId] int NOT NULL,
    CONSTRAINT [PK_Forms] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Forms_Pages_PageId] FOREIGN KEY ([PageId]) REFERENCES [Pages] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [PagesRights] (
    [Id] int NOT NULL IDENTITY,
    [PageId] int NOT NULL,
    [RightId] int NOT NULL,
    CONSTRAINT [PK_PagesRights] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PagesRights_Rights_RightId] FOREIGN KEY ([RightId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE
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

CREATE INDEX [IX_Forms_PageId] ON [Forms] ([PageId]);

GO

CREATE INDEX [IX_FormsControls_ControlId] ON [FormsControls] ([ControlId]);

GO

CREATE INDEX [IX_FormsControls_FormsId] ON [FormsControls] ([FormsId]);

GO

CREATE INDEX [IX_PagesRights_RightId] ON [PagesRights] ([RightId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171123120012_Initial-Migration', N'2.0.1-rtm-125');

GO

