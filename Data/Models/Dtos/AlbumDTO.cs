using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Dtos
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Label { get; set; }
        public string Artists { get; set; }
        public string Genres { get; set; }
        public string Cover { get; set; }
    }
}
