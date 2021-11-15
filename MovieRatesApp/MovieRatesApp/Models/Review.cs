using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public class Review
    {
        public Review()
        {
            ReviewComments = new List<ReviewComment>();
            UsersReviews = new List<UsersReview>();
        }

        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string ReviewContent { get; set; }
        public DateTime ReviewTime { get; set; }

        public virtual User User { get; set; }
        public virtual List<ReviewComment> ReviewComments { get; set; }
        public virtual List<UsersReview> UsersReviews { get; set; }
    }
}
