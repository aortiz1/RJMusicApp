﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Artist
    {
        public Artist()
        {
            AlbumArtist = new HashSet<AlbumArtist>();
            ArtistGenre = new HashSet<ArtistGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AlbumArtist> AlbumArtist { get; set; }
        public ICollection<ArtistGenre> ArtistGenre { get; set; }
    }
}
