using Bogus;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Services
{
    public class DummyGeneratorService
    {
        public MusicDBContext _musicDBContext;

        public DummyGeneratorService(MusicDBContext musicDBContext)
        {
            _musicDBContext = musicDBContext;
        }

        public void GenerateLabelRandom(int totalLabels)
        {
            for (int i = 0; i < totalLabels; i++)
            {
                var mockLabel = new Faker<Label>()
                    .RuleFor(f => f.Name, r => r.Random.Words());
                _musicDBContext.Label.Add(mockLabel.Generate());
            }

            _musicDBContext.SaveChanges();
        }

        public void GeneratArtistRandom(int totalArtists)
        {
            for (int i = 0; i < totalArtists; i++)
            {
                var mockArtist = new Faker<Artist>()
                    .RuleFor(f => f.Name, r => r.Random.Words()).Generate();

                var mockGenre = new Faker<ArtistGenre>()
                    .RuleFor(f => f.GenreId, r => _musicDBContext.Genre.OrderBy(m => Guid.NewGuid()).FirstOrDefault().Id).Generate();
                mockArtist.ArtistGenre.Add(mockGenre);
                _musicDBContext.Artist.Add(mockArtist);
            }

            _musicDBContext.SaveChanges();
        }

        public void GenerateAlbumRandom(int totalAlbums)
        {
            for (int i = 0; i < totalAlbums; i++)
            {
                var mockAlbum = new Faker<Album>()
                    .RuleFor(f => f.Name, r => r.Random.Words())
                    .RuleFor(f=> f.Year, r=> r.Random.Int(1950,2020))
                    .RuleFor(f => f.LabelId, r => _musicDBContext.Label.OrderBy(m=> Guid.NewGuid()).FirstOrDefault().Id)
                    .Generate();

                var mockArtist = new Faker<AlbumArtist>()
                    .RuleFor(f => f.ArtistId, r => _musicDBContext.Artist.OrderBy(a => Guid.NewGuid()).FirstOrDefault().Id)
                    .Generate();
                mockAlbum.AlbumArtist.Add(mockArtist);

                _musicDBContext.Album.Add(mockAlbum);
            }

            _musicDBContext.SaveChanges();
        }
    }
}
