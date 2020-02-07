using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Album
    {
        public Album()
        {
            AlbumArtist = new HashSet<AlbumArtist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int? LabelId { get; set; }

        public ICollection<AlbumArtist> AlbumArtist { get; set; }
    }
}
