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
            //var albums= _musicDBContext.Album.Include(a=> a.AlbumArtist).Include("AlbumArtist.Artist").ToList();
            //var genres = albums.SelectMany(album => album.AlbumArtist.Select(x => x.Artist.ArtistGenre.Select(a => a.Genre.Name)));
            //var artists = albums.SelectMany(album => album.AlbumArtist.Select(a=> a.Album.Name));
            //return null;
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
