using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
    public class CastingContext: DbContext
    {
        public CastingContext(): base("MovieConnection")
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
