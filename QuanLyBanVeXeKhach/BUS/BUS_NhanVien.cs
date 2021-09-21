using QuanLyBanVeXeKhach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach.BUS
{
    class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;

        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }

        public void layDSNV(DataGridView dg)
        {
            dg.DataSource = dNhanVien.layDSNV();
        }

        public void layDSLoaiNV(ComboBox cb)
        {
            cb.DataSource = dNhanVien.layDSLoaiNV();
            cb.DisplayMember = "TenLoaiNV";
            cb.ValueMember = "MaLoaiNV";
        }
    }
}
