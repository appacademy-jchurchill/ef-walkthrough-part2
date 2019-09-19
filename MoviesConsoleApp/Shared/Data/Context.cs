using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Data
{
    public class Context : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Actors)
                .WithMany(a => a.Movies)
                .Map(ma =>
                {
                    ma.MapLeftKey("MovieId");
                    ma.MapRightKey("ActorId");
                    ma.ToTable("MovieActorBridge");
                });
        }
    }
}
