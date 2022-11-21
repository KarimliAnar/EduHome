using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please fill the empty box")]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDeactive { get; set; }
        
     

    }
}
