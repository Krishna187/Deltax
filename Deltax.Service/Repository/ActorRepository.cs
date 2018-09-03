using Deltax.Entity.Domain;
using Deltax.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Service.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        CastingContext _db;
        public ActorRepository(CastingContext db) : base(db)
        {
            _db = db;
        }

        public void AddActor(Actor a)
        {
            _db.Users.Add(a);
        }
    }
}
