using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public class LikedMovie
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public bool IsLiked { get; set; }

        public virtual User User { get; set; }
    }
}
