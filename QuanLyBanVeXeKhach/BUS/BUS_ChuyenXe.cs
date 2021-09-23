using QuanLyBanVeXeKhach.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach.BUS
{
    class BUS_ChuyenXe
    {
        DAO_ChuyenXe dCX;

        public BUS_ChuyenXe()
        {
            dCX = new DAO_ChuyenXe();
        }

        public void layDSCX(DataGridView dg)
        {
            dg.DataSource = dCX.layDSChuyenXe();
        }

        public void layDSNV(ComboBox cb)
        {
            cb.DataSource = dCX.layDSNV();
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "MaNV";
        }

        public void layDSXe(ComboBox cb)
        {
            cb.DataSource = dCX.layDSXe();
            cb.DisplayMember = "BienSo";
            cb.ValueMember = "MaXe";
        }

        public bool themCX(ChuyenXe cx)
        {
            try
            {
                dCX.themCX(cx);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool suaCX(ChuyenXe cx)
        {
            if (dCX.kiemTraCX(cx))
            {
                try
                {
                    dCX.suaCX(cx);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool xoaCX(ChuyenXe cx)
        {
            if (dCX.kiemTraCX(cx))
            {
                try
                {
                    dCX.xoaCX(cx);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
