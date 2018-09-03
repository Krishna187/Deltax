using Deltax.Entity.Domain;
using Deltax.Service.Interface;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Service.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        CastingContext _db;
        public MovieRepository(CastingContext db) : base(db)
        {
            _db = db;
        }

        public List<Movie> GetAllMovies()
        {
            return _db.Movies.Include(x=>x.Actors).Include(x=>x.Producer).ToList();
        }
    }
}
