using QuanLyBanVeXeKhach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class FNhanVien : Form
    {
        BUS_NhanVien busNV;
        public FNhanVien()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
        }

        private void hienThiDSNV()
        {
            dGNhanVien.DataSource = null;
            busNV.layDSNV(dGNhanVien);
        }

        private void hienThiDSLoaiNV()
        {
            cbChucVu.DataSource = null;
            busNV.layDSLoaiNV(cbChucVu);
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            hienThiDSNV();
            busNV.layDSLoaiNV(cbChucVu);
        }
    }
}
