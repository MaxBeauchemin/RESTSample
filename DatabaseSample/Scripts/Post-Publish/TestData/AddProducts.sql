PRINT 'Adding Products'
GO

SET IDENTITY_INSERT [dbo].[Product] ON;

INSERT INTO [dbo].[Product] 
					(Id,		Description,										CurrentPrice)

SELECT				1,			'Nvidia GeForce RTX 3090',							1850.00
UNION SELECT		2,			'Tesla Model 3',									39850.00
UNION SELECT		3,			'Nintendo Switch',									300.00
UNION SELECT		4,			'Guitar Hero: Guitar Controller',					50.00
UNION SELECT		5,			'Water Bottle',										3.00
UNION SELECT		6,			'Navy Jeans',										25.00	


SET IDENTITY_INSERT [dbo].[Product] OFF;