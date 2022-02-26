CREATE TABLE [dbo].[OrderLine]
(
	[Id]			INT		IDENTITY(1, 1)		NOT NULL,
	[OrderId]		INT							NOT NULL,
	[ProductId]		INT							NOT NULL,
	[PricePerItem]	DECIMAL						NOT NULL,
	[Quantity]		INT							NOT NULL
)
GO

ALTER TABLE [dbo].[OrderLine]
ADD CONSTRAINT PK_OrderLine 
PRIMARY KEY (Id)
GO

ALTER TABLE [dbo].[OrderLine]
ADD CONSTRAINT OrderLine_FK_OrderId
FOREIGN KEY (OrderId) REFERENCES [dbo].[Order](Id);
GO

ALTER TABLE [dbo].[OrderLine]
ADD CONSTRAINT OrderLine_FK_ProductId
FOREIGN KEY (ProductId) REFERENCES [dbo].[Product](Id);
GO