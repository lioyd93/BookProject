USE [CoolBooks]
GO

DBCC CHECKIDENT ('Genres', RESEED, 0);
GO

INSERT INTO [dbo].[Genres]
           ([Name]
           ,[Description]
           ,[Created]
           ,[IsDeleted])
     VALUES
           ('Comedy','Comedy','20170926',0),
		   ('Drama','Drama','20170926',0),
		   ('Horror','Horror','20170926',0),
		   ('Realistic','Realistic','20170926',0),
		   ('Romantic','Romantic','20170926',0),
		   ('Satire','Satire','20170926',0),
		   ('Tragedy','Tragedy','20170926',0),
		   ('Fantasy','Fantasy','20170926',0),
		   ('Crime','Crime','20170926',0),
		   ('Science Fiction','Science Fiction','20170926',0),
		   ('Classic','Classic','20170926',0),
		   ('Thriller','Thriller','20170926',0),
		   ('Mystery','Mystery','20170926',0),
		   ('Biography','Biography','20170926',0),
		   ('Memoir','Memoir','20170926',0)
GO


