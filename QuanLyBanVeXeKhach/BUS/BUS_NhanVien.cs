﻿using QuanLyBanVeXeKhach.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        public bool themNV(NhanVien nv)
        {
            try
            {
                dNhanVien.themNV(nv);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool suaNV(NhanVien nv)
        {
            if(dNhanVien.kiemTraNV(nv))
            {
                try
                {
                    dNhanVien.suaNV(nv);
                    return true;
                }
                catch(DbUpdateException ex)
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

        public bool xoaNV(NhanVien nv)
        {
            if (dNhanVien.kiemTraNV(nv))
            {
                try
                {
                    dNhanVien.xoaNV(nv);
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
