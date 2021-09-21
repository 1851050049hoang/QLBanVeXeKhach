using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXeKhach.DAO
{
    class DAO_NhanVien
    {
        QuanLyBanVeXeKhachEntities db;

        public DAO_NhanVien()
        {
            db = new QuanLyBanVeXeKhachEntities();

            
        }

        public dynamic layDSNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaLoaiNV,
                s.HoTen,
                s.NgaySinh,
                s.GioiTinh,
                s.DiaChi,
                s.CMND,
                s.DienThoai,
                s.LoaiNhanVien.TenLoaiNV
            }).ToList();
            return ds;
        }

        public dynamic layDSLoaiNV()
        {
            var ds = db.LoaiNhanViens.Select(s => new
            {
                s.MaLoaiNV,
                s.TenLoaiNV,
            }).ToList();
            return ds;
        }
    }
}
