using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Service.Interface
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        

    }
}
