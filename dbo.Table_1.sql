CREATE TABLE [dbo].[Table]
(
	[Email] TEXT NOT NULL PRIMARY KEY, 
    [Name] TEXT NOT NULL, 
    [Surname] TEXT NOT NULL, 
    [Password] TEXT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Email])
)
