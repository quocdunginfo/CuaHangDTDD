namespace Winform.GUI
{
    partial class FmQuanLyDonHang
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.dtgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btChuyenTrangThaiDonHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(692, 150);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(692, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(140, 40);
            this.btXem.TabIndex = 13;
            this.btXem.Text = "Xem Chi Tiết";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // dtgvDSDonHang
            // 
            this.dtgvDSDonHang.AllowUserToAddRows = false;
            this.dtgvDSDonHang.AllowUserToDeleteRows = false;
            this.dtgvDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.ngay,
            this.tongtien,
            this.Column1,
            this.active});
            this.dtgvDSDonHang.Location = new System.Drawing.Point(12, 12);
            this.dtgvDSDonHang.Name = "dtgvDSDonHang";
            this.dtgvDSDonHang.ReadOnly = true;
            this.dtgvDSDonHang.RowHeadersVisible = false;
            this.dtgvDSDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSDonHang.Size = new System.Drawing.Size(674, 277);
            this.dtgvDSDonHang.TabIndex = 11;
            this.dtgvDSDonHang.SelectionChanged += new System.EventHandler(this.dtgvDSDonHang_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "kh_ten";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "kh_sdt";
            this.Column3.HeaderText = "Số ĐT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay_to_string";
            this.ngay.HeaderText = "Thời gian";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien_change";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dagiaohang";
            this.Column1.HeaderText = "Giao hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 80;
            // 
            // active
            // 
            this.active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Kích hoạt";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(692, 104);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(140, 40);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btChuyenTrangThaiDonHang
            // 
            this.btChuyenTrangThaiDonHang.Location = new System.Drawing.Point(692, 58);
            this.btChuyenTrangThaiDonHang.Name = "btChuyenTrangThaiDonHang";
            this.btChuyenTrangThaiDonHang.Size = new System.Drawing.Size(140, 40);
            this.btChuyenTrangThaiDonHang.TabIndex = 16;
            this.btChuyenTrangThaiDonHang.Text = "Chuyển Trạng Thái ĐH";
            this.btChuyenTrangThaiDonHang.UseVisualStyleBackColor = true;
            this.btChuyenTrangThaiDonHang.Click += new System.EventHandler(this.btChuyenTrangThaiDonHang_Click);
            // 
            // FmQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 296);
            this.Controls.Add(this.btChuyenTrangThaiDonHang);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dtgvDSDonHang);
            this.Name = "FmQuanLyDonHang";
            this.Text = "Quản Lý Đơn Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.DataGridView dtgvDSDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btChuyenTrangThaiDonHang;
    }
}