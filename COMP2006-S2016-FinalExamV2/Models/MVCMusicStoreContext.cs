/*
    file: Models/MVCMusicStoreContext.cs
    Provides a simple get and set method for each type of list related to the music store; in this case created
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
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCMusicStoreContext : DbContext
    {
        public MVCMusicStoreContext()
            : base("name=MVCMusicStoreContext")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
