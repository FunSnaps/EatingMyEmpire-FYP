using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared 
{
    public class MenuCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int SuggestedMenuId { get; set; }

        public string CourseName { get; set; }

        [ForeignKey("SuggestedMenuId")]
        public SuggestedMenu SuggestedMenu { get; set; }
    }
}
