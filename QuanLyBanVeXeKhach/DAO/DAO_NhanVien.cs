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
                s.MaNV,
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

        public void themNV(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public bool kiemTraNV(NhanVien nv)
        {
            NhanVien n = db.NhanViens.Find(nv.MaNV);
            if (n != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void suaNV(NhanVien nv)
        {
            NhanVien n = db.NhanViens.Find(nv.MaNV);
            n.HoTen = nv.HoTen;
            n.NgaySinh = nv.NgaySinh;
            n.GioiTinh = nv.GioiTinh;
            n.DiaChi = nv.DiaChi;
            n.CMND = nv.CMND;
            n.DienThoai = nv.DienThoai;
            n.MaLoaiNV = nv.MaLoaiNV;
            db.SaveChanges();
        }

        public void xoaNV(NhanVien nv)
        {
            NhanVien n = db.NhanViens.Find(nv.MaNV);
            db.NhanViens.Remove(n);
            db.SaveChanges();
        }
    }
}
