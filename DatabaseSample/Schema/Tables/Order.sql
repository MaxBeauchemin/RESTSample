CREATE TABLE [dbo].[Order]
(
	[Id]				INT				NOT NULL		PRIMARY KEY		IDENTITY(1, 1),
	[OrderNumber]		NVARCHAR(25)	NOT NULL,
	[CustomerId]		INT				NOT NULL,
	[Status]			NVARCHAR(25)	NOT NULL,
	[CreatedDateTime]	DATETIME		NOT NULL,
	[CompletedDateTime]	DATETIME		NULL
)
GO

ALTER TABLE [dbo].[Order]
ADD CONSTRAINT Order_FK_CustomerId
FOREIGN KEY (CustomerId) REFERENCES Customer(Id);
GO
