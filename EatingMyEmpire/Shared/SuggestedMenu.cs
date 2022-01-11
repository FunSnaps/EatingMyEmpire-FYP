using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class SuggestedMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int MenuTypeId { get; set; }

        public string MenuName { get; set; }

        public string MenuDescription { get; set; }

        [ForeignKey("MenuTypeId")]
        public MenuType MenuType { get; set; }
    }
}
