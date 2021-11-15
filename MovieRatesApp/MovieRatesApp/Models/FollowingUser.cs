using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public  class FollowingUser
    {
        public int FollowerUserId { get; set; }
        public int FollowingUserId { get; set; }

        public virtual User FollowerUser { get; set; }
        public virtual User FollowingUserNavigation { get; set; }
    }
}
