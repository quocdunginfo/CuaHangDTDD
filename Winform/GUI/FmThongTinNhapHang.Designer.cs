namespace Winform.GUI
{
    partial class FmThongTinNhapHang
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
            this.dtgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongdan_thumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macdinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkNgay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbKichHoat = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dtgvChiTietSP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDSSanPham = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbDSSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChiTietNH
            // 
            this.dtgvChiTietNH.AllowUserToAddRows = false;
            this.dtgvChiTietNH.AllowUserToDeleteRows = false;
            this.dtgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.soluong,
            this.duongdan_thumb,
            this.macdinh,
            this.hinhanh});
            this.dtgvChiTietNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietNH.Location = new System.Drawing.Point(3, 16);
            this.dtgvChiTietNH.Name = "dtgvChiTietNH";
            this.dtgvChiTietNH.ReadOnly = true;
            this.dtgvChiTietNH.RowHeadersVisible = false;
            this.dtgvChiTietNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietNH.Size = new System.Drawing.Size(494, 219);
            this.dtgvChiTietNH.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // duongdan_thumb
            // 
            this.duongdan_thumb.DataPropertyName = "dongia_to_string";
            this.duongdan_thumb.HeaderText = "Đơn giá";
            this.duongdan_thumb.Name = "duongdan_thumb";
            this.duongdan_thumb.ReadOnly = true;
            // 
            // macdinh
            // 
            this.macdinh.DataPropertyName = "ten_sanpham_chitiet";
            this.macdinh.HeaderText = "Tên Sp";
            this.macdinh.Name = "macdinh";
            this.macdinh.ReadOnly = true;
            this.macdinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // hinhanh
            // 
            this.hinhanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinhanh.DataPropertyName = "mau_sanpham_chitiet";
            this.hinhanh.HeaderText = "Màu sắc";
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            this.hinhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(739, 368);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkNgay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ckbKichHoat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTongTien);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 105);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtpkNgay
            // 
            this.dtpkNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpkNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgay.Location = new System.Drawing.Point(109, 45);
            this.dtpkNgay.Name = "dtpkNgay";
            this.dtpkNgay.Size = new System.Drawing.Size(161, 20);
            this.dtpkNgay.TabIndex = 25;
            this.dtpkNgay.Value = new System.DateTime(2013, 12, 10, 10, 22, 2, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "đồng";
            // 
            // ckbKichHoat
            // 
            this.ckbKichHoat.AutoSize = true;
            this.ckbKichHoat.Checked = true;
            this.ckbKichHoat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKichHoat.Location = new System.Drawing.Point(197, 21);
            this.ckbKichHoat.Name = "ckbKichHoat";
            this.ckbKichHoat.Size = new System.Drawing.Size(73, 17);
            this.ckbKichHoat.TabIndex = 13;
            this.ckbKichHoat.Text = "Kích hoạt";
            this.ckbKichHoat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền :";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(109, 71);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(117, 20);
            this.tbTongTien.TabIndex = 4;
            this.tbTongTien.Text = "0";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 22);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(109, 19);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(58, 20);
            this.tbID.TabIndex = 1;
            // 
            // dtgvChiTietSP
            // 
            this.dtgvChiTietSP.AllowUserToAddRows = false;
            this.dtgvChiTietSP.AllowUserToDeleteRows = false;
            this.dtgvChiTietSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgvChiTietSP.Location = new System.Drawing.Point(6, 45);
            this.dtgvChiTietSP.Name = "dtgvChiTietSP";
            this.dtgvChiTietSP.ReadOnly = true;
            this.dtgvChiTietSP.RowHeadersVisible = false;
            this.dtgvChiTietSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietSP.Size = new System.Drawing.Size(293, 184);
            this.dtgvChiTietSP.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sanpham";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Sp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mausac";
            this.dataGridViewTextBoxColumn5.HeaderText = "Màu sắc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(518, 226);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(50, 23);
            this.btThem.TabIndex = 21;
            this.btThem.Text = "+";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số lượng :";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(67, 19);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(44, 20);
            this.tbSoLuong.TabIndex = 18;
            this.tbSoLuong.Text = "0";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(593, 368);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(140, 40);
            this.btLuu.TabIndex = 24;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(192, 19);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(107, 20);
            this.tbDonGia.TabIndex = 25;
            this.tbDonGia.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đơn giá :";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(518, 255);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(50, 23);
            this.btXoa.TabIndex = 27;
            this.btXoa.Text = "--";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietNH);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 238);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết đơn nhập hàng";
            // 
            // gbDSSanPham
            // 
            this.gbDSSanPham.Controls.Add(this.dtgvChiTietSP);
            this.gbDSSanPham.Controls.Add(this.tbDonGia);
            this.gbDSSanPham.Controls.Add(this.label1);
            this.gbDSSanPham.Controls.Add(this.tbSoLuong);
            this.gbDSSanPham.Controls.Add(this.label2);
            this.gbDSSanPham.Location = new System.Drawing.Point(574, 124);
            this.gbDSSanPham.Name = "gbDSSanPham";
            this.gbDSSanPham.Size = new System.Drawing.Size(305, 235);
            this.gbDSSanPham.TabIndex = 30;
            this.gbDSSanPham.TabStop = false;
            this.gbDSSanPham.Text = "Danh sách sản phẩm hiện có";
            // 
            // FmThongTinNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 420);
            this.Controls.Add(this.gbDSSanPham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmThongTinNhapHang";
            this.Text = "Thông Tin Nhập Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmThongTinNhapHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbDSSanPham.ResumeLayout(false);
            this.gbDSSanPham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiTietNH;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbKichHoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dtgvChiTietSP;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DateTimePicker dtpkNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongdan_thumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn macdinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhanh;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbDSSanPham;
    }
}