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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConCungShopEntities : DbContext
    {
        public ConCungShopEntities()
            : base("name=ConCungShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<CT_DN> CT_DN { get; set; }
        public virtual DbSet<CT_DX> CT_DX { get; set; }
        public virtual DbSet<CTKhuyenMai> CTKhuyenMais { get; set; }
        public virtual DbSet<CtyVanChuyen> CtyVanChuyens { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<DoiTac> DoiTacs { get; set; }
        public virtual DbSet<HinhAnh_SP> HinhAnh_SP { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual DbSet<HoaDonXuat> HoaDonXuats { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<LSLuong> LSLuongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TheTinDung> TheTinDungs { get; set; }
        public virtual DbSet<VetGiaSP> VetGiaSPs { get; set; }
    }
}
