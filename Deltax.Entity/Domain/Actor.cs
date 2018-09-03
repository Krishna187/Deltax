using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
   public class Actor:User
    {
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
