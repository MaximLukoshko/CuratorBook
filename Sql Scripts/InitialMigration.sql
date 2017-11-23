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

CREATE TABLE [Forms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [PageId] int NOT NULL,
    CONSTRAINT [PK_Forms] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Forms_Pages_PageId] FOREIGN KEY ([PageId]) REFERENCES [Pages] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [FormsControls] (
    [Id] int NOT NULL IDENTITY,
    [AnswerId] nvarchar(50) NULL,
    [ControlId] int NOT NULL,
    [FormId] int NOT NULL,
    CONSTRAINT [PK_FormsControls] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_FormsControls_Controls_ControlId] FOREIGN KEY ([ControlId]) REFERENCES [Controls] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FormsControls_Forms_FormId] FOREIGN KEY ([FormId]) REFERENCES [Forms] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Forms_PageId] ON [Forms] ([PageId]);

GO

CREATE INDEX [IX_FormsControls_ControlId] ON [FormsControls] ([ControlId]);

GO

CREATE INDEX [IX_FormsControls_FormId] ON [FormsControls] ([FormId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171123105407_CreateSchema', N'2.0.1-rtm-125');

GO

