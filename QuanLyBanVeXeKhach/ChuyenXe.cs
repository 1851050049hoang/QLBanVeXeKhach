//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanVeXeKhach
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenXe()
        {
            this.VeXes = new HashSet<VeXe>();
        }
    
        public int MaCX { get; set; }
        public string TenCX { get; set; }
        public string DiemDi { get; set; }
        public string DiemDen { get; set; }
        public System.TimeSpan GioDi { get; set; }
        public decimal BangGia { get; set; }
        public int MaXe { get; set; }
        public string MaNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual Xe Xe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXes { get; set; }
    }
}
