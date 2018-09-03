using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [Column("Id")]
        public int MovieId { get; set; }

        [MaxLength(255)]
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }

        public string Plot { get; set; }
        //[Column("Poster")]
        public byte?[] Poster { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
        [Required]
        public virtual Producer Producer { get; set; }
    }
}
