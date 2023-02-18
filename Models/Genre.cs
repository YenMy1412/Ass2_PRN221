using System;
using System.Collections.Generic;

namespace Assignment2_Group4_SE1610.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }

        public int GenreId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
