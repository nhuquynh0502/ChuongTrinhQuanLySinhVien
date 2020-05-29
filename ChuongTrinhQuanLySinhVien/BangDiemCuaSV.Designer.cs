namespace ChuongTrinhQuanLySinhVien
{
    partial class BangDiemCuaSV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowlayoutPanelDiem = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.NienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDiemCuaSV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.FlowlayoutPanelDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemCuaSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDiemCuaSV);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 889);
            this.panel1.TabIndex = 1;
            // 
            // FlowlayoutPanelDiem
            // 
            this.FlowlayoutPanelDiem.Controls.Add(this.panel1);
            this.FlowlayoutPanelDiem.Location = new System.Drawing.Point(3, 3);
            this.FlowlayoutPanelDiem.Name = "FlowlayoutPanelDiem";
            this.FlowlayoutPanelDiem.Size = new System.Drawing.Size(1413, 470);
            this.FlowlayoutPanelDiem.TabIndex = 3;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(699, 489);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(152, 44);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(909, 489);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(152, 44);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(1115, 489);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(152, 44);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // NienKhoa
            // 
            this.NienKhoa.DataPropertyName = "NienKhoa";
            this.NienKhoa.HeaderText = "Niên khóa";
            this.NienKhoa.Name = "NienKhoa";
            this.NienKhoa.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.FillWeight = 70F;
            this.HocKy.HeaderText = "Học kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.FillWeight = 80F;
            this.DiemThi.HeaderText = "Điểm thi";
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.ReadOnly = true;
            // 
            // DiemQT
            // 
            this.DiemQT.DataPropertyName = "DiemQT";
            this.DiemQT.FillWeight = 80F;
            this.DiemQT.HeaderText = "Điểm quá trình";
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.ReadOnly = true;
            // 
            // DiemChi
            // 
            this.DiemChi.DataPropertyName = "DiemChi";
            this.DiemChi.FillWeight = 80F;
            this.DiemChi.HeaderText = "Điểm chỉ";
            this.DiemChi.Name = "DiemChi";
            this.DiemChi.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.FillWeight = 80F;
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // LoaiMonHoc
            // 
            this.LoaiMonHoc.DataPropertyName = "LoaiMonHoc";
            this.LoaiMonHoc.HeaderText = "Loại môn học";
            this.LoaiMonHoc.Name = "LoaiMonHoc";
            this.LoaiMonHoc.ReadOnly = true;
            // 
            // TinChi
            // 
            this.TinChi.DataPropertyName = "TinChi";
            this.TinChi.FillWeight = 70F;
            this.TinChi.HeaderText = "Tín chỉ";
            this.TinChi.Name = "TinChi";
            this.TinChi.ReadOnly = true;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.FillWeight = 250F;
            this.TenHocPhan.HeaderText = "Tên học phần";
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.ReadOnly = true;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.FillWeight = 120F;
            this.MaHocPhan.HeaderText = "Mã học phần";
            this.MaHocPhan.Name = "MaHocPhan";
            this.MaHocPhan.ReadOnly = true;
            // 
            // dataGridViewDiemCuaSV
            // 
            this.dataGridViewDiemCuaSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiemCuaSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDiemCuaSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiemCuaSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.TinChi,
            this.LoaiMonHoc,
            this.Diem,
            this.DiemChi,
            this.DiemQT,
            this.DiemThi,
            this.HocKy,
            this.NienKhoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiemCuaSV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDiemCuaSV.Location = new System.Drawing.Point(33, 3);
            this.dataGridViewDiemCuaSV.Name = "dataGridViewDiemCuaSV";
            this.dataGridViewDiemCuaSV.ReadOnly = true;
            this.dataGridViewDiemCuaSV.RowTemplate.Height = 24;
            this.dataGridViewDiemCuaSV.Size = new System.Drawing.Size(1228, 452);
            this.dataGridViewDiemCuaSV.TabIndex = 0;
            // 
            // BangDiemCuaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.FlowlayoutPanelDiem);
            this.Name = "BangDiemCuaSV";
            this.Size = new System.Drawing.Size(1326, 563);
            this.panel1.ResumeLayout(false);
            this.FlowlayoutPanelDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemCuaSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FlowlayoutPanelDiem;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView dataGridViewDiemCuaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NienKhoa;
    }
}
