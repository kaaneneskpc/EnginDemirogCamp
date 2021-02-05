CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] INT NULL, 
    [Description] NCHAR(10) NULL
)
