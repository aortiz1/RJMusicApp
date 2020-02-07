CREATE TABLE [dbo].[Label]
(
	 [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL,
	 CONSTRAINT [PK_Label] PRIMARY KEY CLUSTERED ([Id] ASC)
)
