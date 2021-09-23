using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXeKhach.DAO
{
    class DAO_Xe
    {
        QuanLyBanVeXeKhachEntities db;
        public DAO_Xe()
        {
            db = new QuanLyBanVeXeKhachEntities();
        }

        public dynamic layDSXe()
        {
            var ds = db.Xes.Select(s => new
            {
                s.MaXe,
                s.BienSo,
                s.SoGhe,
                s.LoaiXe.TenLoaiXe
            }).ToList();
            return ds;
        }

        public dynamic layDSLoaiXe()
        {
            var ds = db.LoaiXes.Select(s => new
            {
                s.MaLoaiXe,
                s.TenLoaiXe,
            }).ToList();
            return ds;
        }

        public void themXe(Xe xe)
        {
            db.Xes.Add(xe);
            db.SaveChanges();
        }

        public bool kiemTraXe(Xe xe)
        {
            Xe x = db.Xes.Find(xe.MaXe);
            if (x != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void suaXe(Xe xe)
        {
            Xe x = db.Xes.Find(xe.MaXe);
            x.BienSo = xe.BienSo;
            x.MaLoaiXe = xe.MaLoaiXe;
            x.SoGhe = xe.SoGhe;
            db.SaveChanges();
        }

        public void xoaXe(Xe xe)
        {
            Xe x = db.Xes.Find(xe.MaXe);
            db.Xes.Remove(x);
            db.SaveChanges();
        }
    }
}
