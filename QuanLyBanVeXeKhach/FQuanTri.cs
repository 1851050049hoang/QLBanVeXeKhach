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
    public partial class FQuanTri : Form
    {
        public FQuanTri()
        {
            InitializeComponent();
        }

        private void menuNV_Click(object sender, EventArgs e)
        {
            FNhanVien f = new FNhanVien();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void menuChuyenXe_Click(object sender, EventArgs e)
        {
            FChuyenXe f = new FChuyenXe();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void menuXe_Click(object sender, EventArgs e)
        {
            FXe f = new FXe();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
