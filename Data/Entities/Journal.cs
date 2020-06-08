using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Journal : Entity
    {
        [ForeignKey("Character")]
        [Required]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        public string Description { get; set; }
    }
}
