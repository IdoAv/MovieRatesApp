using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public  class ReviewComment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentTime { get; set; }

        public virtual Review Review { get; set; }
        public virtual User User { get; set; }
    }
}
