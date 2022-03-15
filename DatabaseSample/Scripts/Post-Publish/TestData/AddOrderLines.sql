PRINT 'Adding Order Lines'
GO

SET IDENTITY_INSERT [dbo].[OrderLine] ON;

INSERT INTO [dbo].[OrderLine] 
					(Id,	OrderId,	ProductId,		PricePerItem,		Quantity)

SELECT				1,		1,			1,				1250.00,			1
UNION SELECT		2,		2,			1,				1750.00,			2
UNION SELECT		3,		2,			2,				43275.00,			1
UNION SELECT		4,		1,			5,				3.00,				1

SET IDENTITY_INSERT [dbo].[OrderLine] OFF;