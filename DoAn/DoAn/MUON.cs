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
    
    public partial class MUON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUON()
        {
            this.CHITIETMUONs = new HashSet<CHITIETMUON>();
        }
    
        public int SOPHIEUMUON { get; set; }
        public Nullable<System.DateTime> NGAYMUON { get; set; }
        public Nullable<System.TimeSpan> GIOMUON { get; set; }
        public string MALOP { get; set; }
        public string MAGIAOVIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONs { get; set; }
        public virtual GIAOVIEN GIAOVIEN { get; set; }
        public virtual LOP LOP { get; set; }
    }
}
