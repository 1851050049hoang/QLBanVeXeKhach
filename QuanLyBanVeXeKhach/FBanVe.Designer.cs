
namespace QuanLyBanVeXeKhach
{
    partial class FBanVe
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
            this.dGChuyenXe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGioDi = new System.Windows.Forms.ComboBox();
            this.cbDiemDen = new System.Windows.Forms.ComboBox();
            this.cbDiemDi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGChuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dGChuyenXe
            // 
            this.dGChuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGChuyenXe.Location = new System.Drawing.Point(27, 151);
            this.dGChuyenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGChuyenXe.Name = "dGChuyenXe";
            this.dGChuyenXe.RowHeadersWidth = 51;
            this.dGChuyenXe.RowTemplate.Height = 24;
            this.dGChuyenXe.Size = new System.Drawing.Size(799, 247);
            this.dGChuyenXe.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giờ đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Điểm đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Điểm đi";
            // 
            // cbGioDi
            // 
            this.cbGioDi.FormattingEnabled = true;
            this.cbGioDi.Location = new System.Drawing.Point(505, 110);
            this.cbGioDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGioDi.Name = "cbGioDi";
            this.cbGioDi.Size = new System.Drawing.Size(121, 24);
            this.cbGioDi.TabIndex = 8;
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(292, 110);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(121, 24);
            this.cbDiemDen.TabIndex = 7;
            // 
            // cbDiemDi
            // 
            this.cbDiemDi.FormattingEnabled = true;
            this.cbDiemDi.Location = new System.Drawing.Point(97, 110);
            this.cbDiemDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDi.Name = "cbDiemDi";
            this.cbDiemDi.Size = new System.Drawing.Size(121, 24);
            this.cbDiemDi.TabIndex = 6;
            // 
            // FBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 449);
            this.Controls.Add(this.dGChuyenXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGioDi);
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.cbDiemDi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBanVe";
            ((System.ComponentModel.ISupportInitialize)(this.dGChuyenXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGChuyenXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioDi;
        private System.Windows.Forms.ComboBox cbDiemDen;
        private System.Windows.Forms.ComboBox cbDiemDi;
    }
}