CREATE TABLE [dbo].[Product]
(
	[Id]			INT				NOT NULL		PRIMARY KEY		IDENTITY(1, 1),
	[Description]	NVARCHAR(1000)	NOT NULL,
	[CurrentPrice]	DECIMAL(15,2)	NOT NULL
)
GO
