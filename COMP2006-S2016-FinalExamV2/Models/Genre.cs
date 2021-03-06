/*
    file: Models/Genre.cs
    Provides a simple get and set method for each field related to a genre; in this case created 
    by the database.
    author: Alex Nicholls
    student number: 200287546
    date: August 18, 2016
    history:
        added controllers and navigation
         added comments
        final commit
*/

namespace COMP2006_S2016_FinalExamV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre()
        {
            Albums = new HashSet<Album>();
        }

        public int GenreId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Albums { get; set; }
    }
}
