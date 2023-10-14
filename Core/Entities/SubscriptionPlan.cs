﻿using LibraryAPI_R53_A.Core.Entities;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LibraryAPI_R53_A.Core.Domain
{
    public class SubscriptionPlan
    {
        public int SubscriptionPlanId { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDescription { get; set; }
        public decimal PlanPrice { get; set; }
        public bool IsActive { get; set; }

        public decimal? MonthlyFee { get; set; }//new added
        [JsonIgnore]
        public ICollection<SubscriptionUser>? SubscriptonUsers { get; set; }
        //[JsonIgnore]
        //public ICollection<Invoice>? Invoices { get; set; }
    }
}
