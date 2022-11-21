using EduHomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options):base (options)
        {

        }
        public DbSet <Slider> Sliders { get; set; }
        public DbSet <About> Abouts{ get; set; }
        public DbSet <Services> Services { get; set; }
        public DbSet <Courses> Courses{ get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Course> Course { get; set; }
        public object Slider { get; internal set; }
    }
}
