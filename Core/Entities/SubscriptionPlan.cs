using System.Collections.Generic;

namespace LibraryAPI_R53_A.Core.Domain
{
    public class SubscriptionPlan
    {
        public int SubscriptionPlanId { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDescription { get; set; }
        public decimal PlanPrice { get; set; }
        public bool IsActive { get; set; }

        //public ICollection<UserInfo>? Users { get; set; }
    }
}
