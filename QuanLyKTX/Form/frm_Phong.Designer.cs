namespace QuanLyKTX
{
    partial class frm_Phong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSinhVienHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSinhVienToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinPhong = new System.Windows.Forms.GroupBox();
            this.txtToa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSVToiDa = new System.Windows.Forms.TextBox();
            this.txtSVHienTai = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhongConCho = new System.Windows.Forms.Button();
            this.btnThietBiTrongPhong = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChiTietPhong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiemPhongDay = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.gbThongTinPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.Toa,
            this.SoLuongSinhVienHienTai,
            this.SoLuongSinhVienToiDa});
            this.dgvPhong.Location = new System.Drawing.Point(12, 46);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(458, 244);
            this.dgvPhong.TabIndex = 71;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // Toa
            // 
            this.Toa.DataPropertyName = "Toa";
            this.Toa.HeaderText = "Tòa";
            this.Toa.MinimumWidth = 6;
            this.Toa.Name = "Toa";
            this.Toa.Width = 125;
            // 
            // SoLuongSinhVienHienTai
            // 
            this.SoLuongSinhVienHienTai.DataPropertyName = "SoLuongSinhVienHienTai";
            this.SoLuongSinhVienHienTai.HeaderText = "Sinh Viên Hiện Tại";
            this.SoLuongSinhVienHienTai.MinimumWidth = 6;
            this.SoLuongSinhVienHienTai.Name = "SoLuongSinhVienHienTai";
            this.SoLuongSinhVienHienTai.Width = 150;
            // 
            // SoLuongSinhVienToiDa
            // 
            this.SoLuongSinhVienToiDa.DataPropertyName = "SoLuongSinhVienToiDa";
            this.SoLuongSinhVienToiDa.HeaderText = "Sinh Viên Tối Đa";
            this.SoLuongSinhVienToiDa.MinimumWidth = 6;
            this.SoLuongSinhVienToiDa.Name = "SoLuongSinhVienToiDa";
            this.SoLuongSinhVienToiDa.Width = 150;
            // 
            // gbThongTinPhong
            // 
            this.gbThongTinPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinPhong.Controls.Add(this.txtToa);
            this.gbThongTinPhong.Controls.Add(this.label5);
            this.gbThongTinPhong.Controls.Add(this.txtSVToiDa);
            this.gbThongTinPhong.Controls.Add(this.txtSVHienTai);
            this.gbThongTinPhong.Controls.Add(this.txtMaPhong);
            this.gbThongTinPhong.Controls.Add(this.label4);
            this.gbThongTinPhong.Controls.Add(this.label3);
            this.gbThongTinPhong.Controls.Add(this.label2);
            this.gbThongTinPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinPhong.Location = new System.Drawing.Point(476, 46);
            this.gbThongTinPhong.Name = "gbThongTinPhong";
            this.gbThongTinPhong.Size = new System.Drawing.Size(285, 175);
            this.gbThongTinPhong.TabIndex = 76;
            this.gbThongTinPhong.TabStop = false;
            this.gbThongTinPhong.Text = "Thông tin phòng";
            // 
            // txtToa
            // 
            this.txtToa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtToa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToa.Enabled = false;
            this.txtToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToa.Location = new System.Drawing.Point(144, 56);
            this.txtToa.Multiline = true;
            this.txtToa.Name = "txtToa";
            this.txtToa.Size = new System.Drawing.Size(112, 29);
            this.txtToa.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tòa";
            // 
            // txtSVToiDa
            // 
            this.txtSVToiDa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSVToiDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSVToiDa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVToiDa.Location = new System.Drawing.Point(144, 126);
            this.txtSVToiDa.Multiline = true;
            this.txtSVToiDa.Name = "txtSVToiDa";
            this.txtSVToiDa.Size = new System.Drawing.Size(112, 29);
            this.txtSVToiDa.TabIndex = 50;
            // 
            // txtSVHienTai
            // 
            this.txtSVHienTai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSVHienTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSVHienTai.Enabled = false;
            this.txtSVHienTai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVHienTai.Location = new System.Drawing.Point(144, 91);
            this.txtSVHienTai.Multiline = true;
            this.txtSVHienTai.Name = "txtSVHienTai";
            this.txtSVHienTai.Size = new System.Drawing.Size(112, 29);
            this.txtSVHienTai.TabIndex = 48;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(144, 21);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(112, 29);
            this.txtMaPhong.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sinh viên hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sinh viên tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "QUẢN LÍ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPhongConCho
            // 
            this.btnPhongConCho.BackColor = System.Drawing.Color.LightCoral;
            this.btnPhongConCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongConCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongConCho.Image = global::QuanLyKTX.Properties.Resources.Filter_icon;
            this.btnPhongConCho.Location = new System.Drawing.Point(514, 305);
            this.btnPhongConCho.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhongConCho.Name = "btnPhongConCho";
            this.btnPhongConCho.Size = new System.Drawing.Size(218, 44);
            this.btnPhongConCho.TabIndex = 79;
            this.btnPhongConCho.Text = "Tìm kiếm phòng còn chỗ";
            this.btnPhongConCho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhongConCho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongConCho.UseVisualStyleBackColor = false;
            this.btnPhongConCho.Click += new System.EventHandler(this.btnPhongConCho_Click);
            // 
            // btnThietBiTrongPhong
            // 
            this.btnThietBiTrongPhong.BackColor = System.Drawing.Color.LightCoral;
            this.btnThietBiTrongPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThietBiTrongPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBiTrongPhong.Image = global::QuanLyKTX.Properties.Resources.device_icon;
            this.btnThietBiTrongPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBiTrongPhong.Location = new System.Drawing.Point(364, 365);
            this.btnThietBiTrongPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThietBiTrongPhong.Name = "btnThietBiTrongPhong";
            this.btnThietBiTrongPhong.Size = new System.Drawing.Size(192, 44);
            this.btnThietBiTrongPhong.TabIndex = 83;
            this.btnThietBiTrongPhong.Text = "Thiết bị trong phòng";
            this.btnThietBiTrongPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietBiTrongPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBiTrongPhong.UseVisualStyleBackColor = false;
            this.btnThietBiTrongPhong.Click += new System.EventHandler(this.btnThietBiTrongPhong_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::QuanLyKTX.Properties.Resources.Restart_icon;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(12, 305);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoad.Size = new System.Drawing.Size(91, 44);
            this.btnLoad.TabIndex = 81;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyKTX.Properties.Resources.back_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(220, 305);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 44);
            this.btnThoat.TabIndex = 80;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChiTietPhong
            // 
            this.btnChiTietPhong.BackColor = System.Drawing.Color.LightCoral;
            this.btnChiTietPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietPhong.Image = global::QuanLyKTX.Properties.Resources.room_icon;
            this.btnChiTietPhong.Location = new System.Drawing.Point(160, 365);
            this.btnChiTietPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietPhong.Name = "btnChiTietPhong";
            this.btnChiTietPhong.Size = new System.Drawing.Size(151, 44);
            this.btnChiTietPhong.TabIndex = 78;
            this.btnChiTietPhong.Text = "Chi Tiết Phòng";
            this.btnChiTietPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietPhong.UseVisualStyleBackColor = false;
            this.btnChiTietPhong.Click += new System.EventHandler(this.btnChiTietPhong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(575, 246);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 44);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiemPhongDay
            // 
            this.btnTimKiemPhongDay.BackColor = System.Drawing.Color.LightCoral;
            this.btnTimKiemPhongDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiemPhongDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhongDay.Image = global::QuanLyKTX.Properties.Resources.Filter_icon;
            this.btnTimKiemPhongDay.Location = new System.Drawing.Point(315, 305);
            this.btnTimKiemPhongDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemPhongDay.Name = "btnTimKiemPhongDay";
            this.btnTimKiemPhongDay.Size = new System.Drawing.Size(195, 44);
            this.btnTimKiemPhongDay.TabIndex = 75;
            this.btnTimKiemPhongDay.Text = "Tìm kiếm phòng đủ";
            this.btnTimKiemPhongDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhongDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemPhongDay.UseVisualStyleBackColor = false;
            this.btnTimKiemPhongDay.Click += new System.EventHandler(this.btnTimKiemPhongDay_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(117, 305);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 44);
            this.btnHuy.TabIndex = 74;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCoral;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyKTX.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(670, 246);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 44);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyKTX.Properties.Resources.add_icon;
            this.btnThem.Location = new System.Drawing.Point(476, 246);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 44);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(774, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnThietBiTrongPhong);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPhongConCho);
            this.Controls.Add(this.btnChiTietPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.gbThongTinPhong);
            this.Controls.Add(this.btnTimKiemPhongDay);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.gbThongTinPhong.ResumeLayout(false);
            this.gbThongTinPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPhongConCho;
        private System.Windows.Forms.Button btnChiTietPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSinhVienHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSinhVienToiDa;
        private System.Windows.Forms.GroupBox gbThongTinPhong;
        private System.Windows.Forms.TextBox txtToa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSVToiDa;
        private System.Windows.Forms.TextBox txtSVHienTai;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiemPhongDay;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThietBiTrongPhong;
        private System.Windows.Forms.Label label1;
    }
}