//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace amazonMechanicalTurk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobAdditional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobAdditional()
        {
            this.JobDatas = new HashSet<JobData>();
        }
    
        public int AdditionalJobID { get; set; }
        public int JobID { get; set; }
        public byte[] JobImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobData> JobDatas { get; set; }
    }
}
