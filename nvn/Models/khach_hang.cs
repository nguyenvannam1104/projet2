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
    
    public partial class khach_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khach_hang()
        {
            this.Don_Hang = new HashSet<Don_Hang>();
        }
    
        public int MaKH { get; set; }
        public string Ho_ten { get; set; }
        public string Tai_khoan { get; set; }
        public string Mat_khau { get; set; }
        public string Dia_chi { get; set; }
        public string Dien_thoai { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Ngay_sinh { get; set; }
        public Nullable<System.DateTime> Ngay_cap_nhat { get; set; }
        public Nullable<byte> Gioi_tinh { get; set; }
        public Nullable<int> Tich_diem { get; set; }
        public Nullable<byte> Trang_thai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Don_Hang> Don_Hang { get; set; }
    }
}
