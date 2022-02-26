CREATE TABLE [dbo].[Customer]
(
	[Id]			INT		IDENTITY(1, 1)	NOT NULL,
	[FirstName]		NVARCHAR(100)			NOT NULL,
	[LastName]		NVARCHAR(100)			NOT NULL,
	[EmailAddress]	NVARCHAR(250)			NULL,
	[PhoneNumber]	NVARCHAR(30)			NULL
)
GO

ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT PK_Customer 
PRIMARY KEY (Id)
GO