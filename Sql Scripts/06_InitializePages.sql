DECLARE @pageId INT
SELECT @pageId = 1

DECLARE @rightId INT
SELECT @rightId  =[Id] FROM [dbo].[Rights] WHERE [Name] = '����� ����������'

WHILE(@pageId < 77)
BEGIN
	INSERT INTO [dbo].[Pages]([Name], [RightsId]) 
	VALUES (CONVERT(VARCHAR(150), @pageId), @rightId)
	SELECT @pageId = @pageId + 1
END

GO

UPDATE [dbo].[Pages] SET [Name] = '�������' WHERE [Id] = 1
UPDATE [dbo].[Pages] SET [Name] = '����������� ���' WHERE [Id] = 3
UPDATE [dbo].[Pages] SET [Name] = '������������ ��������� ���' WHERE [Id] = 4
UPDATE [dbo].[Pages] SET [Name] = '���������� �� ������� ������� ������' WHERE [Id] = 5

UPDATE [dbo].[Pages] SET [Name] = '���������� �� ����������� ������ �������� (����� ���������)' WHERE [Id] = 41
UPDATE [dbo].[Pages] SET [Name] = '���������� �� ����������� ������ �������� (����������� � ����� ��������)' WHERE [Id] = 42
UPDATE [dbo].[Pages] SET [Name] = '���������� �� ����������� ������ �������� (����������� ������ �������� ������������ ������)' WHERE [Id] = 43
UPDATE [dbo].[Pages] SET [Name] = '��������� � �������� ������������ ������ (����� ���������)' WHERE [Id] = 44
UPDATE [dbo].[Pages] SET [Name] = '��������� � �������� ������������ ������ (���� ������ � ����������� ������������ ��������)' WHERE [Id] = 45
UPDATE [dbo].[Pages] SET [Name] = '��������� � �������� ������������ ������ (����� � ����������� ��������. ������...)' WHERE [Id] = 46
UPDATE [dbo].[Pages] SET [Name] = '��������� � �������� ������������ ������ (����� � ����������� ��������. ����������...)' WHERE [Id] = 47

UPDATE [dbo].[Pages] SET [Name] = '�������� �� ������ ����������� ���������� ��� (����������� �����������)' WHERE [Id] = 48
UPDATE [dbo].[Pages] SET [Name] = '�������� �� ������ ����������� ���������� ��� (�������������� ��������������� �����������)' WHERE [Id] = 49

UPDATE [dbo].[Pages] SET [Name] = '�������� �� ��������� �� �������� ������������ ������ (����� ���������. ��������������)' WHERE [Id] = 50
UPDATE [dbo].[Pages] SET [Name] = '�������� �� ��������� �� �������� ������������ ������ (������� �������� ������������ ������)' WHERE [Id] = 51
UPDATE [dbo].[Pages] SET [Name] = '�������� �� ��������� �� �������� ������������ ������ (������� �������� ������������ ������. �����������...)' WHERE [Id] = 52
UPDATE [dbo].[Pages] SET [Name] = '�������� �� ��������� �� �������� ������������ ������ (������� �������� ������������ ������)' WHERE [Id] = 53
UPDATE [dbo].[Pages] SET [Name] = '�������� �� ��������� �� �������� ������������ ������ (������� �������� ������������ ������. �����������)' WHERE [Id] = 54

UPDATE [dbo].[Pages] SET [Name] = '��������� �� �������� ������������ ������' WHERE [Id] = 55
UPDATE [dbo].[Pages] SET [Name] = '��������� �� �������� ������������ ������' WHERE [Id] = 56
UPDATE [dbo].[Pages] SET [Name] = '��������� �� �������� ������������ ������' WHERE [Id] = 57

UPDATE [dbo].[Pages] SET [Name] = '������� �� ��������� � �������������� ������ �� �������������� ��������� ��������' WHERE [Id] = 58
UPDATE [dbo].[Pages] SET [Name] = '������ ���������� �������� �� �����������' WHERE [Id] = 59

UPDATE [dbo].[Pages] SET [Name] = '���������� �������������� ������ � �������� (����)' WHERE [Id] = 60
UPDATE [dbo].[Pages] SET [Name] = '���������� �� ����� ��������  ��� (���). ��������������� ������ ���.' WHERE [Id] = 61

UPDATE [dbo].[Pages] SET [Name] = '���������� � ���������� ���������� ��� ���' WHERE [Id] = 62
UPDATE [dbo].[Pages] SET [Name] = '���������� � ���������� ���������� ��� ��� (�����������...)' WHERE [Id] = 63
UPDATE [dbo].[Pages] SET [Name] = '���������� � ���������� ���������� ��� ��� (�����������...)' WHERE [Id] = 64
UPDATE [dbo].[Pages] SET [Name] = '���������� � ���������� ���������� ��� ��� (�����������...)' WHERE [Id] = 65

UPDATE [dbo].[Pages] SET [Name] = '���������� � ������ ������� � ������  ������������� ������� ���' WHERE [Id] = 66
UPDATE [dbo].[Pages] SET [Name] = '���������� � ������ ������� � ������  ������������� ������� ���(�����������...)' WHERE [Id] = 67

UPDATE [dbo].[Pages] SET [Name] = '������������ ������������� ��������������� ������ ��� ��� ����������� �������������� ��������' WHERE [Id] = 68
UPDATE [dbo].[Pages] SET [Name] = '������ �������������� ��������' WHERE [Id] = 69
UPDATE [dbo].[Pages] SET [Name] = '���������� ��� ������ �� ����������, �������� ����� �� ��������������� ����������� � ���' WHERE [Id] = 70
UPDATE [dbo].[Pages] SET [Name] = '��������������� ��������� � ����������� ��� � ��' WHERE [Id] = 71
UPDATE [dbo].[Pages] SET [Name] = '��������������� ��������� � ����������� ��� � �� (�����������...)' WHERE [Id] = 72

UPDATE [dbo].[Pages] SET [Name] = '���� ���' WHERE [Id] = 76

GO