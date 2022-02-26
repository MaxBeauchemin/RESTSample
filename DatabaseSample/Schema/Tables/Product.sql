CREATE TABLE [dbo].[Product]
(
	[Id]			INT		IDENTITY(1, 1)		NOT NULL,
	[Description]	NVARCHAR(1000)				NOT NULL,
	[CurrentPrice]	DECIMAL(15,2)				NOT NULL
)
GO

ALTER TABLE [dbo].[Product]
ADD CONSTRAINT PK_Product
PRIMARY KEY (Id)
GO