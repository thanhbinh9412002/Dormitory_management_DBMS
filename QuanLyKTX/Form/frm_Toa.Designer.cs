namespace QuanLyKTX
{
    partial class frm_Toa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTietToa = new System.Windows.Forms.Button();
            this.gbThongTinToa = new System.Windows.Forms.GroupBox();
            this.txtMaNQL = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtTenToa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.TenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguoiQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhongConCho = new System.Windows.Forms.Button();
            this.btnPhongDay = new System.Windows.Forms.Button();
            this.gbThongTinToa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyKTX.Properties.Resources.back_icon;
            this.btnThoat.Location = new System.Drawing.Point(623, 186);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 44);
            this.btnThoat.TabIndex = 79;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(623, 138);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 44);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTietToa
            // 
            this.btnChiTietToa.BackColor = System.Drawing.Color.LightCoral;
            this.btnChiTietToa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChiTietToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietToa.Image = global::QuanLyKTX.Properties.Resources.company;
            this.btnChiTietToa.Location = new System.Drawing.Point(197, 234);
            this.btnChiTietToa.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietToa.Name = "btnChiTietToa";
            this.btnChiTietToa.Size = new System.Drawing.Size(156, 44);
            this.btnChiTietToa.TabIndex = 77;
            this.btnChiTietToa.Text = "Chi Tiết Tòa";
            this.btnChiTietToa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietToa.UseVisualStyleBackColor = false;
            this.btnChiTietToa.Click += new System.EventHandler(this.btnChiTietToa_Click);
            // 
            // gbThongTinToa
            // 
            this.gbThongTinToa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinToa.Controls.Add(this.txtMaNQL);
            this.gbThongTinToa.Controls.Add(this.txtSoPhong);
            this.gbThongTinToa.Controls.Add(this.txtTenToa);
            this.gbThongTinToa.Controls.Add(this.label7);
            this.gbThongTinToa.Controls.Add(this.label6);
            this.gbThongTinToa.Controls.Add(this.label3);
            this.gbThongTinToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinToa.Location = new System.Drawing.Point(392, 43);
            this.gbThongTinToa.Name = "gbThongTinToa";
            this.gbThongTinToa.Size = new System.Drawing.Size(226, 160);
            this.gbThongTinToa.TabIndex = 75;
            this.gbThongTinToa.TabStop = false;
            this.gbThongTinToa.Text = "Thông tin tòa";
            // 
            // txtMaNQL
            // 
            this.txtMaNQL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaNQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNQL.Location = new System.Drawing.Point(102, 101);
            this.txtMaNQL.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNQL.Name = "txtMaNQL";
            this.txtMaNQL.Size = new System.Drawing.Size(113, 26);
            this.txtMaNQL.TabIndex = 20;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhong.Location = new System.Drawing.Point(102, 71);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(113, 26);
            this.txtSoPhong.TabIndex = 19;
            // 
            // txtTenToa
            // 
            this.txtTenToa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenToa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenToa.Location = new System.Drawing.Point(102, 41);
            this.txtTenToa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenToa.Name = "txtTenToa";
            this.txtTenToa.Size = new System.Drawing.Size(113, 26);
            this.txtTenToa.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã QL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên tòa";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnHuy.Location = new System.Drawing.Point(633, 234);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 44);
            this.btnHuy.TabIndex = 74;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyKTX.Properties.Resources.setting;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(623, 91);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 44);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCoral;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyKTX.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(520, 234);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 44);
            this.btnLuu.TabIndex = 72;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QuanLyKTX.Properties.Resources.add_icon;
            this.btnThem.Location = new System.Drawing.Point(623, 43);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 44);
            this.btnThem.TabIndex = 71;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "TÒA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvToa
            // 
            this.dgvToa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenToa,
            this.SoPhong,
            this.MaNguoiQuanLy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvToa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvToa.Location = new System.Drawing.Point(19, 43);
            this.dgvToa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.RowHeadersWidth = 51;
            this.dgvToa.RowTemplate.Height = 24;
            this.dgvToa.Size = new System.Drawing.Size(353, 160);
            this.dgvToa.TabIndex = 76;
            this.dgvToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToa_CellClick);
            // 
            // TenToa
            // 
            this.TenToa.DataPropertyName = "TenToa";
            this.TenToa.HeaderText = "Tên tòa";
            this.TenToa.Name = "TenToa";
            this.TenToa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            // 
            // MaNguoiQuanLy
            // 
            this.MaNguoiQuanLy.DataPropertyName = "MaNguoiQuanLy";
            this.MaNguoiQuanLy.HeaderText = "Mã Người QL";
            this.MaNguoiQuanLy.Name = "MaNguoiQuanLy";
            // 
            // btnPhongConCho
            // 
            this.btnPhongConCho.BackColor = System.Drawing.Color.LightCoral;
            this.btnPhongConCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongConCho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongConCho.Image = global::QuanLyKTX.Properties.Resources.room_icon;
            this.btnPhongConCho.Location = new System.Drawing.Point(11, 234);
            this.btnPhongConCho.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhongConCho.Name = "btnPhongConCho";
            this.btnPhongConCho.Size = new System.Drawing.Size(157, 44);
            this.btnPhongConCho.TabIndex = 80;
            this.btnPhongConCho.Text = "Phòng Còn Chỗ";
            this.btnPhongConCho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongConCho.UseVisualStyleBackColor = false;
            this.btnPhongConCho.Click += new System.EventHandler(this.btnPhongConCho_Click);
            // 
            // btnPhongDay
            // 
            this.btnPhongDay.BackColor = System.Drawing.Color.LightCoral;
            this.btnPhongDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongDay.Image = global::QuanLyKTX.Properties.Resources.room_icon;
            this.btnPhongDay.Location = new System.Drawing.Point(375, 234);
            this.btnPhongDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhongDay.Name = "btnPhongDay";
            this.btnPhongDay.Size = new System.Drawing.Size(128, 44);
            this.btnPhongDay.TabIndex = 81;
            this.btnPhongDay.Text = "Phòng Đầy";
            this.btnPhongDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhongDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongDay.UseVisualStyleBackColor = false;
            this.btnPhongDay.Click += new System.EventHandler(this.btnPhongDay_Click);
            // 
            // frm_Toa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(726, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btnPhongDay);
            this.Controls.Add(this.btnPhongConCho);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTietToa);
            this.Controls.Add(this.gbThongTinToa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvToa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Toa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tòa";
            this.Load += new System.EventHandler(this.frm_Toa_Load);
            this.gbThongTinToa.ResumeLayout(false);
            this.gbThongTinToa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTietToa;
        private System.Windows.Forms.GroupBox gbThongTinToa;
        private System.Windows.Forms.TextBox txtMaNQL;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtTenToa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguoiQuanLy;
        private System.Windows.Forms.Button btnPhongConCho;
        private System.Windows.Forms.Button btnPhongDay;
    }
}