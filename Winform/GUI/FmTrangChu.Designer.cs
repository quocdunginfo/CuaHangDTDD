namespace Winform.GUI
{
    partial class FmTrangChu
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
            this.btQuanLySanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuanLySanPham
            // 
            this.btQuanLySanPham.Location = new System.Drawing.Point(12, 12);
            this.btQuanLySanPham.Name = "btQuanLySanPham";
            this.btQuanLySanPham.Size = new System.Drawing.Size(160, 46);
            this.btQuanLySanPham.TabIndex = 0;
            this.btQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.btQuanLySanPham.UseVisualStyleBackColor = true;
            this.btQuanLySanPham.Click += new System.EventHandler(this.btQuanLySanPham_Click);
            // 
            // FmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.btQuanLySanPham);
            this.Name = "FmTrangChu";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuanLySanPham;
    }
}