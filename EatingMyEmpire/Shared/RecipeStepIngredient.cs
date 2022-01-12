using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class RecipeStepIngredient
    {
        [Key, Column(Order = 1)]
        public int RecipeId { get; set; }

        [Key, Column(Order = 2)]
        public int RecipeStepId { get; set; }

        [Key, Column(Order = 3)]
        public int IngredientId { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        [ForeignKey("RecipeStepId")]
        public RecipeStep RecipeStep { get; set; }

        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }

        public int AmountRequired { get; set; }
    }
}
