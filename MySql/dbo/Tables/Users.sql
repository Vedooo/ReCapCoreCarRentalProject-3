CREATE TABLE [dbo].[Users]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [Email] NCHAR(10) NULL, 
    [Password] NCHAR(10) NULL
)
