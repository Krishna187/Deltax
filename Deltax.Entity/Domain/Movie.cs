using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Entity.Domain
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        public byte?[] Poster { get; set; }
        public int ProducerId { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
