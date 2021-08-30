CREATE TABLE [dbo].[Email]
(
	[EmailId] INT NOT NULL IDENTITY,
	[PersonId] INT,
	[emailAddress] VARCHAR(100),
	CONSTRAINT pkEmailOnEmailId PRIMARY KEY (EmailId),
	CONSTRAINT fkEmailOnPersonPersonId FOREIGN KEY (PersonId) REFERENCES dbo.Person (PersonId)
)
