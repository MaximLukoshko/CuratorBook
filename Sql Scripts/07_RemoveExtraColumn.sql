ALTER TABLE [FormsControls] DROP CONSTRAINT [FK_FormsControls_Forms_FormsId];

GO

DROP INDEX [IX_FormsControls_FormsId] ON [FormsControls];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'FormsControls') AND [c].[name] = N'FormsId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [FormsControls] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [FormsControls] DROP COLUMN [FormsId];

GO

CREATE INDEX [IX_FormsControls_FormId] ON [FormsControls] ([FormId]);

GO

ALTER TABLE [FormsControls] ADD CONSTRAINT [FK_FormsControls_Forms_FormId] FOREIGN KEY ([FormId]) REFERENCES [Forms] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171209184033_RemoveExtraColumn', N'2.0.1-rtm-125');

GO

-------------------------------------------

CREATE INDEX [IX_AnswerValues_ControlId] ON [AnswerValues] ([ControlId]);

GO

ALTER TABLE [AnswerValues] ADD CONSTRAINT [FK_AnswerValues_FormsControls_ControlId] FOREIGN KEY ([ControlId]) REFERENCES [FormsControls] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171209190906_01', N'2.0.1-rtm-125');

GO

------------------------------------------------------------

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'Controls') AND [c].[name] = N'Type');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Controls] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Controls] ALTER COLUMN [Type] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171209191343_02', N'2.0.1-rtm-125');

GO

