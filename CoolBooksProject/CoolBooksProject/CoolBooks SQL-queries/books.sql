USE [CoolBooks]
GO

INSERT INTO [dbo].[Books]
           ([UserId]
           ,[AuthorId]
           ,[GenreId]
           ,[Title]
           ,[Description]
           ,[ISBN]
           ,[PublishDate]
           ,[Created]
           ,[IsDeleted])
     VALUES
           ('c2d8fc5a-9218-42be-ba0e-2dcef8621649',1,10,'1984','The year 1984 has come and gone, but George Orwell''s prophetic, nightmarish vision in 1949 of the world we were becoming is timelier than ever. 1984 is still the great modern classic of negative utopia -a startlingly original and haunting novel that creates an imaginary world that is completely convincing, from the first sentence to the last four words. No one can deny the novel''s hold on the imaginations of whole generations, or the power of its admonitions -a power that seems to grow, not lessen, with the passage of time.',
           '0451524934','19490608','20170926',0),

		   ('c2d8fc5a-9218-42be-ba0e-2dcef8621649',2,11,'Crime and Punishment','Through the story of the brilliant but conflicted young Raskolnikov and the murder he commits, Fyodor Dostoevsky explores the theme of redemption through suffering. Crime and Punishment put Dostoevsky at the forefront of Russian writers when it appeared in 1866 and is now one of the most famous and influential novels in world literature.',
           '0143058142','18660101','20170926',0),

		   ('c2d8fc5a-9218-42be-ba0e-2dcef8621649',3,11,'The Unbearable Lightness of Being',
		   'In The Unbearable Lightness of Being, Milan Kundera tells the story of a young woman in love with a man torn between his love for her and his incorrigible womanizing and one of his mistresses and her humbly faithful lover. This magnificent novel juxtaposes geographically distant places, brilliant and playful reflections, and a variety of styles to take its place as perhaps the major achievement of one of the world’s truly great writers.',
           '0571224385','19840101','20170926',0),

		   ('c2d8fc5a-9218-42be-ba0e-2dcef8621649',4,11,'The Trial',
		   'Written in 1914 but not published until 1925, a year after Kafka’s death, The Trial is the terrifying tale of Josef K., a respectable bank officer who is suddenly and inexplicably arrested and must defend himself against a charge about which he can get no information. Whether read as an existential tale, a parable, or a prophecy of the excesses of modern bureaucracy wedded to the madness of totalitarianism, The Trial has resonated with chilling truth for generations of readers.',
           '0099428644','19250426','20170926',0)
GO


