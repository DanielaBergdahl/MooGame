using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WestCoastEducation2K.Models;

namespace WestCoastEducation2K.Data
{
    public class Context : DbContext
    {
        protected readonly IConfiguration Configuration;

        public Context(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }
        //public Context(DbContextOptions<Context> options) : base(options)
        //{}

        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<CourseCategory> CourseCategories { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
    }

}