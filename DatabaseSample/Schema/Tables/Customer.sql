﻿CREATE TABLE [dbo].[Customer]
(
	[Id]			INT				NOT NULL		PRIMARY KEY		IDENTITY(1, 1),
	[FirstName]		NVARCHAR(100)	NOT NULL,
	[LastName]		NVARCHAR(100)	NOT NULL,
	[EmailAddress]	NVARCHAR(250)	NULL,
	[PhoneNumber]	NVARCHAR(30)	NULL
)
GO
