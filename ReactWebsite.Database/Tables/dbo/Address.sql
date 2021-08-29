CREATE TABLE [dbo].[Address]
(
	[AddressId] INT NOT NULL IDENTITY,
	[CountryId] INT NOT NULL,
	[StateId] INT NOT NULL,
	[City] VARCHAR(100),
	[Zip] VARCHAR(20),
	[Street] VARCHAR(100),
	CONSTRAINT pkAddressOnAddressId PRIMARY KEY (AddressId),
	CONSTRAINT fkAddressOnCountryCountryId FOREIGN KEY (CountryId) REFERENCES dbo.Country (CountryId),
	CONSTRAINT fkAddressOnStateStateId FOREIGN KEY (StateId) REFERENCES dbo.State (StateId)
)
