--[Roles]--
INSERT INTO [dbo].[Roles]([Name])
VALUES
	('�����'),
	('�������'),
	('�������'),
	('�����������'),
	('�������������'),
	('�������')
GO


--[Rights]--
INSERT INTO [dbo].[Rights]([Name])
VALUES
	('����� ����������'),
	('���������'),
	('��������'),
	('�����'),
	('�������'),
	('������� � ��������'),
	('����������'),
	('���������� �������������� ���� ���������'),
	('���������� ���� �����')
GO


--[RolesRights]--
INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	SELECT rl.Id, rght.Id, 0 FROM [dbo].[Rights] rght, [dbo].[Roles] rl WHERE rght.[Name] = '����� ����������'

UPDATE [dbo].[RolesRights] 
	SET [Permission] = 1 
		WHERE 
			[RightsId] = (SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '����� ����������')
		AND 
			[RolesId] = (SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������������')


INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	SELECT rl.Id, rght.Id, 1 FROM [dbo].[Rights] rght, [dbo].[Roles] rl WHERE rght.[Name] = '���������'

DELETE FROM [dbo].[RolesRights] 
	WHERE 
		[RightsId] = (SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '���������')
	AND 
		[RolesId] = (SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�����')


INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '��������'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '��������'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�����������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '�����'),
		0
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '�����'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '�������'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�����������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '������� � ��������'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '������� � ��������'),
		0
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '����������'),
		0
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '����������'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '����������'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '���������� ���� �����'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = '�������'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = '���������� �������������� ���� ���������'),
		1
	)