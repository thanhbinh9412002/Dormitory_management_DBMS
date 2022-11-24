
namespace QuanLyKTX
{
    partial class frm_ThietBiTrongPhong
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
            this.cbbMaPhongTimKiem = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.gbThongTinThietBi = new System.Windows.Forms.GroupBox();
            this.txtTenTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cbbMaThietBi = new System.Windows.Forms.ComboBox();
            this.txtSoLuongToiDa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongHong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.gbThongTinThietBi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbMaPhongTimKiem
            // 
            this.cbbMaPhongTimKiem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbMaPhongTimKiem.FormattingEnabled = true;
            this.cbbMaPhongTimKiem.Location = new System.Drawing.Point(556, 64);
            this.cbbMaPhongTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaPhongTimKiem.Name = "cbbMaPhongTimKiem";
            this.cbbMaPhongTimKiem.Size = new System.Drawing.Size(119, 21);
            this.cbbMaPhongTimKiem.TabIndex = 96;
            this.cbbMaPhongTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhongTimKiem_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyKTX.Properties.Resources.setting;
            this.btnSua.Location = new System.Drawing.Point(496, 396);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 44);
            this.btnSua.TabIndex = 106;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::QuanLyKTX.Properties.Resources.Restart_icon;
            this.btnLoad.Location = new System.Drawing.Point(556, 161);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 44);
            this.btnLoad.TabIndex = 105;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnXoa.Location = new System.Drawing.Point(250, 396);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 44);
            this.btnXoa.TabIndex = 104;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyKTX.Properties.Resources.Filter_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(556, 98);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 44);
            this.btnTimKiem.TabIndex = 103;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyKTX.Properties.Resources.remove_icon;
            this.btnHuy.Location = new System.Drawing.Point(373, 396);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 44);
            this.btnHuy.TabIndex = 102;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCoral;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyKTX.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(127, 396);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 44);
            this.btnLuu.TabIndex = 101;
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
            this.btnThem.Image = global::QuanLyKTX.Properties.Resources.add_icon;
            this.btnThem.Location = new System.Drawing.Point(6, 396);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 44);
            this.btnThem.TabIndex = 100;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Tìm kiếm";
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(6, 45);
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.Size = new System.Drawing.Size(537, 182);
            this.dgvThietBi.TabIndex = 98;
            // 
            // gbThongTinThietBi
            // 
            this.gbThongTinThietBi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinThietBi.Controls.Add(this.txtTenTb);
            this.gbThongTinThietBi.Controls.Add(this.label6);
            this.gbThongTinThietBi.Controls.Add(this.txtMaPhong);
            this.gbThongTinThietBi.Controls.Add(this.cbbMaThietBi);
            this.gbThongTinThietBi.Controls.Add(this.txtSoLuongToiDa);
            this.gbThongTinThietBi.Controls.Add(this.label5);
            this.gbThongTinThietBi.Controls.Add(this.txtSoLuongTot);
            this.gbThongTinThietBi.Controls.Add(this.label4);
            this.gbThongTinThietBi.Controls.Add(this.txtSoLuongHong);
            this.gbThongTinThietBi.Controls.Add(this.label3);
            this.gbThongTinThietBi.Controls.Add(this.label7);
            this.gbThongTinThietBi.Controls.Add(this.label1);
            this.gbThongTinThietBi.Location = new System.Drawing.Point(6, 240);
            this.gbThongTinThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinThietBi.Name = "gbThongTinThietBi";
            this.gbThongTinThietBi.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinThietBi.Size = new System.Drawing.Size(537, 141);
            this.gbThongTinThietBi.TabIndex = 97;
            this.gbThongTinThietBi.TabStop = false;
            this.gbThongTinThietBi.Text = "Thông tin thiết bị";
            // 
            // txtTenTb
            // 
            this.txtTenTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTb.Location = new System.Drawing.Point(404, 97);
            this.txtTenTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTb.Name = "txtTenTb";
            this.txtTenTb.Size = new System.Drawing.Size(113, 20);
            this.txtTenTb.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tên thiết bị";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Location = new System.Drawing.Point(145, 64);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(113, 20);
            this.txtMaPhong.TabIndex = 22;
            // 
            // cbbMaThietBi
            // 
            this.cbbMaThietBi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbMaThietBi.FormattingEnabled = true;
            this.cbbMaThietBi.Location = new System.Drawing.Point(145, 29);
            this.cbbMaThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaThietBi.Name = "cbbMaThietBi";
            this.cbbMaThietBi.Size = new System.Drawing.Size(113, 21);
            this.cbbMaThietBi.TabIndex = 21;
            this.cbbMaThietBi.SelectedIndexChanged += new System.EventHandler(this.cbbMaThietBi_SelectedIndexChanged);
            // 
            // txtSoLuongToiDa
            // 
            this.txtSoLuongToiDa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoLuongToiDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongToiDa.Location = new System.Drawing.Point(404, 63);
            this.txtSoLuongToiDa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            this.txtSoLuongToiDa.Size = new System.Drawing.Size(113, 20);
            this.txtSoLuongToiDa.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số lượng tối đa";
            // 
            // txtSoLuongTot
            // 
            this.txtSoLuongTot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoLuongTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongTot.Location = new System.Drawing.Point(404, 32);
            this.txtSoLuongTot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongTot.Name = "txtSoLuongTot";
            this.txtSoLuongTot.Size = new System.Drawing.Size(113, 20);
            this.txtSoLuongTot.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng tốt";
            // 
            // txtSoLuongHong
            // 
            this.txtSoLuongHong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoLuongHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongHong.Location = new System.Drawing.Point(145, 97);
            this.txtSoLuongHong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongHong.Name = "txtSoLuongHong";
            this.txtSoLuongHong.Size = new System.Drawing.Size(113, 20);
            this.txtSoLuongHong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng hỏng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã thiết bị";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyKTX.Properties.Resources.back_icon;
            this.btnThoat.Location = new System.Drawing.Point(556, 226);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 44);
            this.btnThoat.TabIndex = 107;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Aquamarine;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(689, 32);
            this.label8.TabIndex = 108;
            this.label8.Text = "THIẾT BỊ TRONG PHÒNG";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ThietBiTrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(689, 457);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbbMaPhongTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.gbThongTinThietBi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ThietBiTrongPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thiết bị trong phòng";
            this.Load += new System.EventHandler(this.frm_ThietBiTrongPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.gbThongTinThietBi.ResumeLayout(false);
            this.gbThongTinThietBi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaPhongTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.GroupBox gbThongTinThietBi;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbbMaThietBi;
        private System.Windows.Forms.TextBox txtSoLuongToiDa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuongHong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label8;
    }
}