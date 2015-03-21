using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfGames.Models;

namespace GolfGames.DAL
{                                       // ATH hendir gamla database og byr til nyjan
    public class CoursesInitializer : System.Data.Entity.DropCreateDatabaseAlways<CourseContext>
                                    //System.Data.Entity.CreateDatabaseIfNotExists<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            var users = new List<User>
            {
                new User{Name="Birgir", Forgjof = 16},
                new User{Name="Regína",Forgjof = 42}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var competitions = new List<Competition>
            {
                new Competition{Id = 1, Name="Aðalmótið"},
                new Competition{Id = 2, Name="Gullmótið"}
            };
            competitions.ForEach(s => context.Competitions.Add(s));
            context.SaveChanges();

            var courses = new List<Golfcourse>
            {
                new Golfcourse{Name="Leynir",Country="Iceland"},
                new Golfcourse{Name="Korpa",Country="Iceland"}
            };
            courses.ForEach(s => context.Golfcourses.Add(s));
            context.SaveChanges();
           
            var tees = new List<Tee>
            {
                new Tee{GolfcourseId=1,Name="Gulir",Par=72,Scratch=70.6, Slope=123, Lenght=5561},
                new Tee{GolfcourseId=1,Name="Rauðir",Par=72,Scratch=70.6, Slope=23, Lenght=5561},
                new Tee{GolfcourseId=1,Name="Grænir",Par=72,Scratch=70.6, Slope=12, Lenght=5561},
                new Tee{GolfcourseId=1,Name="Bleikir",Par=72,Scratch=70.6, Slope=1123, Lenght=5561},
                new Tee{GolfcourseId=1,Name="Svartir",Par=72,Scratch=70.6, Slope=123, Lenght=5561},
                new Tee{GolfcourseId=1,Name="Hvítir",Par=72,Scratch=70.6, Slope=123, Lenght=5561},

                new Tee{GolfcourseId=2,Name="Gulir",Par=72,Scratch=70.6, Slope=123, Lenght=5561},
                new Tee{GolfcourseId=2,Name="Rauðir",Par=72,Scratch=70.6, Slope=23, Lenght=5561},
                new Tee{GolfcourseId=2,Name="Grænir",Par=72,Scratch=70.6, Slope=12, Lenght=5561},
                new Tee{GolfcourseId=2,Name="Bleikir",Par=72,Scratch=70.6, Slope=1123, Lenght=5561},
                new Tee{GolfcourseId=2,Name="Svartir",Par=72,Scratch=70.6, Slope=123, Lenght=5561},
                new Tee{GolfcourseId=2,Name="Hvítir",Par=72,Scratch=70.6, Slope=123, Lenght=5561}
            };
            tees.ForEach(s => context.Tees.Add(s));
            context.SaveChanges();

        }
    }
}