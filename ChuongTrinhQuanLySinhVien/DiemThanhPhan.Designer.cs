namespace ChuongTrinhQuanLySinhVien
{
    partial class DiemThanhPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemThanhPhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxTieuDe = new System.Windows.Forms.PictureBox();
            this.labelDiemChiTiet = new System.Windows.Forms.Label();
            this.labelTenMonHoc = new System.Windows.Forms.Label();
            this.dataGridViewDiemChiTiet = new System.Windows.Forms.DataGridView();
            this.TenDiemThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTieuDe
            // 
            this.pictureBoxTieuDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTieuDe.BackgroundImage")));
            this.pictureBoxTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTieuDe.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxTieuDe.Name = "pictureBoxTieuDe";
            this.pictureBoxTieuDe.Size = new System.Drawing.Size(1085, 186);
            this.pictureBoxTieuDe.TabIndex = 15;
            this.pictureBoxTieuDe.TabStop = false;
            // 
            // labelDiemChiTiet
            // 
            this.labelDiemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiemChiTiet.ForeColor = System.Drawing.Color.Navy;
            this.labelDiemChiTiet.Location = new System.Drawing.Point(390, 216);
            this.labelDiemChiTiet.Name = "labelDiemChiTiet";
            this.labelDiemChiTiet.Size = new System.Drawing.Size(299, 53);
            this.labelDiemChiTiet.TabIndex = 16;
            this.labelDiemChiTiet.Text = "ĐIỂM CHI TIẾT";
            this.labelDiemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenMonHoc
            // 
            this.labelTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMonHoc.ForeColor = System.Drawing.Color.Navy;
            this.labelTenMonHoc.Location = new System.Drawing.Point(82, 285);
            this.labelTenMonHoc.Name = "labelTenMonHoc";
            this.labelTenMonHoc.Size = new System.Drawing.Size(393, 37);
            this.labelTenMonHoc.TabIndex = 18;
            this.labelTenMonHoc.Text = "Tên môn học: Tư Tưởng Hồ Chí Minh";
            this.labelTenMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewDiemChiTiet
            // 
            this.dataGridViewDiemChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiemChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDiemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiemChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDiemThanhPhan,
            this.DiemChiTiet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiemChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDiemChiTiet.Location = new System.Drawing.Point(94, 337);
            this.dataGridViewDiemChiTiet.Name = "dataGridViewDiemChiTiet";
            this.dataGridViewDiemChiTiet.RowTemplate.Height = 24;
            this.dataGridViewDiemChiTiet.Size = new System.Drawing.Size(873, 99);
            this.dataGridViewDiemChiTiet.TabIndex = 19;
            // 
            // TenDiemThanhPhan
            // 
            this.TenDiemThanhPhan.DataPropertyName = "TenDiemThanhPhan";
            this.TenDiemThanhPhan.FillWeight = 200F;
            this.TenDiemThanhPhan.HeaderText = "Tên thành phần";
            this.TenDiemThanhPhan.Name = "TenDiemThanhPhan";
            // 
            // DiemChiTiet
            // 
            this.DiemChiTiet.DataPropertyName = "DiemChiTiet";
            this.DiemChiTiet.HeaderText = "Điểm";
            this.DiemChiTiet.Name = "DiemChiTiet";
            // 
            // DiemThanhPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 607);
            this.Controls.Add(this.dataGridViewDiemChiTiet);
            this.Controls.Add(this.labelTenMonHoc);
            this.Controls.Add(this.labelDiemChiTiet);
            this.Controls.Add(this.pictureBoxTieuDe);
            this.MaximizeBox = false;
            this.Name = "DiemThanhPhan";
            this.Text = "Điểm thành phần ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTieuDe;
        private System.Windows.Forms.Label labelDiemChiTiet;
        private System.Windows.Forms.Label labelTenMonHoc;
        private System.Windows.Forms.DataGridView dataGridViewDiemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiemThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChiTiet;
    }
}