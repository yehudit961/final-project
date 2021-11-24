//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivatingsForRide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivatingsForRide()
        {
            this.RideForUsers = new HashSet<RideForUser>();
        }
    
        public int Id { get; set; }
        public System.DateTime ActivatingDate { get; set; }
        public int ActivatingNum { get; set; }
        public System.DateTime ActivatingTime { get; set; }
        public bool Status { get; set; }
        public int ParticipantNum { get; set; }
        public int RideManagerId { get; set; }
        public int RideId { get; set; }
    
        public virtual User User { get; set; }
        public virtual Ride Ride { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RideForUser> RideForUsers { get; set; }
    }
}