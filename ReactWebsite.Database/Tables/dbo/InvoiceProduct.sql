CREATE TABLE [dbo].[InvoiceProduct]
(
	[InvoiceProductId] INT NOT NULL IDENTITY,
	[EquipmentUnits] INT,
	[BillableHours] DECIMAL(18,4),
	[StartDate] DATETIME,
	[EndDate] DATETIME,
	[InvoiceId] INT,
	[ProductId] INT,
	CONSTRAINT pkInvoiceProductOnInvoiceProductId PRIMARY KEY (InvoiceProductId),
	CONSTRAINT fkInvoiceProductOnInvoiceInvoiceId FOREIGN KEY (InvoiceId) REFERENCES dbo.Invoice (InvoiceId),
	CONSTRAINT fkInvoiceProductOnProductProductId FOREIGN KEY (ProductId) REFERENCES dbo.Product (ProductId),
	CONSTRAINT uqInvoiceIdOnProductId UNIQUE (InvoiceId, ProductId)
)
