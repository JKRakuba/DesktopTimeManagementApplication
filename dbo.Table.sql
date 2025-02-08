CREATE TABLE [dbo].[Modules]
(
	[ModuleCode] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [ModuleName] VARCHAR(50) NULL, 
    [NumberofCredits] INT NULL, 
    [ClassHoursPerWeek] INT NULL, 
    [NumberofWeeks] INT NULL, 
    [StartDate] DATE NULL
)
