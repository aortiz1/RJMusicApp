using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class ArtistGenre
    {
        public int Id { get; set; }
        public int? ArtistId { get; set; }
        public int? GenreId { get; set; }

        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}
