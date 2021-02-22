CREATE TABLE [dbo].[TechStacks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] NCHAR(10) NOT NULL, 
    [UsedBefore] BIT NOT NULL, 
    [Proficiency] INT NOT NULL, 
    [FavAttribute] NCHAR(10) NOT NULL
)
