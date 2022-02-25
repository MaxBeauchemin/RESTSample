PRINT 'Adding Products'
GO

SET IDENTITY_INSERT [dbo].[Product] ON;

INSERT INTO [dbo].[Product] 
					(Id,		Description,										CurrentPrice)

SELECT				1,			'Nvidia GeForce RTX 3090',							1850.00
UNION SELECT		2,			'Tesla Model 3',									39850.00

SET IDENTITY_INSERT [dbo].[Product] OFF;