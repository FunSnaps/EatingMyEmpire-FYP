using EatingMyEmpire.Models;
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

        [Required(ErrorMessage ="A recipe name must be provided!")]
        [MinLength(3)]
        public string RecipeName { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "A description must be provided with a minumum of 8 characters!")]
        [MinLength(8)]
        public string RecipeDescription { get; set; }

        [Required(ErrorMessage = "A course type must be provided!")]
        public CourseType CourseType { get; set; }

        public int RecipeStepId { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        [ForeignKey("RecipeStepId")]
        public RecipeStep RecipeStep { get; set; }
    }
}
