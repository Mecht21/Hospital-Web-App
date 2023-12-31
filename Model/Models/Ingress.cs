//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingress()
        {
            this.Egress = new HashSet<Egress>();
        }
    
        public long id { get; set; }
        public System.DateTime date { get; set; }
        public int roomNumber { get; set; }
        public int bedNumber { get; set; }
        public string diagnosis { get; set; }
        public string observation { get; set; }
        public bool erased { get; set; }
        public long doctorId { get; set; }
        public long pacientId { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Egress> Egress { get; set; }
        public virtual Ingress Ingress1 { get; set; }
        public virtual Ingress Ingress2 { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
