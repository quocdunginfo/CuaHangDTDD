namespace Winform.GUI
{
    partial class FmInBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ChiTiet_DonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvKhungBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTiet_DonHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTiet_DonHangBindingSource
            // 
            this.ChiTiet_DonHangBindingSource.DataSource = typeof(BaseClass.Models.ChiTiet_DonHang);
            // 
            // rvKhungBaoCao
            // 
            this.rvKhungBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NguonDuLieuBaoCao";
            reportDataSource1.Value = this.ChiTiet_DonHangBindingSource;
            this.rvKhungBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rvKhungBaoCao.LocalReport.ReportEmbeddedResource = "Winform.GUI.MauBaoCao.rdlc";
            this.rvKhungBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rvKhungBaoCao.Name = "rvKhungBaoCao";
            this.rvKhungBaoCao.Size = new System.Drawing.Size(830, 490);
            this.rvKhungBaoCao.TabIndex = 0;
            // 
            // FmInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 490);
            this.Controls.Add(this.rvKhungBaoCao);
            this.Name = "FmInBaoCao";
            this.Text = "In Báo Cáo";
            this.Load += new System.EventHandler(this.FmInBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTiet_DonHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvKhungBaoCao;
        private System.Windows.Forms.BindingSource ChiTiet_DonHangBindingSource;
    }
}