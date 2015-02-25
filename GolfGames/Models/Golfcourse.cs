using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfGames.Models
{
    public enum Country
    {
        Iceland, UK, Spain, Portugal, USA
    }
    public class Golfcourse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfHoles { get; set; }
        public Country Country { get; set; }

        public virtual ICollection<Tee> Tees { get; set; }
    }
}