DECLARE @pageId INT
SELECT @pageId = 1

DECLARE @rightId INT
SELECT @rightId  =[Id] FROM [dbo].[Rights] WHERE [Name] = 'Общая информация'

WHILE(@pageId < 77)
BEGIN
	INSERT INTO [dbo].[Pages]([Name], [RightsId]) 
	VALUES (CONVERT(VARCHAR(150), @pageId), @rightId)
	SELECT @pageId = @pageId + 1
END

GO

UPDATE [dbo].[Pages] SET [Name] = 'Обложка' WHERE [Id] = 1
UPDATE [dbo].[Pages] SET [Name] = 'Руководство БГУ' WHERE [Id] = 3
UPDATE [dbo].[Pages] SET [Name] = 'Студенческая Ассамблея БГУ' WHERE [Id] = 4
UPDATE [dbo].[Pages] SET [Name] = 'Информация об учебном роцессе группы' WHERE [Id] = 5

UPDATE [dbo].[Pages] SET [Name] = 'Инструкция об организации работы куратора (Общие положения)' WHERE [Id] = 41
UPDATE [dbo].[Pages] SET [Name] = 'Инструкция об организации работы куратора (Обязанности и права куратора)' WHERE [Id] = 42
UPDATE [dbo].[Pages] SET [Name] = 'Инструкция об организации работы куратора (Организация работы куратора студенческой группы)' WHERE [Id] = 43
UPDATE [dbo].[Pages] SET [Name] = 'Положение о кураторе студенческой группы (Общие положения)' WHERE [Id] = 44
UPDATE [dbo].[Pages] SET [Name] = 'Положение о кураторе студенческой группы (Цели задачи и направление деятельности куратора)' WHERE [Id] = 45
UPDATE [dbo].[Pages] SET [Name] = 'Положение о кураторе студенческой группы (Права и обязанности куратора. Начало...)' WHERE [Id] = 46
UPDATE [dbo].[Pages] SET [Name] = 'Положение о кураторе студенческой группы (Права и обязанности куратора. Продлжение...)' WHERE [Id] = 47

UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из правил внутреннего распорядка БГУ (Обязанности обучающихся)' WHERE [Id] = 48
UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из правил внутреннего распорядка БГУ (Дисциплинарная ответственность обучающихся)' WHERE [Id] = 49

UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из положения об оказании материальной помощи (Общие положения. Финансирование)' WHERE [Id] = 50
UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из положения об оказании материальной помощи (Условия оказания материальной помощи)' WHERE [Id] = 51
UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из положения об оказании материальной помощи (Условия оказания материальной помощи. Продолжение...)' WHERE [Id] = 52
UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из положения об оказании материальной помощи (Порядок оказания материальной помощи)' WHERE [Id] = 53
UPDATE [dbo].[Pages] SET [Name] = 'Выдержки из положения об оказании материальной помощи (Порядок оказания материальной помощи. Продолжение)' WHERE [Id] = 54

UPDATE [dbo].[Pages] SET [Name] = 'Заявление об оказании материальной помощи' WHERE [Id] = 55
UPDATE [dbo].[Pages] SET [Name] = 'Заявление об оказании материальной помощи' WHERE [Id] = 56
UPDATE [dbo].[Pages] SET [Name] = 'Заявление об оказании материальной помощи' WHERE [Id] = 57

UPDATE [dbo].[Pages] SET [Name] = 'Выписка из положения о предоставлении скидок со сформированной стоимости обучения' WHERE [Id] = 58
UPDATE [dbo].[Pages] SET [Name] = 'Кодекс Республики Беларусь об образовании' WHERE [Id] = 59

UPDATE [dbo].[Pages] SET [Name] = 'Управление воспитательной работы с молодёжью (УВРМ)' WHERE [Id] = 60
UPDATE [dbo].[Pages] SET [Name] = 'Управление по делам культуры  БГУ (УДК). Психологическая служба БГУ.' WHERE [Id] = 61

UPDATE [dbo].[Pages] SET [Name] = 'Информация о творческом коллективе УДК БГУ' WHERE [Id] = 62
UPDATE [dbo].[Pages] SET [Name] = 'Информация о творческом коллективе УДК БГУ (Продолжение...)' WHERE [Id] = 63
UPDATE [dbo].[Pages] SET [Name] = 'Информация о творческом коллективе УДК БГУ (Продолжение...)' WHERE [Id] = 64
UPDATE [dbo].[Pages] SET [Name] = 'Информация о творческом коллективе УДК БГУ (Продолжение...)' WHERE [Id] = 65

UPDATE [dbo].[Pages] SET [Name] = 'Информация о работе кружков и клубов  Студенческого городка БГУ' WHERE [Id] = 66
UPDATE [dbo].[Pages] SET [Name] = 'Информация о работе кружков и клубов  Студенческого городка БГУ(Продолжение...)' WHERE [Id] = 67

UPDATE [dbo].[Pages] SET [Name] = 'Практические рекоммендации Психологической службы БГУ для составления характеристики студента' WHERE [Id] = 68
UPDATE [dbo].[Pages] SET [Name] = 'Пример характеристики студента' WHERE [Id] = 69
UPDATE [dbo].[Pages] SET [Name] = 'Информация для работы со студентами, имеющими право на государственное обеспечение в БГУ' WHERE [Id] = 70
UPDATE [dbo].[Pages] SET [Name] = 'Государственные праздники и праздничные дни в РБ' WHERE [Id] = 71
UPDATE [dbo].[Pages] SET [Name] = 'Государственные праздники и праздничные дни в РБ (Продолжение...)' WHERE [Id] = 72

UPDATE [dbo].[Pages] SET [Name] = 'Гимн БГУ' WHERE [Id] = 76

GO