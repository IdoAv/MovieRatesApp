using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public  class Rating
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public double Rating1 { get; set; }

        public virtual User User { get; set; }
    }
}
