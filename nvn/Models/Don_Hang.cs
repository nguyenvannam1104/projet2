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
    
    public partial class Don_Hang
    {
        public int MaDH { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<System.DateTime> Ngay_dat { get; set; }
        public Nullable<decimal> Tong_tien { get; set; }
        public Nullable<byte> Trang_thai { get; set; }
    
        public virtual khach_hang khach_hang { get; set; }
    }
}
