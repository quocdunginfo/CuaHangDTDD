namespace Winform
{
    partial class NhanVien_ChiTiet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_Active = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TenDayDu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.comboBox_LoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_Active);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_TenDayDu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_Reset);
            this.panel1.Controls.Add(this.button_Luu);
            this.panel1.Controls.Add(this.comboBox_LoaiNhanVien);
            this.panel1.Controls.Add(this.textBox_MatKhau);
            this.panel1.Controls.Add(this.textBox_Email);
            this.panel1.Controls.Add(this.textBox_TenDangNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 224);
            this.panel1.TabIndex = 0;
            // 
            // checkBox_Active
            // 
            this.checkBox_Active.AutoSize = true;
            this.checkBox_Active.Location = new System.Drawing.Point(119, 120);
            this.checkBox_Active.Name = "checkBox_Active";
            this.checkBox_Active.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Active.TabIndex = 14;
            this.checkBox_Active.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Active:";
            // 
            // textBox_TenDayDu
            // 
            this.textBox_TenDayDu.Location = new System.Drawing.Point(119, 36);
            this.textBox_TenDayDu.Name = "textBox_TenDayDu";
            this.textBox_TenDayDu.Size = new System.Drawing.Size(171, 20);
            this.textBox_TenDayDu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên đầy đủ:";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(119, 179);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 10;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_Luu
            // 
            this.button_Luu.Location = new System.Drawing.Point(215, 179);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(75, 23);
            this.button_Luu.TabIndex = 9;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // comboBox_LoaiNhanVien
            // 
            this.comboBox_LoaiNhanVien.FormattingEnabled = true;
            this.comboBox_LoaiNhanVien.Location = new System.Drawing.Point(119, 143);
            this.comboBox_LoaiNhanVien.Name = "comboBox_LoaiNhanVien";
            this.comboBox_LoaiNhanVien.Size = new System.Drawing.Size(171, 21);
            this.comboBox_LoaiNhanVien.TabIndex = 8;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(119, 63);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(171, 20);
            this.textBox_MatKhau.TabIndex = 7;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(119, 92);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(171, 20);
            this.textBox_Email.TabIndex = 6;
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(119, 10);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(171, 20);
            this.textBox_TenDangNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhóm nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // NhanVien_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 248);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVien_ChiTiet";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.NhanVien_ChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_TenDayDu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.ComboBox comboBox_LoaiNhanVien;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Active;
        private System.Windows.Forms.Label label6;
    }
}