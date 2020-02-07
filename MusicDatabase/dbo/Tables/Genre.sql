CREATE TABLE [dbo].[Genre]
(
	 [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL,
	 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED ([Id] ASC)
)
