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
        
        [Required]
        public string Ingredients { get; set; } 

        [Required]
        public string Instructions { get; set; }

        public static implicit operator RecipeStep(List<RecipeStep> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List<object>(RecipeStep v)
        {
            throw new NotImplementedException();
        }
    }
}
