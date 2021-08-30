CREATE TABLE [dbo].[Product]
(
	[ProductId] INT NOT NULL IDENTITY,
	[ProductCode] VARCHAR(20) NOT NULL UNIQUE,
	[Name] VARCHAR(200),
	[Type] VARCHAR(1) NOT NULL,
	[PricePerUnit] DECIMAL(18,4),
	[PricePerHour] DECIMAL(18,4),
	[AnnualFee] DECIMAL(18,4),
	[ServiceFee] DECIMAL(18,4),
	[ConsultantId] INT,
	CONSTRAINT pkProductOnProductId PRIMARY KEY (ProductId),
	CONSTRAINT fkProductOnPersonPersonId FOREIGN KEY (ConsultantId) REFERENCES dbo.Person (PersonId)
)
