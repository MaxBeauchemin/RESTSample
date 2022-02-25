PRINT 'Adding Customers'
GO

SET IDENTITY_INSERT [dbo].[Customer] ON;

INSERT INTO [dbo].[Customer] 
					(Id,	FirstName,		LastName,			EmailAddress,			PhoneNumber)

SELECT				1,	'Greg',			'Lakovitch',		'g.lokovitch@gmail.com',	NULL
UNION SELECT		2,	'Phil',			'Smith',			NULL,						'512-555-6928'

SET IDENTITY_INSERT [dbo].[Customer] OFF;