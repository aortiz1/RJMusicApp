CREATE TABLE [dbo].[Artist_Genre]
(
	 [Id]   INT           IDENTITY (1, 1) NOT NULL, 
    [ArtistId] INT NULL, 
    [GenreId] INT NULL, 
    CONSTRAINT [FK_Artist_Genre_Artist] FOREIGN KEY ([ArtistId]) REFERENCES [Artist]([Id]), 
    CONSTRAINT [FK_Artist_Genre_Genre] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id]),

)
