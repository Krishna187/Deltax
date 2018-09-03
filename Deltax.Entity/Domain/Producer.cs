using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
   public class Producer:User
    {
        public virtual Movie Movie { get; set; }
    }
}
