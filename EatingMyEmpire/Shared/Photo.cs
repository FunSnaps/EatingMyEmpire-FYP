using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Shared
{
    public class Photo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("Poster title")]
        public String Name { get; set; }

        [DisplayName("File name")]
        public String ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Image { get; set; }
    }
}
