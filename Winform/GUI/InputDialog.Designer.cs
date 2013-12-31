namespace Winform.GUI
{
    partial class InputDialog
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
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.lbGiaTri = new System.Windows.Forms.Label();
            this.btDuyet = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(85, 12);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(226, 20);
            this.tbGiaTri.TabIndex = 0;
            // 
            // lbGiaTri
            // 
            this.lbGiaTri.AutoSize = true;
            this.lbGiaTri.Location = new System.Drawing.Point(12, 15);
            this.lbGiaTri.Name = "lbGiaTri";
            this.lbGiaTri.Size = new System.Drawing.Size(67, 13);
            this.lbGiaTri.TabIndex = 1;
            this.lbGiaTri.Text = "Nhập giá trị :";
            // 
            // btDuyet
            // 
            this.btDuyet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDuyet.Location = new System.Drawing.Point(30, 38);
            this.btDuyet.Name = "btDuyet";
            this.btDuyet.Size = new System.Drawing.Size(88, 37);
            this.btDuyet.TabIndex = 2;
            this.btDuyet.Text = "Duyệt";
            this.btDuyet.UseVisualStyleBackColor = true;
            this.btDuyet.Click += new System.EventHandler(this.btDuyet_Click);
            // 
            // btHuy
            // 
            this.btHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btHuy.Location = new System.Drawing.Point(175, 38);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(88, 37);
            this.btHuy.TabIndex = 3;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 87);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDuyet);
            this.Controls.Add(this.lbGiaTri);
            this.Controls.Add(this.tbGiaTri);
            this.Name = "InputDialog";
            this.Text = "Hộp thoại nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label lbGiaTri;
        private System.Windows.Forms.Button btDuyet;
        private System.Windows.Forms.Button btHuy;
    }
}