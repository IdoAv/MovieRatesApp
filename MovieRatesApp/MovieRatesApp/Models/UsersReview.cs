using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public partial class UsersReview
    {
        public int UserId { get; set; }
        public int ReviewId { get; set; }
        public bool IsLiked { get; set; }

        public virtual Review Review { get; set; }
        public virtual User User { get; set; }
    }
}
