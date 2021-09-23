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
    public partial class FQuanTri : Form
    {
        BUS_NhanVien busNV;
        BUS_Xe busXe;
        BUS_ChuyenXe busCX;
        public FQuanTri()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
            busXe = new BUS_Xe();
            busCX = new BUS_ChuyenXe();
        }


        //TAB Nhân viên

        //Hiển thị bảng danh sách nhân viên
        private void hienThiDSNV()
        {
            dGNhanVien.DataSource = null;
            busNV.layDSNV(dGNhanVien);
            dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.175);
            dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.075);
            dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.175);
            dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.125);
            dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.125);
            dGNhanVien.Columns[7].Width = (int)(dGNhanVien.Width * 0.125);
        }

        //Hiển thị thông tin nhân viên
        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGNhanVien.Rows.Count)
            {
                txtMSNV.Text = dGNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenNV.Text = dGNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dTPNS.Text = dGNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGT.Text = dGNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dGNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCMND.Text = dGNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = dGNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbChucVu.Text = dGNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        //Thêm nhân viên
        private void btThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = txtHoTenNV.Text;
            nv.NgaySinh = dTPNS.Value;
            nv.GioiTinh = cbGT.SelectedItem.ToString();
            nv.DiaChi = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;
            nv.DienThoai = txtSDT.Text;
            nv.MaLoaiNV = int.Parse(cbChucVu.SelectedValue.ToString());

            if(busNV.themNV(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                busNV.layDSNV(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        //Sửa nhân viên
        private void btSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMSNV.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(txtMSNV.Text);
                nv.HoTen = txtHoTenNV.Text;
                nv.NgaySinh = dTPNS.Value;
                nv.GioiTinh = cbGT.SelectedItem.ToString();
                nv.DiaChi = txtDiaChi.Text;
                nv.CMND = txtCMND.Text;
                nv.DienThoai = txtSDT.Text;
                nv.MaLoaiNV = int.Parse(cbChucVu.SelectedValue.ToString());

                busNV.suaNV(nv);
                busNV.layDSNV(dGNhanVien);
            }
        }

        //Xóa nhân viên
        private void btXoaNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(txtMSNV.Text);

            if (busNV.xoaNV(nv))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                busNV.layDSNV(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }


        //TAB XE

        //Hiển thị danh sách xe
        private void hienThiDSXe()
        {
            dGXe.DataSource = null;
            busXe.layDSXe(dGXe);
            //dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            //dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.175);
            //dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.1);
            //dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.075);
            //dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.175);
            //dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.125);
            //dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.125);
            //dGNhanVien.Columns[7].Width = (int)(dGNhanVien.Width * 0.125);
        }

        private void dGXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGXe.Rows.Count)
            {
                txtMaXe.Text = dGXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBienSo.Text = dGXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLoaiXe.Text = dGXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                nUDSoGhe.Text = dGXe.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btThemXe_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.BienSo = txtBienSo.Text;
            xe.MaLoaiXe = int.Parse(cbLoaiXe.SelectedValue.ToString());
            xe.SoGhe = int.Parse(nUDSoGhe.Value.ToString());

            if (busXe.themXe(xe))
            {
                MessageBox.Show("Thêm xe thành công");
                busXe.layDSXe(dGXe);
            }
            else
            {
                MessageBox.Show("Thêm xe thất bại");
            }
        }

        private void btSuaXe_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                Xe xe = new Xe();
                xe.MaXe = int.Parse(txtMaXe.Text);
                xe.BienSo = txtBienSo.Text;
                xe.MaLoaiXe = int.Parse(cbLoaiXe.SelectedValue.ToString());
                xe.SoGhe = int.Parse(nUDSoGhe.Value.ToString());

                busXe.suaXe(xe);
                busXe.layDSXe(dGXe);
            }
        }

        private void btXoaXe_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.MaXe = int.Parse(txtMaXe.Text);

            if (busXe.xoaXe(xe))
            {
                MessageBox.Show("Xóa xe thành công");
                busXe.layDSXe(dGXe);
            }
            else
            {
                MessageBox.Show("Xóa xe thất bại");
            }
        }


        //TAB Chuyến Xe

        //Hiển thị danh sách chuyến xe
        private void hienThiDSCX()
        {
            dGChuyenXe.DataSource = null;
            busCX.layDSCX(dGChuyenXe);
            //dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            //dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.175);
            //dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.1);
            //dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.075);
            //dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.175);
            //dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.125);
            //dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.125);
            //dGNhanVien.Columns[7].Width = (int)(dGNhanVien.Width * 0.125);
        }

        private void dGChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGChuyenXe.Rows.Count)
            {
                txtMSCX.Text = dGChuyenXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenCX.Text = dGChuyenXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiemDi.Text = dGChuyenXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtChiTietDiemDi.Text = dGChuyenXe.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiemDen.Text = dGChuyenXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChiTietDiemDen.Text = dGChuyenXe.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtGioDi.Text = dGChuyenXe.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGiaVe.Text = dGChuyenXe.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbMaXe.Text = dGChuyenXe.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbMaNV.Text = dGChuyenXe.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btThemCX_Click(object sender, EventArgs e)
        {
            ChuyenXe cx = new ChuyenXe();
            cx.TenCX = txtTenCX.Text;
            cx.DiemDi = txtDiemDi.Text;
            cx.ChiTietDiemDi = txtChiTietDiemDi.Text;
            cx.DiemDen = txtDiemDen.Text;
            cx.ChiTietDiemDen = txtChiTietDiemDen.Text;
            cx.GioDi = txtGioDi.Text;
            cx.BangGia = decimal.Parse(txtGiaVe.Text.ToString());
            cx.MaXe = int.Parse(cbMaXe.SelectedValue.ToString());
            cx.MaNV = int.Parse(cbMaNV.SelectedValue.ToString());
            if (busCX.themCX(cx))
            {
                MessageBox.Show("Thêm chuyến xe thành công");
                busCX.layDSCX(dGChuyenXe);
            }
            else
            {
                MessageBox.Show("Thêm chuyến xe thất bại");
            }
        }

        private void btSuaCX_Click(object sender, EventArgs e)
        {
            if (txtMSCX.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                ChuyenXe cx = new ChuyenXe();
                cx.MaCX = int.Parse(txtMSCX.Text);
                cx.TenCX = txtTenCX.Text;
                cx.DiemDi = txtDiemDi.Text;
                cx.ChiTietDiemDi = txtChiTietDiemDi.Text;
                cx.DiemDen = txtDiemDen.Text;
                cx.ChiTietDiemDen = txtChiTietDiemDen.Text;
                cx.GioDi = txtGioDi.Text;
                cx.BangGia = decimal.Parse(txtGiaVe.Text.ToString());
                cx.MaXe = int.Parse(cbMaXe.SelectedValue.ToString());
                cx.MaNV = int.Parse(cbMaNV.SelectedValue.ToString());

                busCX.suaCX(cx);
                busCX.layDSCX(dGChuyenXe);
            }
        }

        private void btXoaCX_Click(object sender, EventArgs e)
        {
            ChuyenXe cx = new ChuyenXe();
            cx.MaCX = int.Parse(txtMSCX.Text);

            if (busCX.xoaCX(cx))
            {
                MessageBox.Show("Xóa chuyến xe thành công");
                busCX.layDSCX(dGChuyenXe);
            }
            else
            {
                MessageBox.Show("Xóa chuyến xe thất bại");
            }
        }

        //Form Load
        private void FQuanTri_Load(object sender, EventArgs e)
        {
            hienThiDSNV();
            hienThiDSXe();
            hienThiDSCX();
            busNV.layDSLoaiNV(cbChucVu);
            busXe.layDSLoaiXe(cbLoaiXe);
            busCX.layDSNV(cbMaNV);
            busCX.layDSXe(cbMaXe);
        }
    }
}
