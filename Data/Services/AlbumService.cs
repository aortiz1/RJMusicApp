using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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


        public List<Album> GetAllAlbums()
        {
            return _musicDBContext.Album.ToList();
        }

    }
}
