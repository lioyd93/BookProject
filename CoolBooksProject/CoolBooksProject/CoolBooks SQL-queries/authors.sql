USE [CoolBooks]
GO

DBCC CHECKIDENT ('Authors', RESEED, 0);
GO

INSERT INTO [dbo].[Authors]
           ([FirstName]
           ,[LastName]
           ,[Created]
           ,[IsDeleted])
     VALUES
           ('George','Orwell','20170926',0),
		   ('Fyodor','Dostoevsky','20170926',0),
		   ('Milan','Kundera','20170926',0),
		   ('Franz','Kafka','20170926',0)
GO


