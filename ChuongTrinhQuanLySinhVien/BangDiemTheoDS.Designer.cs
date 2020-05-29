namespace ChuongTrinhQuanLySinhVien
{
    partial class BangDiemTheoDS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDiemTheoDS = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowlayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemTheoDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.FlowlayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDiemTheoDS
            // 
            this.dataGridViewDiemTheoDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiemTheoDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDiemTheoDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiemTheoDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.TinChi,
            this.LoaiMonHoc,
            this.Diem,
            this.DiemChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiemTheoDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDiemTheoDS.Location = new System.Drawing.Point(37, 3);
            this.dataGridViewDiemTheoDS.Name = "dataGridViewDiemTheoDS";
            this.dataGridViewDiemTheoDS.RowTemplate.Height = 24;
            this.dataGridViewDiemTheoDS.Size = new System.Drawing.Size(1237, 759);
            this.dataGridViewDiemTheoDS.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDiemTheoDS);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 777);
            this.panel1.TabIndex = 1;
            // 
            // FlowlayoutPanel1
            // 
            this.FlowlayoutPanel1.Controls.Add(this.panel1);
            this.FlowlayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.FlowlayoutPanel1.Name = "FlowlayoutPanel1";
            this.FlowlayoutPanel1.Size = new System.Drawing.Size(1500, 927);
            this.FlowlayoutPanel1.TabIndex = 2;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.FillWeight = 120F;
            this.MaHocPhan.HeaderText = "Mã học phần";
            this.MaHocPhan.Name = "MaHocPhan";
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.FillWeight = 250F;
            this.TenHocPhan.HeaderText = "Tên học phần";
            this.TenHocPhan.Name = "TenHocPhan";
            // 
            // TinChi
            // 
            this.TinChi.DataPropertyName = "TinChi";
            this.TinChi.FillWeight = 70F;
            this.TinChi.HeaderText = "Tín chỉ";
            this.TinChi.Name = "TinChi";
            // 
            // LoaiMonHoc
            // 
            this.LoaiMonHoc.DataPropertyName = "LoaiMonHoc";
            this.LoaiMonHoc.HeaderText = "Loại môn học";
            this.LoaiMonHoc.Name = "LoaiMonHoc";
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.FillWeight = 80F;
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            // 
            // DiemChi
            // 
            this.DiemChi.DataPropertyName = "DiemChi";
            this.DiemChi.FillWeight = 80F;
            this.DiemChi.HeaderText = "Điểm chỉ";
            this.DiemChi.Name = "DiemChi";
            // 
            // BangDiemTheoDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowlayoutPanel1);
            this.Name = "BangDiemTheoDS";
            this.Size = new System.Drawing.Size(1312, 782);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemTheoDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.FlowlayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiemTheoDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FlowlayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChi;
    }
}
