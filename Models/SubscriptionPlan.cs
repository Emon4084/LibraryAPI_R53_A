using System.Collections.Generic;

namespace R53_Group_A.Models
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
