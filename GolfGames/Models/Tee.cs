using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GolfGames.Models
{
   public class Tee
    {
        public int ID { get; set; }
        public int golfcourseID { get; set; }
        public int Par { get; set; }
        public string Name { get; set; }
        public int Lenght { get; set; }
        public double Scratch { get; set; }
        public int Slope { get; set; }
        public Golfcourse Golfcourse { get; set; }



    }
}
