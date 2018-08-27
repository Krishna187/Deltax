using Deltax.Entity.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Bio { get; set; }
        [Required]
        public Gender Sex { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }

    }
}
