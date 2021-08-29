CREATE TABLE [dbo].[Invoice]
(
	[InvoiceId] INT NOT NULL IDENTITY,
	[InvoiceCode] VARCHAR(20) NOT NULL,
	[CustomerId] INT,
	[PersonId] INT,
	CONSTRAINT pkInvoiceOnInvoiceId PRIMARY KEY (InvoiceId),
	CONSTRAINT fkInvoiceOnCustomerCustomerId FOREIGN KEY (CustomerId) REFERENCES dbo.Customer (CustomerId),
	CONSTRAINT fkInvoiceOnPersonPersonId FOREIGN KEY (PersonId) REFERENCES dbo.Person (PersonId)
)