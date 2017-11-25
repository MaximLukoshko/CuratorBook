ALTER TABLE [RolesRights] DROP CONSTRAINT [FK_RolesRights_Roles_RolesId];

GO

DROP TABLE [PagesRights];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'RolesRights') AND [c].[name] = N'RolesId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [RolesRights] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [RolesRights] ALTER COLUMN [RolesId] int NULL;

GO

ALTER TABLE [Pages] ADD [RightsId] int NULL;

GO

CREATE INDEX [IX_Pages_RightsId] ON [Pages] ([RightsId]);

GO

ALTER TABLE [Pages] ADD CONSTRAINT [FK_Pages_Rights_RightsId] FOREIGN KEY ([RightsId]) REFERENCES [Rights] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [RolesRights] ADD CONSTRAINT [FK_RolesRights_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171125103204_PagesRightsRemoved', N'2.0.1-rtm-125');

GO

