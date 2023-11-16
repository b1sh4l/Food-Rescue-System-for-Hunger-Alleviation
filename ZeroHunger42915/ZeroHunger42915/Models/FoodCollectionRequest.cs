//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger42915.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodCollectionRequest
    {
        public FoodCollectionRequest()
        {
            this.AssignedTasks = new HashSet<AssignedTask>();
        }
    
        public int RequestID { get; set; }
        public string RestaurantName { get; set; }
        public DateTime MaxPreservationTime { get; set; }
        public Nullable<bool> IsAssigned { get; set; }
        public Nullable<bool> IsCompleted { get; set; }


    
        public virtual ICollection<AssignedTask> AssignedTasks { get; set; }
    }
}
