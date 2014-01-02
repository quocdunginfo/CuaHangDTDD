namespace Winform.GUI
{
    partial class FmThongKeTonKho
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
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgvKetQua = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbThu6 = new System.Windows.Forms.CheckBox();
            this.ckbThu4 = new System.Windows.Forms.CheckBox();
            this.ckbChuNhat = new System.Windows.Forms.CheckBox();
            this.ckbThu7 = new System.Windows.Forms.CheckBox();
            this.ckbThu3 = new System.Windows.Forms.CheckBox();
            this.ckbThu5 = new System.Windows.Forms.CheckBox();
            this.dtpkTGDen = new System.Windows.Forms.DateTimePicker();
            this.ckbThu2 = new System.Windows.Forms.CheckBox();
            this.dtpkTGTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToAddRows = false;
            this.dtgvSanPham.AllowUserToDeleteRows = false;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.chon});
            this.dtgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSanPham.Location = new System.Drawing.Point(3, 16);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.ReadOnly = true;
            this.dtgvSanPham.RowHeadersVisible = false;
            this.dtgvSanPham.RowTemplate.Height = 70;
            this.dtgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSanPham.Size = new System.Drawing.Size(537, 379);
            this.dtgvSanPham.TabIndex = 7;
            this.dtgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanPham_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "masp_spct";
            this.Column2.HeaderText = "Mã SP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten_spct";
            this.Column3.HeaderText = "Tên SP";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "mausac";
            this.Column5.HeaderText = "Màu Sắc";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "anhmacdinh_spct";
            this.Column4.HeaderText = "Hình Ảnh";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // chon
            // 
            this.chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.ReadOnly = true;
            // 
            // dtgvKetQua
            // 
            this.dtgvKetQua.AllowUserToAddRows = false;
            this.dtgvKetQua.AllowUserToDeleteRows = false;
            this.dtgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dtgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKetQua.Location = new System.Drawing.Point(3, 16);
            this.dtgvKetQua.Name = "dtgvKetQua";
            this.dtgvKetQua.ReadOnly = true;
            this.dtgvKetQua.RowHeadersVisible = false;
            this.dtgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKetQua.Size = new System.Drawing.Size(542, 457);
            this.dtgvKetQua.TabIndex = 8;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã SP";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tên SP";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 170;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ngày";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Tồn Kho";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btThongKe
            // 
            this.btThongKe.Location = new System.Drawing.Point(480, 12);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(75, 75);
            this.btThongKe.TabIndex = 9;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbThu6);
            this.groupBox1.Controls.Add(this.ckbThu4);
            this.groupBox1.Controls.Add(this.ckbChuNhat);
            this.groupBox1.Controls.Add(this.ckbThu7);
            this.groupBox1.Controls.Add(this.ckbThu3);
            this.groupBox1.Controls.Add(this.ckbThu5);
            this.groupBox1.Controls.Add(this.dtpkTGDen);
            this.groupBox1.Controls.Add(this.ckbThu2);
            this.groupBox1.Controls.Add(this.dtpkTGTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian";
            // 
            // ckbThu6
            // 
            this.ckbThu6.AutoSize = true;
            this.ckbThu6.Checked = true;
            this.ckbThu6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu6.Location = new System.Drawing.Point(165, 50);
            this.ckbThu6.Name = "ckbThu6";
            this.ckbThu6.Size = new System.Drawing.Size(54, 17);
            this.ckbThu6.TabIndex = 21;
            this.ckbThu6.Text = "Thứ 6";
            this.ckbThu6.UseVisualStyleBackColor = true;
            // 
            // ckbThu4
            // 
            this.ckbThu4.AutoSize = true;
            this.ckbThu4.Checked = true;
            this.ckbThu4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu4.Location = new System.Drawing.Point(313, 24);
            this.ckbThu4.Name = "ckbThu4";
            this.ckbThu4.Size = new System.Drawing.Size(54, 17);
            this.ckbThu4.TabIndex = 18;
            this.ckbThu4.Text = "Thứ 4";
            this.ckbThu4.UseVisualStyleBackColor = true;
            // 
            // ckbChuNhat
            // 
            this.ckbChuNhat.AutoSize = true;
            this.ckbChuNhat.Checked = true;
            this.ckbChuNhat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbChuNhat.Location = new System.Drawing.Point(313, 50);
            this.ckbChuNhat.Name = "ckbChuNhat";
            this.ckbChuNhat.Size = new System.Drawing.Size(71, 17);
            this.ckbChuNhat.TabIndex = 17;
            this.ckbChuNhat.Text = "Chủ Nhật";
            this.ckbChuNhat.UseVisualStyleBackColor = true;
            // 
            // ckbThu7
            // 
            this.ckbThu7.AutoSize = true;
            this.ckbThu7.Checked = true;
            this.ckbThu7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu7.Location = new System.Drawing.Point(239, 50);
            this.ckbThu7.Name = "ckbThu7";
            this.ckbThu7.Size = new System.Drawing.Size(54, 17);
            this.ckbThu7.TabIndex = 19;
            this.ckbThu7.Text = "Thứ 7";
            this.ckbThu7.UseVisualStyleBackColor = true;
            // 
            // ckbThu3
            // 
            this.ckbThu3.AutoSize = true;
            this.ckbThu3.Checked = true;
            this.ckbThu3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu3.Location = new System.Drawing.Point(239, 24);
            this.ckbThu3.Name = "ckbThu3";
            this.ckbThu3.Size = new System.Drawing.Size(54, 17);
            this.ckbThu3.TabIndex = 20;
            this.ckbThu3.Text = "Thứ 3";
            this.ckbThu3.UseVisualStyleBackColor = true;
            // 
            // ckbThu5
            // 
            this.ckbThu5.AutoSize = true;
            this.ckbThu5.Checked = true;
            this.ckbThu5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu5.Location = new System.Drawing.Point(387, 24);
            this.ckbThu5.Name = "ckbThu5";
            this.ckbThu5.Size = new System.Drawing.Size(54, 17);
            this.ckbThu5.TabIndex = 16;
            this.ckbThu5.Text = "Thứ 5";
            this.ckbThu5.UseVisualStyleBackColor = true;
            // 
            // dtpkTGDen
            // 
            this.dtpkTGDen.CustomFormat = "dd/MM/yyyy";
            this.dtpkTGDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTGDen.Location = new System.Drawing.Point(48, 45);
            this.dtpkTGDen.Name = "dtpkTGDen";
            this.dtpkTGDen.Size = new System.Drawing.Size(100, 20);
            this.dtpkTGDen.TabIndex = 14;
            // 
            // ckbThu2
            // 
            this.ckbThu2.AutoSize = true;
            this.ckbThu2.Checked = true;
            this.ckbThu2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu2.Location = new System.Drawing.Point(165, 24);
            this.ckbThu2.Name = "ckbThu2";
            this.ckbThu2.Size = new System.Drawing.Size(54, 17);
            this.ckbThu2.TabIndex = 15;
            this.ckbThu2.Text = "Thứ 2";
            this.ckbThu2.UseVisualStyleBackColor = true;
            // 
            // dtpkTGTu
            // 
            this.dtpkTGTu.CustomFormat = "dd/MM/yyyy";
            this.dtpkTGTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTGTu.Location = new System.Drawing.Point(48, 19);
            this.dtpkTGTu.Name = "dtpkTGTu";
            this.dtpkTGTu.Size = new System.Drawing.Size(100, 20);
            this.dtpkTGTu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 398);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn sản phẩm cần thống kê";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvKetQua);
            this.groupBox3.Location = new System.Drawing.Point(592, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 476);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(1024, 494);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 44);
            this.btThoat.TabIndex = 13;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 547);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThongKe);
            this.Name = "FmThongKeTonKho";
            this.Text = "Thống Kê Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.DataGridView dtgvKetQua;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkTGTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbThu6;
        private System.Windows.Forms.CheckBox ckbThu3;
        private System.Windows.Forms.CheckBox ckbThu7;
        private System.Windows.Forms.CheckBox ckbThu4;
        private System.Windows.Forms.CheckBox ckbChuNhat;
        private System.Windows.Forms.CheckBox ckbThu5;
        private System.Windows.Forms.CheckBox ckbThu2;
        private System.Windows.Forms.DateTimePicker dtpkTGDen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
    }
}