--[Roles]--
INSERT INTO [dbo].[Roles]([Name])
VALUES
	('Гость'),
	('Студент'),
	('Куратор'),
	('Проверяющий'),
	('Администратор'),
	('Деканат')
GO


--[Rights]--
INSERT INTO [dbo].[Rights]([Name])
VALUES
	('Общая информация'),
	('Сообщение'),
	('Интервью'),
	('Формы'),
	('Шаблоны'),
	('Отметка о проверке'),
	('Расписание'),
	('Назначение индивидуальных прав студентам'),
	('Назначение прав ролям')
GO


--[RolesRights]--
INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	SELECT rl.Id, rght.Id, 0 FROM [dbo].[Rights] rght, [dbo].[Roles] rl WHERE rght.[Name] = 'Общая информация'

UPDATE [dbo].[RolesRights] 
	SET [Permission] = 1 
		WHERE 
			[RightsId] = (SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Общая информация')
		AND 
			[RolesId] = (SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Администратор')


INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	SELECT rl.Id, rght.Id, 1 FROM [dbo].[Rights] rght, [dbo].[Roles] rl WHERE rght.[Name] = 'Сообщение'

DELETE FROM [dbo].[RolesRights] 
	WHERE 
		[RightsId] = (SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Сообщение')
	AND 
		[RolesId] = (SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Гость')


INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Студент'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Интервью'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Интервью'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Проверяющий'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Формы'),
		0
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Формы'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Шаблоны'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Проверяющий'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Отметка о проверке'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Отметка о проверке'),
		0
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Студент'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Расписание'),
		0
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Деканат'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Расписание'),
		1
	),
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Расписание'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Администратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Назначение прав ролям'),
		1
	)

INSERT INTO [dbo].[RolesRights]([RolesId], [RightsId], [Permission])
	VALUES
	(
		(SELECT rght.Id FROM [dbo].[Roles] rght WHERE rght.[Name] = 'Куратор'),
		(SELECT rght.Id FROM [dbo].[Rights] rght WHERE rght.[Name] = 'Назначение индивидуальных прав студентам'),
		1
	)