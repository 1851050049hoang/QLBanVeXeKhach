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
    class BUS_Xe
    {
        DAO_Xe dXe;

        public BUS_Xe()
        {
            dXe = new DAO_Xe();
        }

        public void layDSXe(DataGridView dg)
        {
            dg.DataSource = dXe.layDSXe();
        }

        public void layDSLoaiXe(ComboBox cb)
        {
            cb.DataSource = dXe.layDSLoaiXe();
            cb.DisplayMember = "TenLoaiXe";
            cb.ValueMember = "MaLoaiXe";
        }

        public bool themXe(Xe xe)
        {
            try
            {
                dXe.themXe(xe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool suaXe(Xe xe)
        {
            if (dXe.kiemTraXe(xe))
            {
                try
                {
                    dXe.suaXe(xe);
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

        public bool xoaXe(Xe xe)
        {
            if (dXe.kiemTraXe(xe))
            {
                try
                {
                    dXe.xoaXe(xe);
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
