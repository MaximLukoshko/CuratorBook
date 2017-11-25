ALTER TABLE [PagesRights] DROP CONSTRAINT [FK_PagesRights_Roles_RolesId];

GO

ALTER TABLE [RolesRights] DROP CONSTRAINT [FK_RolesRights_Rights_RightId];

GO

ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Groups_GroupId];

GO

DROP INDEX [IX_PagesRights_RolesId] ON [PagesRights];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'PagesRights') AND [c].[name] = N'RolesId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [PagesRights] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [PagesRights] DROP COLUMN [RolesId];

GO

EXEC sp_rename N'RolesRights.RoleId', N'RolesId', N'COLUMN';

GO

EXEC sp_rename N'RolesRights.RightId', N'RightsId', N'COLUMN';

GO

EXEC sp_rename N'RolesRights.IX_RolesRights_RightId', N'IX_RolesRights_RightsId', N'INDEX';

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'Users') AND [c].[name] = N'GroupId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Users] ALTER COLUMN [GroupId] int NULL;

GO

CREATE INDEX [IX_RolesRights_RolesId] ON [RolesRights] ([RolesId]);

GO

CREATE INDEX [IX_PagesRights_PageId] ON [PagesRights] ([PageId]);

GO

ALTER TABLE [PagesRights] ADD CONSTRAINT [FK_PagesRights_Pages_PageId] FOREIGN KEY ([PageId]) REFERENCES [Pages] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [RolesRights] ADD CONSTRAINT [FK_RolesRights_Rights_RightsId] FOREIGN KEY ([RightsId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [RolesRights] ADD CONSTRAINT [FK_RolesRights_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [Groups] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171124204003_RemovedUnusedColumn', N'2.0.1-rtm-125');

GO

