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
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.DanhGias = new HashSet<DanhGia>();
            this.HoaDonXuats = new HashSet<HoaDonXuat>();
            this.TheTinDungs = new HashSet<TheTinDung>();
        }
    
        public int Ma_KH { get; set; }
        public string Ten_KH { get; set; }
        public System.DateTime NgaySinh_KH { get; set; }
        public string DienThoai_KH { get; set; }
        public string Email_KH { get; set; }
        public bool GT_KH { get; set; }
        public int DiaChi_KH { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string TrangThaiTK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGias { get; set; }
        public virtual DiaChi DiaChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonXuat> HoaDonXuats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheTinDung> TheTinDungs { get; set; }
    }
}
