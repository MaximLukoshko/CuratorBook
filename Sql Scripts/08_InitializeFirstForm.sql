INSERT INTO [dbo].[Controls]([Type]) 
	VALUES
			 ('CtLine') 
			,('CtNumber')
			,('CtCheckbox')
			,('CtTextArrea')
			,('CtDate')
GO



DECLARE @FormName VARCHAR(150)
SELECT @FormName = 'Учёт внеплановых мероприятий'

INSERT INTO [dbo].[Forms]([PageId], [Name]) VALUES(22, @FormName)

DECLARE @FormId INT
SELECT @FormId = (SELECT [Id] FROM [dbo].[Forms] WHERE [Name] = @FormName)

INSERT INTO [dbo].[FormsControls]([FormId], [AnswerId], [ControlId]) 
	VALUES
		 (@FormId, 'Num', 2)
		,(@FormId, 'ActiviType', 1)
		,(@FormId, 'Date', 5)
		,(@FormId, 'Executor', 2)
GO


INSERT INTO [dbo].[Specialities]
           ([Code]
           ,[Name])
     VALUES
           ('КБ'
           ,'Компьютерная безопасность')
GO

INSERT INTO [dbo].[Groups]
           ([Course]
           ,[GroupCode]
           ,[SpecialityId])
     VALUES
           (4
           ,'6+7'
           ,(SELECT [Id] FROM [dbo].[Specialities] WHERE [Name] = 'Компьютерная безопасность'))
GO




