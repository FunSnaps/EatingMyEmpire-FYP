using EatingMyEmpire.Models;
using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages.Models
{
    public class EditRecipeModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "A recipe name must be provided!")]
        [MinLength(3)]
        public string RecipeName { get; set; }

        [Required]
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "A description must be provided with a minumum of 8 characters!")]
        [MinLength(8)]
        public string RecipeDescription { get; set; }

        [Required(ErrorMessage = "A course type must be provided!")]
        public CourseType CourseType { get; set; }

        public int? RecipeStepId { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        public RecipeStep RecipeStep { get; set; }
    }
}
