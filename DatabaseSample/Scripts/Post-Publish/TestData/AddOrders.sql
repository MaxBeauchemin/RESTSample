PRINT 'Adding Orders'
GO

SET IDENTITY_INSERT [dbo].[Order] ON;

INSERT INTO [dbo].[Order] 
					(Id,	OrderNumber,	CustomerId,		[Status],		CreatedDateTime,	CompletedDateTime)

SELECT				1,		'9284028402',	1,				'Completed',	GETDATE(),			GETDATE()
UNION SELECT		2,		'1828402372',	1,				'Processing',	GETDATE(),			NULL

SET IDENTITY_INSERT [dbo].[Order] OFF;