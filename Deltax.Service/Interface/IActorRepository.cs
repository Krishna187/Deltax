using Deltax.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Service.Interface
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        void AddActor(Actor a);
    }
}
