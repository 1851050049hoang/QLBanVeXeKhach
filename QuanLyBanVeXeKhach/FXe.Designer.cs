
namespace QuanLyBanVeXeKhach
{
    partial class FXe
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
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dGXe = new System.Windows.Forms.DataGridView();
            this.nUDSoGhe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dGXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(51, 50);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(100, 22);
            this.txtMaXe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biển số";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(206, 50);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 22);
            this.txtBienSo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại xe";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Location = new System.Drawing.Point(371, 50);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(133, 24);
            this.cbLoaiXe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số ghế";
            // 
            // dGXe
            // 
            this.dGXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGXe.Location = new System.Drawing.Point(12, 156);
            this.dGXe.Name = "dGXe";
            this.dGXe.RowHeadersWidth = 51;
            this.dGXe.RowTemplate.Height = 24;
            this.dGXe.Size = new System.Drawing.Size(776, 282);
            this.dGXe.TabIndex = 8;
            // 
            // nUDSoGhe
            // 
            this.nUDSoGhe.Location = new System.Drawing.Point(550, 50);
            this.nUDSoGhe.Name = "nUDSoGhe";
            this.nUDSoGhe.Size = new System.Drawing.Size(120, 22);
            this.nUDSoGhe.TabIndex = 9;
            // 
            // FXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nUDSoGhe);
            this.Controls.Add(this.dGXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaXe);
            this.Name = "FXe";
            ((System.ComponentModel.ISupportInitialize)(this.dGXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGXe;
        private System.Windows.Forms.NumericUpDown nUDSoGhe;
    }
}