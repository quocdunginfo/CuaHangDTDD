namespace Winform.GUI
{
    partial class FmQuanLySanPham
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
            this.dtgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hangsx_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSSanPham
            // 
            this.dtgvDSSanPham.AllowUserToAddRows = false;
            this.dtgvDSSanPham.AllowUserToDeleteRows = false;
            this.dtgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masp,
            this.ten,
            this.hinhanh,
            this.gia,
            this.active,
            this.hangsx_ten});
            this.dtgvDSSanPham.Location = new System.Drawing.Point(12, 58);
            this.dtgvDSSanPham.MultiSelect = false;
            this.dtgvDSSanPham.Name = "dtgvDSSanPham";
            this.dtgvDSSanPham.ReadOnly = true;
            this.dtgvDSSanPham.RowHeadersVisible = false;
            this.dtgvDSSanPham.RowTemplate.Height = 70;
            this.dtgvDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSSanPham.Size = new System.Drawing.Size(930, 417);
            this.dtgvDSSanPham.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(364, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(140, 40);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(510, 12);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(140, 40);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(656, 12);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(140, 40);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(802, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sp";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 120;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên Sp";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 260;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "anhmacdinh";
            this.hinhanh.HeaderText = "Hình ảnh";
            this.hinhanh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            this.hinhanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hinhanh.Width = 120;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "giasp";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 120;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Kích hoạt";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.active.Width = 80;
            // 
            // hangsx_ten
            // 
            this.hangsx_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hangsx_ten.DataPropertyName = "hangsx";
            this.hangsx_ten.HeaderText = "Hãng Sản Xuất";
            this.hangsx_ten.Name = "hangsx_ten";
            this.hangsx_ten.ReadOnly = true;
            this.hangsx_ten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgvDSSanPham);
            this.Name = "FmQuanLySanPham";
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSSanPham;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx_ten;
    }
}