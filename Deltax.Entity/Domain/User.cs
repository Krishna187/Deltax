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
    [Table("User")]
    public abstract class User
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [MaxLength(255)]
        public string name { get; set; }
        public Gender Sex { get; set; }
        public DateTime? Dob { get; set; }
        [MaxLength(1000)]
        public string Bio { get; set; }

    }
}
