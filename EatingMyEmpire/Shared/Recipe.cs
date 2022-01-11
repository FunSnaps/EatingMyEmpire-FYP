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

        public string RecipeName { get; set; }

        public string RecipeDescription { get; set; }

        public string PhotoPath { get; set; }

        /*public int PhotoId { get; set; }

        [ForeignKey("PhotoId")]
        public Photo Photo { get; set; }*/
    }
}
