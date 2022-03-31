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

        [Required(ErrorMessage = "Ingredients field must be provided with a minumum of 16 characters!")]
        [MinLength(16)]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Instructions field must be provided with a minumum of 16 characters!")]
        [MinLength(16)]
        public string Instructions { get; set; }
    }
}
