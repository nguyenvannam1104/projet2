//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nvn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class San_Pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_Pham()
        {
            this.Danhmuc_SP1 = new HashSet<Danhmuc_SP>();
        }
    
        public string MaSP { get; set; }
        public string Ten_SP { get; set; }
        public string Loai_SP { get; set; }
        public string Nam_SX { get; set; }
        public Nullable<byte> Trang_Thai { get; set; }
    
        public virtual Danhmuc_SP Danhmuc_SP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danhmuc_SP> Danhmuc_SP1 { get; set; }
    }
}
