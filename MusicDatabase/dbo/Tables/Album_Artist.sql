CREATE TABLE [dbo].[Album_Artist]
(
	 [Id]   INT    IDENTITY (1, 1) NOT NULL, 
    [AlbumId] INT NULL, 
    [ArtistId] INT NULL, 
    CONSTRAINT [FK_Album_Artist_Album] FOREIGN KEY ([AlbumId]) REFERENCES [Album]([Id])
)
