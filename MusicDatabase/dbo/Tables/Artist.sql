CREATE TABLE [dbo].[Artist]
(
	 [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL, 
	 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED ([Id] ASC)
)
