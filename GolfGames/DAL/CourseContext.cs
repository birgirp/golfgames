using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfGames.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GolfGames.DAL
{
    public class CourseContext : DbContext
    {

        public CourseContext()
            : base("CourseContext")
        {

        }
        public DbSet<Golfcourse> Golfcourses { get; set; }
        public DbSet<Tee> Tees { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}