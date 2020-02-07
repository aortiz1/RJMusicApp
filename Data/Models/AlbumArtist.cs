using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class AlbumArtist
    {
        public int Id { get; set; }
        public int? AlbumId { get; set; }
        public int? ArtistId { get; set; }

        public Album Album { get; set; }
        public Artist Artist { get; set; }
    }
}
