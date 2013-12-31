namespace Winform.GUI
{
    partial class FmQuanLyNhapHang
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
            this.btThem = new System.Windows.Forms.Button();
            this.dtgvDSNhapHang = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(427, 104);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(427, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(140, 40);
            this.btXem.TabIndex = 8;
            this.btXem.Text = "Xem Chi Tiết";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(427, 58);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(140, 40);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtgvDSNhapHang
            // 
            this.dtgvDSNhapHang.AllowUserToAddRows = false;
            this.dtgvDSNhapHang.AllowUserToDeleteRows = false;
            this.dtgvDSNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ngay,
            this.tongtien,
            this.active});
            this.dtgvDSNhapHang.Location = new System.Drawing.Point(12, 11);
            this.dtgvDSNhapHang.Name = "dtgvDSNhapHang";
            this.dtgvDSNhapHang.ReadOnly = true;
            this.dtgvDSNhapHang.RowHeadersVisible = false;
            this.dtgvDSNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSNhapHang.Size = new System.Drawing.Size(409, 277);
            this.dtgvDSNhapHang.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
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
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Kích hoạt";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.active.Width = 80;
            // 
            // FmQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 303);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgvDSNhapHang);
            this.Name = "FmQuanLyNhapHang";
            this.Text = "Quản Lý Nhập Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dtgvDSNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;

    }
}