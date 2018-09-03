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
    public class ProducerRepository : GenericRepository<User>, IProducerRepository
    {

        CastingContext _db = new CastingContext();
        public ProducerRepository(CastingContext db) : base(db)
        {
            _db = db;
        }

        public void AddProducer(Producer producer)
        {
            _db.Users.Add(producer);
        }

        public List<User> GetAllProducers()
        {
           return _db.Users.Where(x=> x is Producer).ToList();
        }
    }
}
