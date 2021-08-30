CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL IDENTITY,
	[CustomerCode] VARCHAR(20) NOT NULL UNIQUE,
	[Name] VARCHAR(100),
	[Type] VARCHAR(1),
	[PersonId] INT,
	[AddressId] INT,
	CONSTRAINT pkCustomerOnCustomerId PRIMARY KEY (CustomerId),
	CONSTRAINT fkCustomerOnPersonPersonId FOREIGN KEY (PersonId) REFERENCES dbo.Person (PersonId),
	CONSTRAINT fkCustomerOnAddressAddressId FOREIGN KEY (AddressId) REFERENCES dbo.Address (AddressId)
)
