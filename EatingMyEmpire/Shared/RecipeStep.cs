using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class RecipeStep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int RecipeId { get; set; }

        public string Instructions { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
    }
}
