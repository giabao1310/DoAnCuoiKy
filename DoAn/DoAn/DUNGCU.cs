//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class DUNGCU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DUNGCU()
        {
            this.CHITIETMUONs = new HashSet<CHITIETMUON>();
        }
    
        public string MADUNGCU { get; set; }
        public string TENDUNGCU { get; set; }
        public Nullable<System.DateTime> NGAYMUA { get; set; }
        public Nullable<int> GIATIEN { get; set; }
        public string CONSUDUNGDUOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONs { get; set; }
    }
}