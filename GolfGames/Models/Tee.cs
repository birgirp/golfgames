using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GolfGames.Models
{
   public class Tee
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
        public int Par { get; set; }
        public string Name { get; set; }
        public int Lenght { get; set; }
        public double Scratch { get; set; }
        public int Slope { get; set; }

        public int GolfcourseId { get; set; }
        public Golfcourse Golfcourse { get; set; }
    }
}
