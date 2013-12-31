namespace Winform.GUI
{
    partial class FmBaoCaoDoanhThu
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
            this.dtgvKetQua = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btInBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbThu6 = new System.Windows.Forms.CheckBox();
            this.ckbThu3 = new System.Windows.Forms.CheckBox();
            this.ckbThu7 = new System.Windows.Forms.CheckBox();
            this.ckbThu4 = new System.Windows.Forms.CheckBox();
            this.ckbChuNhat = new System.Windows.Forms.CheckBox();
            this.ckbThu5 = new System.Windows.Forms.CheckBox();
            this.ckbThu2 = new System.Windows.Forms.CheckBox();
            this.dtpkTGDen = new System.Windows.Forms.DateTimePicker();
            this.dtpkTGTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTongCong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvKetQua
            // 
            this.dtgvKetQua.AllowUserToAddRows = false;
            this.dtgvKetQua.AllowUserToDeleteRows = false;
            this.dtgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dtgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKetQua.Location = new System.Drawing.Point(3, 16);
            this.dtgvKetQua.Name = "dtgvKetQua";
            this.dtgvKetQua.ReadOnly = true;
            this.dtgvKetQua.RowHeadersVisible = false;
            this.dtgvKetQua.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dtgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKetQua.Size = new System.Drawing.Size(533, 275);
            this.dtgvKetQua.TabIndex = 4;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(448, 431);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 45);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btInBaoCao
            // 
            this.btInBaoCao.Location = new System.Drawing.Point(342, 431);
            this.btInBaoCao.Name = "btInBaoCao";
            this.btInBaoCao.Size = new System.Drawing.Size(100, 45);
            this.btInBaoCao.TabIndex = 10;
            this.btInBaoCao.Text = "In Báo Cáo";
            this.btInBaoCao.UseVisualStyleBackColor = true;
            this.btInBaoCao.Click += new System.EventHandler(this.btInBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbThu6);
            this.groupBox1.Controls.Add(this.ckbThu7);
            this.groupBox1.Controls.Add(this.ckbThu4);
            this.groupBox1.Controls.Add(this.ckbChuNhat);
            this.groupBox1.Controls.Add(this.ckbThu3);
            this.groupBox1.Controls.Add(this.ckbThu5);
            this.groupBox1.Controls.Add(this.dtpkTGDen);
            this.groupBox1.Controls.Add(this.dtpkTGTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckbThu2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 75);
            this.groupBox1.TabIndex = 11;
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
            // ckbThu4
            // 
            this.ckbThu4.AutoSize = true;
            this.ckbThu4.Checked = true;
            this.ckbThu4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu4.Location = new System.Drawing.Point(312, 24);
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
            this.ckbChuNhat.Location = new System.Drawing.Point(312, 50);
            this.ckbChuNhat.Name = "ckbChuNhat";
            this.ckbChuNhat.Size = new System.Drawing.Size(71, 17);
            this.ckbChuNhat.TabIndex = 17;
            this.ckbChuNhat.Text = "Chủ Nhật";
            this.ckbChuNhat.UseVisualStyleBackColor = true;
            // 
            // ckbThu5
            // 
            this.ckbThu5.AutoSize = true;
            this.ckbThu5.Checked = true;
            this.ckbThu5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThu5.Location = new System.Drawing.Point(386, 24);
            this.ckbThu5.Name = "ckbThu5";
            this.ckbThu5.Size = new System.Drawing.Size(54, 17);
            this.ckbThu5.TabIndex = 16;
            this.ckbThu5.Text = "Thứ 5";
            this.ckbThu5.UseVisualStyleBackColor = true;
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
            // dtpkTGDen
            // 
            this.dtpkTGDen.CustomFormat = "dd/MM/yyyy";
            this.dtpkTGDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTGDen.Location = new System.Drawing.Point(43, 45);
            this.dtpkTGDen.Name = "dtpkTGDen";
            this.dtpkTGDen.Size = new System.Drawing.Size(100, 20);
            this.dtpkTGDen.TabIndex = 14;
            // 
            // dtpkTGTu
            // 
            this.dtpkTGTu.CustomFormat = "dd/MM/yyyy";
            this.dtpkTGTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTGTu.Location = new System.Drawing.Point(43, 19);
            this.dtpkTGTu.Name = "dtpkTGTu";
            this.dtpkTGTu.Size = new System.Drawing.Size(100, 20);
            this.dtpkTGTu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
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
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(476, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 75);
            this.btXem.TabIndex = 12;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvKetQua);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 294);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // lbTongCong
            // 
            this.lbTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCong.Location = new System.Drawing.Point(381, 404);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.Size = new System.Drawing.Size(122, 13);
            this.lbTongCong.TabIndex = 22;
            this.lbTongCong.Text = "0";
            this.lbTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "đồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng cộng :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masp_sp_ct";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_sp_ct";
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "mausac_sp_ct";
            this.Column5.HeaderText = "Màu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "thanhtien_to_string";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTongCong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btInBaoCao);
            this.Controls.Add(this.btThoat);
            this.Name = "FmBaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKetQua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btInBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbThu6;
        private System.Windows.Forms.CheckBox ckbThu3;
        private System.Windows.Forms.CheckBox ckbThu7;
        private System.Windows.Forms.CheckBox ckbThu4;
        private System.Windows.Forms.CheckBox ckbChuNhat;
        private System.Windows.Forms.CheckBox ckbThu5;
        private System.Windows.Forms.CheckBox ckbThu2;
        private System.Windows.Forms.DateTimePicker dtpkTGDen;
        private System.Windows.Forms.DateTimePicker dtpkTGTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTongCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}