using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Data.Models.Dtos;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Data.Services
{
    public class AlbumService
    {
        public MusicDBContext _musicDBContext;

        public AlbumService(
            MusicDBContext musicDBContext)
        {
            _musicDBContext = musicDBContext;
        }

      
        public List<AlbumDTO> GetAllAlbums()
        {
            return _musicDBContext.Album.Select(this.SelectorAlbum()).ToList();
        }

        private Expression<Func<Album, AlbumDTO>> SelectorAlbum()
        {
            return album => new AlbumDTO
            {
                Id = album.Id,
                Name = album.Name,
                Year = album.Year.GetValueOrDefault(),
                Label = album.Label.Name,
                Genres = string.Join(",", album.AlbumArtist.SelectMany(x => x.Artist.ArtistGenre.Select(a => a.Genre.Name))),
                Artists = string.Join(",", album.AlbumArtist.Select(x => x.Artist.Name))
            };
        }
    }
}
