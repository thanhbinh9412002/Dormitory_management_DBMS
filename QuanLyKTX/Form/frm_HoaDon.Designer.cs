
namespace QuanLyKTX
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.btnLocHDchuathanhtoan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbbTImKiem = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbbMaPhongTK = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbbTImKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gbHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocHDchuathanhtoan
            // 
            this.btnLocHDchuathanhtoan.BackColor = System.Drawing.Color.LightCoral;
            this.btnLocHDchuathanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocHDchuathanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocHDchuathanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocHDchuathanhtoan.Location = new System.Drawing.Point(489, 469);
            this.btnLocHDchuathanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocHDchuathanhtoan.Name = "btnLocHDchuathanhtoan";
            this.btnLocHDchuathanhtoan.Size = new System.Drawing.Size(149, 47);
            this.btnLocHDchuathanhtoan.TabIndex = 99;
            this.btnLocHDchuathanhtoan.Text = "Hóa đơn chưa thanh toán";
            this.btnLocHDchuathanhtoan.UseVisualStyleBackColor = false;
            this.btnLocHDchuathanhtoan.Click += new System.EventHandler(this.btnLocHDchuathanhtoan_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyKTX.Properties.Resources.setting;
            this.btnSua.Location = new System.Drawing.Point(296, 468);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 48);
            this.btnSua.TabIndex = 98;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gbbTImKiem
            // 
            this.gbbTImKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbbTImKiem.Controls.Add(this.txtSoLuong);
            this.gbbTImKiem.Controls.Add(this.label11);
            this.gbbTImKiem.Controls.Add(this.btnLoc);
            this.gbbTImKiem.Controls.Add(this.cbbMaPhongTK);
            this.gbbTImKiem.Controls.Add(this.label7);
            this.gbbTImKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbbTImKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbTImKiem.Location = new System.Drawing.Point(489, 46);
            this.gbbTImKiem.Margin = new System.Windows.Forms.Padding(2);
            this.gbbTImKiem.Name = "gbbTImKiem";
            this.gbbTImKiem.Padding = new System.Windows.Forms.Padding(2);
            this.gbbTImKiem.Size = new System.Drawing.Size(245, 145);
            this.gbbTImKiem.TabIndex = 93;
            this.gbbTImKiem.TabStop = false;
            this.gbbTImKiem.Text = "Tìm kiếm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(110, 60);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(113, 26);
            this.txtSoLuong.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(26, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Số lượng";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::QuanLyKTX.Properties.Resources.Filter_icon;
            this.btnLoc.Location = new System.Drawing.Point(110, 96);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(77, 35);
            this.btnLoc.TabIndex = 65;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbbMaPhongTK
            // 
            this.cbbMaPhongTK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbMaPhongTK.FormattingEnabled = true;
            this.cbbMaPhongTK.Location = new System.Drawing.Point(110, 28);
            this.cbbMaPhongTK.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaPhongTK.Name = "cbbMaPhongTK";
            this.cbbMaPhongTK.Size = new System.Drawing.Size(113, 28);
            this.cbbMaPhongTK.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Mã Phòng";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 209);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(725, 247);
            this.dgvHoaDon.TabIndex = 92;
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbHoaDon.Controls.Add(this.cbbMaPhong);
            this.gbHoaDon.Controls.Add(this.label5);
            this.gbHoaDon.Controls.Add(this.cbTrangThai);
            this.gbHoaDon.Controls.Add(this.dateTimePicker1);
            this.gbHoaDon.Controls.Add(this.label3);
            this.gbHoaDon.Controls.Add(this.txtTienNuoc);
            this.gbHoaDon.Controls.Add(this.label1);
            this.gbHoaDon.Controls.Add(this.txtTienDien);
            this.gbHoaDon.Controls.Add(this.txtMaHD);
            this.gbHoaDon.Controls.Add(this.label8);
            this.gbHoaDon.Controls.Add(this.label6);
            this.gbHoaDon.Controls.Add(this.label4);
            this.gbHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbHoaDon.Location = new System.Drawing.Point(9, 46);
            this.gbHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.gbHoaDon.Size = new System.Drawing.Size(457, 145);
            this.gbHoaDon.TabIndex = 91;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Thông tin hóa đơn";
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(110, 63);
            this.cbbMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(113, 28);
            this.cbbMaPhong.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã Phòng";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đã Thanh toán",
            "Chưa thanh toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(110, 98);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(113, 28);
            this.cbTrangThai.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 96);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 4, 13, 33, 3, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(249, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày tạo";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTienNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienNuoc.Location = new System.Drawing.Point(333, 63);
            this.txtTienNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(113, 26);
            this.txtTienNuoc.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(242, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tiền nước";
            // 
            // txtTienDien
            // 
            this.txtTienDien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTienDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienDien.Location = new System.Drawing.Point(333, 31);
            this.txtTienDien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(113, 26);
            this.txtTienDien.TabIndex = 23;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Location = new System.Drawing.Point(110, 31);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(113, 26);
            this.txtMaHD.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(247, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tiền điện";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(2, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã hóa đơn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::QuanLyKTX.Properties.Resources.Restart_icon;
            this.btnLoad.Location = new System.Drawing.Point(392, 469);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 47);
            this.btnLoad.TabIndex = 97;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnHuy.Location = new System.Drawing.Point(200, 469);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 47);
            this.btnHuy.TabIndex = 96;
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
            this.btnLuu.Location = new System.Drawing.Point(105, 469);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 47);
            this.btnLuu.TabIndex = 95;
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
            this.btnThem.Location = new System.Drawing.Point(9, 469);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 47);
            this.btnThem.TabIndex = 94;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyKTX.Properties.Resources.back_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(642, 469);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 47);
            this.btnThoat.TabIndex = 100;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "HÓA ĐƠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(750, 531);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLocHDchuathanhtoan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbbTImKiem);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.gbHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.gbbTImKiem.ResumeLayout(false);
            this.gbbTImKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocHDchuathanhtoan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbbTImKiem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbbMaPhongTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
    }
}