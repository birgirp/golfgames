using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GolfGames.Models
{

    public class Competition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Golfcourse> Golfcourses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}