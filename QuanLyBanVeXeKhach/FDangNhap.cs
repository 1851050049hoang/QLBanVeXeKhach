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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (cbDN.Text == "Quản lý")
            {
                FQuanTri f = new FQuanTri();
                f.Show();
            }
            else if (cbDN.Text == "Nhân viên bán vé")
            {
                FQLBanVe f = new FQLBanVe();
                f.Show();
            }
            else
            {

            }    
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
