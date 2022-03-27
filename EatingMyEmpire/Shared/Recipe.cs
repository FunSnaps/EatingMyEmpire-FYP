using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MinLength(3)]
        public string RecipeName { get; set; }

        [Required]
        public string RecipeDescription { get; set; }

        public int RecipeStepId { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        [ForeignKey("RecipeStepId")]
        public RecipeStep RecipeStep { get; set; }
    }
}
