﻿CREATE TABLE [dbo].[Album] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL, 
    [Year] INT NULL, 
    [LabelId] INT NULL, 
    CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED ([Id] ASC)

);

