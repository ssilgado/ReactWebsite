CREATE TABLE [dbo].[Country]
(
	[CountryId] INT NOT NULL IDENTITY,
	[Name] VARCHAR(100) NOT NULL,
	CONSTRAINT pkCountryOnCountryId PRIMARY KEY (CountryId)
)
