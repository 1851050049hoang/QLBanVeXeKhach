using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXeKhach.DAO
{
    class DAO_ChuyenXe
    {
        QuanLyBanVeXeKhachEntities db;

        public DAO_ChuyenXe()
        {
            db = new QuanLyBanVeXeKhachEntities();
        }

        public dynamic layDSChuyenXe()
        {
            var ds = db.ChuyenXes.Select(s => new
            {
                s.MaCX,
                s.TenCX,
                s.DiemDi,
                s.DiemDen,
                s.GioDi,
                s.BangGia,
                s.ChiTietDiemDi,
                s.ChiTietDiemDen,
                s.Xe.BienSo,
                s.NhanVien.HoTen
            }).ToList();
            return ds;
        }

        public dynamic layDSXe()
        {
            var ds = db.Xes.Select(s => new
            {
                s.MaXe,
                s.BienSo,
            }).ToList();
            return ds;
        }

        public dynamic layDSNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.HoTen,
            }).ToList();
            return ds;
        }

        public void themCX(ChuyenXe cx)
        {
            db.ChuyenXes.Add(cx);
            db.SaveChanges();
        }

        public bool kiemTraCX(ChuyenXe cx)
        {
            ChuyenXe c = db.ChuyenXes.Find(cx.MaCX);
            if (c != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void suaCX(ChuyenXe cx)
        {
            ChuyenXe c = db.ChuyenXes.Find(cx.MaCX);
            c.TenCX = cx.TenCX;
            c.DiemDi = cx.DiemDi;
            c.ChiTietDiemDi = cx.ChiTietDiemDi;
            c.DiemDen = cx.DiemDen;
            c.ChiTietDiemDen = cx.ChiTietDiemDen;
            c.GioDi = cx.GioDi;
            c.BangGia = cx.BangGia;
            c.MaXe = cx.MaXe;
            c.MaNV = cx.MaNV;
            db.SaveChanges();
        }

        public void xoaCX(ChuyenXe cx)
        {
            ChuyenXe c = db.ChuyenXes.Find(cx.MaCX);
            db.ChuyenXes.Remove(c);
            db.SaveChanges();
        }
    }
}
