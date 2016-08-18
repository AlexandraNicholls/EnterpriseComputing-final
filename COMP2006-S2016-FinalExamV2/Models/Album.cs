/*
    file: Models/Album.cs
    Provides a simple get and set method for each field related to an album; in this case created 
    by the database.
    author: Alex Nicholls
    student number: 200287546
    date: August 18, 2016
    history:
        added controllers and navigation
*/

namespace COMP2006_S2016_FinalExamV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
