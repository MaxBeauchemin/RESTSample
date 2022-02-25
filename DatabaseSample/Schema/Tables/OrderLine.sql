CREATE TABLE [dbo].[OrderLine]
(
	[Id]			INT				NOT NULL		PRIMARY KEY		IDENTITY(1, 1),
	[OrderId]		INT				NOT NULL,
	[ProductId]		INT				NOT NULL,
	[PricePerItem]	DECIMAL			NOT NULL,
	[Quantity]		INT				NOT NULL
)
GO

ALTER TABLE [dbo].[OrderLine]
ADD CONSTRAINT OrderLine_FK_OrderId
FOREIGN KEY (OrderId) REFERENCES [dbo].[Order](Id);
GO

ALTER TABLE [dbo].[OrderLine]
ADD CONSTRAINT OrderLine_FK_ProductId
FOREIGN KEY (ProductId) REFERENCES [dbo].[Product](Id);
GO