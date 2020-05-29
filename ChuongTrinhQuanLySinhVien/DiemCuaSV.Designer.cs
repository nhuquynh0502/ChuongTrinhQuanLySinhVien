namespace ChuongTrinhQuanLySinhVien
{
    partial class DiemCuaSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemCuaSV));
            this.pictureBoxTieuDe = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTrangTri = new System.Windows.Forms.Label();
            this.labelMaSoSinhVien = new System.Windows.Forms.Label();
            this.labelTenSinhVien = new System.Windows.Forms.Label();
            this.flowLayoutPanelDiem = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTieuDe)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTieuDe
            // 
            this.pictureBoxTieuDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTieuDe.BackgroundImage")));
            this.pictureBoxTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTieuDe.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxTieuDe.Name = "pictureBoxTieuDe";
            this.pictureBoxTieuDe.Size = new System.Drawing.Size(1308, 186);
            this.pictureBoxTieuDe.TabIndex = 17;
            this.pictureBoxTieuDe.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTrangTri);
            this.panel1.Controls.Add(this.pictureBoxTieuDe);
            this.panel1.Controls.Add(this.labelMaSoSinhVien);
            this.panel1.Controls.Add(this.labelTenSinhVien);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 257);
            this.panel1.TabIndex = 0;
            // 
            // labelTrangTri
            // 
            this.labelTrangTri.AutoSize = true;
            this.labelTrangTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTrangTri.Location = new System.Drawing.Point(0, 239);
            this.labelTrangTri.Name = "labelTrangTri";
            this.labelTrangTri.Size = new System.Drawing.Size(1348, 17);
            this.labelTrangTri.TabIndex = 18;
            this.labelTrangTri.Text = resources.GetString("labelTrangTri.Text");
            // 
            // labelMaSoSinhVien
            // 
            this.labelMaSoSinhVien.AutoSize = true;
            this.labelMaSoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSoSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.labelMaSoSinhVien.Location = new System.Drawing.Point(413, 205);
            this.labelMaSoSinhVien.Name = "labelMaSoSinhVien";
            this.labelMaSoSinhVien.Size = new System.Drawing.Size(148, 25);
            this.labelMaSoSinhVien.TabIndex = 16;
            this.labelMaSoSinhVien.Text = "Mã số sinh viên";
            // 
            // labelTenSinhVien
            // 
            this.labelTenSinhVien.AutoSize = true;
            this.labelTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.labelTenSinhVien.Location = new System.Drawing.Point(3, 205);
            this.labelTenSinhVien.Name = "labelTenSinhVien";
            this.labelTenSinhVien.Size = new System.Drawing.Size(129, 25);
            this.labelTenSinhVien.TabIndex = 15;
            this.labelTenSinhVien.Text = "Tên sinh viên";
            // 
            // flowLayoutPanelDiem
            // 
            this.flowLayoutPanelDiem.AutoScroll = true;
            this.flowLayoutPanelDiem.Controls.Add(this.panel1);
            this.flowLayoutPanelDiem.Location = new System.Drawing.Point(-5, -7);
            this.flowLayoutPanelDiem.Name = "flowLayoutPanelDiem";
            this.flowLayoutPanelDiem.Size = new System.Drawing.Size(1312, 782);
            this.flowLayoutPanelDiem.TabIndex = 2;
            // 
            // DiemCuaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 769);
            this.Controls.Add(this.flowLayoutPanelDiem);
            this.MaximizeBox = false;
            this.Name = "DiemCuaSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm của sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTieuDe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelDiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTrangTri;
        private System.Windows.Forms.Label labelMaSoSinhVien;
        public System.Windows.Forms.Label labelTenSinhVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDiem;

    }
}