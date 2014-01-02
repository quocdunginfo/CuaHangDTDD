namespace Winform.GUI
{
    partial class FmThongTinSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHangSX = new System.Windows.Forms.ComboBox();
            this.ckbKichHoat = new System.Windows.Forms.CheckBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDatLamAnhMacDinh = new System.Windows.Forms.Button();
            this.btThemHinhAnh = new System.Windows.Forms.Button();
            this.btXoaHinhAnh = new System.Windows.Forms.Button();
            this.dtgvHinhAnh = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btThemMau = new System.Windows.Forms.Button();
            this.btHuyChiTietSP = new System.Windows.Forms.Button();
            this.btLuuChiTietSP = new System.Windows.Forms.Button();
            this.cbMauSac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTonKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbKichHoatChiTietSP = new System.Windows.Forms.CheckBox();
            this.btThemChiTietSP = new System.Windows.Forms.Button();
            this.btSuaChiTietSP = new System.Windows.Forms.Button();
            this.btXoaChiTietSP = new System.Windows.Forms.Button();
            this.dtgvChiTietSanPham = new System.Windows.Forms.DataGridView();
            this.chitietsp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongdan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongdan_thumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macdinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHinhAnh)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSanPham)).BeginInit();
            this.SuspendLayout();
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
            this.tbID.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbHangSX);
            this.groupBox1.Controls.Add(this.ckbKichHoat);
            this.groupBox1.Controls.Add(this.rtbMoTa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMaSP);
            this.groupBox1.Controls.Add(this.tbTenSP);
            this.groupBox1.Controls.Add(this.tbGia);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(đồng)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mô tả";
            // 
            // cbHangSX
            // 
            this.cbHangSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHangSX.FormattingEnabled = true;
            this.cbHangSX.Location = new System.Drawing.Point(109, 123);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(161, 21);
            this.cbHangSX.TabIndex = 4;
            // 
            // ckbKichHoat
            // 
            this.ckbKichHoat.AutoSize = true;
            this.ckbKichHoat.Checked = true;
            this.ckbKichHoat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKichHoat.Location = new System.Drawing.Point(266, 19);
            this.ckbKichHoat.Name = "ckbKichHoat";
            this.ckbKichHoat.Size = new System.Drawing.Size(73, 17);
            this.ckbKichHoat.TabIndex = 6;
            this.ckbKichHoat.Text = "Kích hoạt";
            this.ckbKichHoat.UseVisualStyleBackColor = true;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(366, 28);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(325, 121);
            this.rtbMoTa.TabIndex = 5;
            this.rtbMoTa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên SP:";
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(109, 45);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(117, 20);
            this.tbMaSP.TabIndex = 1;
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(109, 71);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(230, 20);
            this.tbTenSP.TabIndex = 2;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(109, 97);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(117, 20);
            this.tbGia.TabIndex = 3;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(567, 471);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(421, 471);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(140, 40);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 292);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDatLamAnhMacDinh);
            this.tabPage1.Controls.Add(this.btThemHinhAnh);
            this.tabPage1.Controls.Add(this.btXoaHinhAnh);
            this.tabPage1.Controls.Add(this.dtgvHinhAnh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hình Ảnh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDatLamAnhMacDinh
            // 
            this.btDatLamAnhMacDinh.Location = new System.Drawing.Point(389, 6);
            this.btDatLamAnhMacDinh.Name = "btDatLamAnhMacDinh";
            this.btDatLamAnhMacDinh.Size = new System.Drawing.Size(130, 23);
            this.btDatLamAnhMacDinh.TabIndex = 8;
            this.btDatLamAnhMacDinh.Text = "Đặt làm ảnh mặc định";
            this.btDatLamAnhMacDinh.UseVisualStyleBackColor = true;
            this.btDatLamAnhMacDinh.Click += new System.EventHandler(this.btDatLamAnhMacDinh_Click);
            // 
            // btThemHinhAnh
            // 
            this.btThemHinhAnh.Location = new System.Drawing.Point(525, 6);
            this.btThemHinhAnh.Name = "btThemHinhAnh";
            this.btThemHinhAnh.Size = new System.Drawing.Size(75, 23);
            this.btThemHinhAnh.TabIndex = 7;
            this.btThemHinhAnh.Text = "Thêm";
            this.btThemHinhAnh.UseVisualStyleBackColor = true;
            this.btThemHinhAnh.Click += new System.EventHandler(this.btThemHinhAnh_Click);
            // 
            // btXoaHinhAnh
            // 
            this.btXoaHinhAnh.Location = new System.Drawing.Point(606, 6);
            this.btXoaHinhAnh.Name = "btXoaHinhAnh";
            this.btXoaHinhAnh.Size = new System.Drawing.Size(75, 23);
            this.btXoaHinhAnh.TabIndex = 5;
            this.btXoaHinhAnh.Text = "Xoá";
            this.btXoaHinhAnh.UseVisualStyleBackColor = true;
            this.btXoaHinhAnh.Click += new System.EventHandler(this.btXoaHinhAnh_Click);
            // 
            // dtgvHinhAnh
            // 
            this.dtgvHinhAnh.AllowUserToAddRows = false;
            this.dtgvHinhAnh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHinhAnh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHinhAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHinhAnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hinhanh_id,
            this.duongdan,
            this.duongdan_thumb,
            this.macdinh,
            this.hinhanh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHinhAnh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHinhAnh.Location = new System.Drawing.Point(6, 35);
            this.dtgvHinhAnh.Name = "dtgvHinhAnh";
            this.dtgvHinhAnh.ReadOnly = true;
            this.dtgvHinhAnh.RowHeadersVisible = false;
            this.dtgvHinhAnh.RowTemplate.Height = 70;
            this.dtgvHinhAnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHinhAnh.Size = new System.Drawing.Size(675, 225);
            this.dtgvHinhAnh.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbThongTin);
            this.tabPage2.Controls.Add(this.btThemChiTietSP);
            this.tabPage2.Controls.Add(this.btSuaChiTietSP);
            this.tabPage2.Controls.Add(this.btXoaChiTietSP);
            this.tabPage2.Controls.Add(this.dtgvChiTietSanPham);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btThemMau);
            this.gbThongTin.Controls.Add(this.btHuyChiTietSP);
            this.gbThongTin.Controls.Add(this.btLuuChiTietSP);
            this.gbThongTin.Controls.Add(this.cbMauSac);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.tbTonKho);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.ckbKichHoatChiTietSP);
            this.gbThongTin.Enabled = false;
            this.gbThongTin.Location = new System.Drawing.Point(444, 35);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(237, 126);
            this.gbThongTin.TabIndex = 4;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // btThemMau
            // 
            this.btThemMau.Location = new System.Drawing.Point(155, 66);
            this.btThemMau.Name = "btThemMau";
            this.btThemMau.Size = new System.Drawing.Size(75, 23);
            this.btThemMau.TabIndex = 22;
            this.btThemMau.Text = "Thêm màu";
            this.btThemMau.UseVisualStyleBackColor = true;
            this.btThemMau.Click += new System.EventHandler(this.btThemMau_Click);
            // 
            // btHuyChiTietSP
            // 
            this.btHuyChiTietSP.Location = new System.Drawing.Point(155, 95);
            this.btHuyChiTietSP.Name = "btHuyChiTietSP";
            this.btHuyChiTietSP.Size = new System.Drawing.Size(75, 23);
            this.btHuyChiTietSP.TabIndex = 21;
            this.btHuyChiTietSP.Text = "Huỷ";
            this.btHuyChiTietSP.UseVisualStyleBackColor = true;
            this.btHuyChiTietSP.Click += new System.EventHandler(this.btHuyChiTietSP_Click);
            // 
            // btLuuChiTietSP
            // 
            this.btLuuChiTietSP.Location = new System.Drawing.Point(74, 95);
            this.btLuuChiTietSP.Name = "btLuuChiTietSP";
            this.btLuuChiTietSP.Size = new System.Drawing.Size(75, 23);
            this.btLuuChiTietSP.TabIndex = 5;
            this.btLuuChiTietSP.Text = "Lưu";
            this.btLuuChiTietSP.UseVisualStyleBackColor = true;
            this.btLuuChiTietSP.Click += new System.EventHandler(this.btLuuChiTietSP_Click);
            // 
            // cbMauSac
            // 
            this.cbMauSac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMauSac.FormattingEnabled = true;
            this.cbMauSac.Location = new System.Drawing.Point(64, 68);
            this.cbMauSac.Name = "cbMauSac";
            this.cbMauSac.Size = new System.Drawing.Size(85, 21);
            this.cbMauSac.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Màu sắc :";
            // 
            // tbTonKho
            // 
            this.tbTonKho.Location = new System.Drawing.Point(64, 42);
            this.tbTonKho.Name = "tbTonKho";
            this.tbTonKho.ReadOnly = true;
            this.tbTonKho.Size = new System.Drawing.Size(75, 20);
            this.tbTonKho.TabIndex = 18;
            this.tbTonKho.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tồn kho :";
            // 
            // ckbKichHoatChiTietSP
            // 
            this.ckbKichHoatChiTietSP.AutoSize = true;
            this.ckbKichHoatChiTietSP.Checked = true;
            this.ckbKichHoatChiTietSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKichHoatChiTietSP.Location = new System.Drawing.Point(8, 19);
            this.ckbKichHoatChiTietSP.Name = "ckbKichHoatChiTietSP";
            this.ckbKichHoatChiTietSP.Size = new System.Drawing.Size(73, 17);
            this.ckbKichHoatChiTietSP.TabIndex = 0;
            this.ckbKichHoatChiTietSP.Text = "Kích hoạt";
            this.ckbKichHoatChiTietSP.UseVisualStyleBackColor = true;
            // 
            // btThemChiTietSP
            // 
            this.btThemChiTietSP.Location = new System.Drawing.Point(444, 6);
            this.btThemChiTietSP.Name = "btThemChiTietSP";
            this.btThemChiTietSP.Size = new System.Drawing.Size(75, 23);
            this.btThemChiTietSP.TabIndex = 3;
            this.btThemChiTietSP.Text = "Thêm";
            this.btThemChiTietSP.UseVisualStyleBackColor = true;
            this.btThemChiTietSP.Click += new System.EventHandler(this.btThemChiTietSP_Click);
            // 
            // btSuaChiTietSP
            // 
            this.btSuaChiTietSP.Location = new System.Drawing.Point(525, 6);
            this.btSuaChiTietSP.Name = "btSuaChiTietSP";
            this.btSuaChiTietSP.Size = new System.Drawing.Size(75, 23);
            this.btSuaChiTietSP.TabIndex = 2;
            this.btSuaChiTietSP.Text = "Sửa";
            this.btSuaChiTietSP.UseVisualStyleBackColor = true;
            this.btSuaChiTietSP.Click += new System.EventHandler(this.btSuaChiTietSP_Click);
            // 
            // btXoaChiTietSP
            // 
            this.btXoaChiTietSP.Location = new System.Drawing.Point(606, 6);
            this.btXoaChiTietSP.Name = "btXoaChiTietSP";
            this.btXoaChiTietSP.Size = new System.Drawing.Size(75, 23);
            this.btXoaChiTietSP.TabIndex = 1;
            this.btXoaChiTietSP.Text = "Xoá";
            this.btXoaChiTietSP.UseVisualStyleBackColor = true;
            this.btXoaChiTietSP.Click += new System.EventHandler(this.btXoaChiTietSP_Click);
            // 
            // dtgvChiTietSanPham
            // 
            this.dtgvChiTietSanPham.AllowUserToAddRows = false;
            this.dtgvChiTietSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chitietsp_id,
            this.active,
            this.tonkho,
            this.giatri});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvChiTietSanPham.Location = new System.Drawing.Point(6, 6);
            this.dtgvChiTietSanPham.Name = "dtgvChiTietSanPham";
            this.dtgvChiTietSanPham.ReadOnly = true;
            this.dtgvChiTietSanPham.RowHeadersVisible = false;
            this.dtgvChiTietSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietSanPham.Size = new System.Drawing.Size(408, 254);
            this.dtgvChiTietSanPham.TabIndex = 0;
            // 
            // chitietsp_id
            // 
            this.chitietsp_id.DataPropertyName = "id";
            this.chitietsp_id.HeaderText = "ID";
            this.chitietsp_id.Name = "chitietsp_id";
            this.chitietsp_id.ReadOnly = true;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Kích hoạt";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tonkho
            // 
            this.tonkho.DataPropertyName = "tonkho";
            this.tonkho.HeaderText = "Tồn kho";
            this.tonkho.Name = "tonkho";
            this.tonkho.ReadOnly = true;
            // 
            // giatri
            // 
            this.giatri.DataPropertyName = "mausac";
            this.giatri.HeaderText = "Màu sắc";
            this.giatri.Name = "giatri";
            this.giatri.ReadOnly = true;
            // 
            // hinhanh_id
            // 
            this.hinhanh_id.DataPropertyName = "id";
            this.hinhanh_id.HeaderText = "ID";
            this.hinhanh_id.Name = "hinhanh_id";
            this.hinhanh_id.ReadOnly = true;
            // 
            // duongdan
            // 
            this.duongdan.DataPropertyName = "duongdan";
            this.duongdan.HeaderText = "Đường dẫn";
            this.duongdan.Name = "duongdan";
            this.duongdan.ReadOnly = true;
            // 
            // duongdan_thumb
            // 
            this.duongdan_thumb.DataPropertyName = "duongdan_thumb";
            this.duongdan_thumb.HeaderText = "Đường dẫn_thumb";
            this.duongdan_thumb.Name = "duongdan_thumb";
            this.duongdan_thumb.ReadOnly = true;
            this.duongdan_thumb.Width = 150;
            // 
            // macdinh
            // 
            this.macdinh.DataPropertyName = "macdinh";
            this.macdinh.HeaderText = "Mặc định";
            this.macdinh.Name = "macdinh";
            this.macdinh.ReadOnly = true;
            this.macdinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.macdinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "anh";
            this.hinhanh.HeaderText = "Hình ảnh";
            this.hinhanh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            this.hinhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hinhanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hinhanh.Width = 150;
            // 
            // FmThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmThongTinSanPham";
            this.Text = "Thông Tin Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmThongTinSanPham_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHinhAnh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHangSX;
        private System.Windows.Forms.CheckBox ckbKichHoat;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvChiTietSanPham;
        private System.Windows.Forms.Button btThemChiTietSP;
        private System.Windows.Forms.Button btSuaChiTietSP;
        private System.Windows.Forms.Button btXoaChiTietSP;
        private System.Windows.Forms.Button btThemHinhAnh;
        private System.Windows.Forms.Button btXoaHinhAnh;
        private System.Windows.Forms.DataGridView dtgvHinhAnh;
        private System.Windows.Forms.Button btDatLamAnhMacDinh;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btLuuChiTietSP;
        private System.Windows.Forms.ComboBox cbMauSac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTonKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbKichHoatChiTietSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn chitietsp_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatri;
        private System.Windows.Forms.Button btHuyChiTietSP;
        private System.Windows.Forms.Button btThemMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhanh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongdan;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongdan_thumb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn macdinh;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
    }
}