//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _18_csdlnc19_1_da2
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoiTac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoiTac()
        {
            this.HoaDonNhaps = new HashSet<HoaDonNhap>();
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int Ma_DT { get; set; }
        public string Ten_DT { get; set; }
        public string DienThoai_DT { get; set; }
        public string Email_DT { get; set; }
        public int DiaChi_DT { get; set; }
    
        public virtual DiaChi DiaChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
