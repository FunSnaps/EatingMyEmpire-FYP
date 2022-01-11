using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class CourseRecipeChoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int MenuCourseId { get; set; }

        public int SuggestedMenuId { get; set; }

        public int RecipeId { get; set; }

        [ForeignKey("MenuCourseId")]
        public MenuCourse MenuCourse { get; set; }

        [ForeignKey("SuggestedMenuId")]
        public SuggestedMenu SuggestedMenu { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

    }
}
