CREATE TABLE [dbo].[Countries]
(
	[CountriesId] INT NOT NULL IDENTITY(1,1),
	[CountryName] NVARCHAR(60) NOT NULL,
	[CountryCode] NVARCHAR(2) NOT NULL,
	PRIMARY KEY (CountriesId) 

)
