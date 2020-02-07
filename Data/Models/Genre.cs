using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Genre
    {
        public Genre()
        {
            ArtistGenre = new HashSet<ArtistGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ArtistGenre> ArtistGenre { get; set; }
    }
}
