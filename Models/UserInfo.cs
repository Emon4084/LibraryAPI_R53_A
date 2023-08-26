﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace R53_Group_A.Models
{
    public class UserInfo:IdentityUser
    {
        public string? RoleId { get; set; }
        public IdentityRole? Role { get; set; }

        public bool IsSubscribed { get; set; }

        //public bool IsActive { get; set; }
        public string? ProfileImage { get; set; }
        [NotMapped]
        public IFormFile? UserImage { get; set; }
        public int SubscriptionId { get; set; }
        public SubscriptionPlan? SubscriptionPlan { get; set; }
        public virtual List<UserPreference> UserPreferences { get; set; } = new List<UserPreference>();
        //public virtual ICollection<BookReview>? BookReviews { get; set; }
        public string? TransactionId { get; set; } //bkash or other 3rd party payment
    }
}

//This will be taken from IdentityUser
/*public string Name { get; set; }
public string Password { get; set; }
public string Email { get; set; }*/