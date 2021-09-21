
namespace QuanLyBanVeXeKhach
{
    partial class FQuanTri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChuyenXe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNV,
            this.menuChuyenXe,
            this.menuXe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNV
            // 
            this.menuNV.Name = "menuNV";
            this.menuNV.Size = new System.Drawing.Size(89, 24);
            this.menuNV.Text = "Nhân viên";
            this.menuNV.Click += new System.EventHandler(this.menuNV_Click);
            // 
            // menuChuyenXe
            // 
            this.menuChuyenXe.Name = "menuChuyenXe";
            this.menuChuyenXe.Size = new System.Drawing.Size(90, 24);
            this.menuChuyenXe.Text = "Chuyến xe";
            this.menuChuyenXe.Click += new System.EventHandler(this.menuChuyenXe_Click);
            // 
            // menuXe
            // 
            this.menuXe.Name = "menuXe";
            this.menuXe.Size = new System.Drawing.Size(40, 24);
            this.menuXe.Text = "Xe";
            this.menuXe.Click += new System.EventHandler(this.menuXe_Click);
            // 
            // FQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FQuanTri";
            this.Text = "FQuanTri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNV;
        private System.Windows.Forms.ToolStripMenuItem menuChuyenXe;
        private System.Windows.Forms.ToolStripMenuItem menuXe;
    }
}