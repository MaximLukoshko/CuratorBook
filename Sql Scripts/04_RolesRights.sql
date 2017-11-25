ALTER TABLE [RolesRights] DROP CONSTRAINT [FK_RolesRights_Rights_RightsId];

GO

ALTER TABLE [RolesRights] DROP CONSTRAINT [FK_RolesRights_Roles_RolesId];

GO

DROP INDEX [IX_RolesRights_RightsId] ON [RolesRights];

GO

DROP INDEX [IX_RolesRights_RolesId] ON [RolesRights];
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'RolesRights') AND [c].[name] = N'RolesId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [RolesRights] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [RolesRights] ALTER COLUMN [RolesId] int NOT NULL;
CREATE INDEX [IX_RolesRights_RolesId] ON [RolesRights] ([RolesId]);

GO

ALTER TABLE [RolesRights] ADD CONSTRAINT [FK_RolesRights_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171125115527_RolesRights', N'2.0.1-rtm-125');

GO

