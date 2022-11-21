using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class HomeVM
    {
        public List <Slider> Sliders { get; set; }
        public About About { get; set; }
        public List <Services> Services { get; set; }
        public List<Courses> Courses { get; internal set; }
        public List<Notice> Notice { get;set; }
        public List<Blog> Blog { get; set; }
        public List<Events> Events { get; set; }

      
    }
}
