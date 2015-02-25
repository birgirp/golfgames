using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfGames.Models;

namespace GolfGames.DAL
{
    public class CoursesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            var courses = new List<Golfcourse>
            {
            new Golfcourse{ID=1050,Name="Leynir",NumberOfHoles=18,Country=Country.USA},
            new Golfcourse{ID=1051, Name="Korpa",NumberOfHoles=18,Country=Country.USA}

            };

            courses.ForEach(s => context.Golfcourses.Add(s));
            context.SaveChanges();
           
            var tees = new List<Tee>
            {
            new Tee{golfcourseID=1050,Name="Gulir",Par=72,Scratch=70.6, Slope=123, Lenght=5561 },
      
            };
            tees.ForEach(s => context.Tees.Add(s));
            context.SaveChanges();

        }
    }
}