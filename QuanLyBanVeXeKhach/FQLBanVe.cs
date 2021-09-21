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
    public partial class FQLBanVe : Form
    {
        public FQLBanVe()
        {
            InitializeComponent();
        }

        private void FBanVe_Load(object sender, EventArgs e)
        {

        }

        private void menuBanVe_Click(object sender, EventArgs e)
        {
            FBanVe f = new FBanVe();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            FThongKe f = new FThongKe();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
