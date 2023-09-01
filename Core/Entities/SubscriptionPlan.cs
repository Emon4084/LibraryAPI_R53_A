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
        [JsonIgnore]
        public ICollection<ApplicationUser>? Users { get; set; }
    }
}
