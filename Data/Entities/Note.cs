using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Note : Entity
    {
        [ForeignKey("Journal")]
        [Required]
        public int JournalId { get; set; }
        public virtual Journal Journal { get; set; }
        [Required]
        public bool IsPublic { get; set; }
        public string Content { get; set; }
    }
}
