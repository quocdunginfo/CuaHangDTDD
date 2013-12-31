namespace Winform.GUI
{
    partial class FmQuanLyHangSanXuat
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
            this.dtgvHangSX = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkKichHoat = new System.Windows.Forms.CheckBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangSX)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHangSX
            // 
            this.dtgvHangSX.AllowUserToAddRows = false;
            this.dtgvHangSX.AllowUserToDeleteRows = false;
            this.dtgvHangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvHangSX.Location = new System.Drawing.Point(12, 12);
            this.dtgvHangSX.Name = "dtgvHangSX";
            this.dtgvHangSX.ReadOnly = true;
            this.dtgvHangSX.RowHeadersVisible = false;
            this.dtgvHangSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangSX.Size = new System.Drawing.Size(307, 178);
            this.dtgvHangSX.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(325, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(140, 40);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(325, 150);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 40);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(325, 104);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(140, 40);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(325, 58);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(140, 40);
            this.btSua.TabIndex = 17;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btHuy);
            this.gbThongTin.Controls.Add(this.btLuu);
            this.gbThongTin.Controls.Add(this.chkKichHoat);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.tbTen);
            this.gbThongTin.Controls.Add(this.tbID);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Enabled = false;
            this.gbThongTin.Location = new System.Drawing.Point(12, 196);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(307, 81);
            this.gbThongTin.TabIndex = 18;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(47, 19);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(64, 20);
            this.tbID.TabIndex = 19;
            this.tbID.Text = "0";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(47, 45);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(164, 20);
            this.tbTen.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên:";
            // 
            // chkKichHoat
            // 
            this.chkKichHoat.AutoSize = true;
            this.chkKichHoat.Location = new System.Drawing.Point(138, 21);
            this.chkKichHoat.Name = "chkKichHoat";
            this.chkKichHoat.Size = new System.Drawing.Size(73, 17);
            this.chkKichHoat.TabIndex = 24;
            this.chkKichHoat.Text = "Kích hoạt";
            this.chkKichHoat.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(226, 17);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 25;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(226, 46);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 26;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "active";
            this.Column3.HeaderText = "Kích Hoạt";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FmQuanLyHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 285);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgvHangSX);
            this.Name = "FmQuanLyHangSanXuat";
            this.Text = "Quản Lý Hãng Sản Xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangSX)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHangSX;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.CheckBox chkKichHoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}