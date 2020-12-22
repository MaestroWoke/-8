CREATE TABLE [dbo].[Table]
(
    [Email] TEXT NOT NULL, 
    [Name] NCHAR(10) NOT NULL, 
    [Surname] TEXT NOT NULL, 
    [Password] TEXT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Email])
)
