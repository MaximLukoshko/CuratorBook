CREATE INDEX [IX_UsersRights_UserId] ON [UsersRights] ([UserId]);

GO

CREATE INDEX [IX_RolesRights_RightsId] ON [RolesRights] ([RightsId]);

GO

CREATE INDEX [IX_AnswerRows_FormId] ON [AnswerRows] ([FormId]);

GO

CREATE INDEX [IX_AnswerRows_GroupId] ON [AnswerRows] ([GroupId]);

GO

ALTER TABLE [AnswerRows] ADD CONSTRAINT [FK_AnswerRows_Forms_FormId] FOREIGN KEY ([FormId]) REFERENCES [Forms] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [AnswerRows] ADD CONSTRAINT [FK_AnswerRows_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [Groups] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [RolesRights] ADD CONSTRAINT [FK_RolesRights_Rights_RightsId] FOREIGN KEY ([RightsId]) REFERENCES [Rights] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [UsersRights] ADD CONSTRAINT [FK_UsersRights_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171218215822_03', N'2.0.1-rtm-125');

GO

