using CuaHangDTDD._Library;
using CuaHangDTDD.Controllers.ModelController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            NhanVienController ctr = new NhanVienController();
            //Debug.WriteLine(TextLibrary.GetSHA1HashData(textBox_MatKhau.Text));
            if (ctr.login(TextLibrary.ToString(textBox_TenDangNhap.Text), TextLibrary.ToString(textBox_MatKhau.Text)))
            {
                Global._nhanvien = ctr.get_by_username(TextLibrary.ToString(textBox_TenDangNhap.Text));
                Global._reset_permission(Global._nhanvien.loainhanvien);
                //MessageBox.Show("Đăng nhập thành công!");
                //redirect
                Main_Form f = new Main_Form();
                f.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return;
            }
        }

        private void textBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_DangNhap.PerformClick();
            }
        }

        private void textBox_TenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            this.textBox_MatKhau_KeyDown(sender, e);
        }
    }
}
