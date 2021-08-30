CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL IDENTITY,
	[PersonCode] VARCHAR(20) NOT NULL UNIQUE,
	[Name] VARCHAR(100),
	[AddressId] INT,
	CONSTRAINT pkPersonOnPersonId PRIMARY KEY (PersonId),
	CONSTRAINT fkPersonOnAddressAddressId FOREIGN KEY (AddressId) REFERENCES dbo.Address (AddressId)
)
