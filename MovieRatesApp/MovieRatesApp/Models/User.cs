using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public class User
    {
        public User()
        {
            Entries = new List<Entry>();
            FollowingUserFollowerUsers = new List<FollowingUser>();
            FollowingUserFollowingUserNavigations = new List<FollowingUser>();
            LikedMovies = new List<LikedMovie>();
            Ratings = new List<Rating>();
            ReviewComments = new List<ReviewComment>();
            Reviews = new List<Review>();
            UsersReviews = new List<UsersReview>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int FavGenreId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime SignUpDate { get; set; }

        public virtual List<Entry> Entries { get; set; }
        public virtual List<FollowingUser> FollowingUserFollowerUsers { get; set; }
        public virtual List<FollowingUser> FollowingUserFollowingUserNavigations { get; set; }
        public virtual List<LikedMovie> LikedMovies { get; set; }
        public virtual List<Rating> Ratings { get; set; }
        public virtual List<ReviewComment> ReviewComments { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<UsersReview> UsersReviews { get; set; }
    }
