using CuaHangDTDD._Library;
using CuaHangDTDD.Controllers.ModelController;
using CuaHangDTDD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Class;

namespace Winform
{
    public partial class NhanVien_ChiTiet : Form
    {
        //hằng số cho form
        private string title = "Nhân viên";
        //đối tượng NhanVien do form cha đặt trước khi show
        public NhanVien obj = new NhanVien();
        //mode do form cha đặt trước khi show
        public string mode = "xem";//them, sua, xem
        public NhanVien_ChiTiet()
        {
            InitializeComponent();
        }

        private void NhanVien_ChiTiet_Load(object sender, EventArgs e)
        {
            if (!Check_Permission())
            {
                MessageBox.Show("Permission fail!");
                return;
            }
            //load info
            this.textBox_Email.Text = obj.email;
            this.textBox_TenDangNhap.Text = obj.tendangnhap;
            this.textBox_TenDayDu.Text = obj.tendaydu;
            this.checkBox_Active.Checked = obj.active;
            this.textBox_MatKhau.Text = obj.matkhau;
            this.Load_LoaiNhanVien_ComboBox();
            //load title
            Load_Title();
        }
        /// <summary>
        /// Load danh sách Loại nhân viên lên và tự động chọn
        /// </summary>
        /// <returns></returns>
        private void Load_LoaiNhanVien_ComboBox()
        {
            DTDDDbContext db = new DTDDDbContext();
            List<LoaiNhanVien> list= db.ds_loainhanvien.ToList();
            this.comboBox_LoaiNhanVien.Items.Clear();
            foreach (var item in list)
            {
                ComboBoxItem tmp = new ComboBoxItem(item.ten, item.id);
                this.comboBox_LoaiNhanVien.Items.Add(tmp);
                if (obj.loainhanvien!=null && item.id == obj.loainhanvien.id)
                {
                    this.comboBox_LoaiNhanVien.SelectedItem = tmp;
                }
            }
        }
        /// <summary>
        /// Kiểm tra quyền hạn của NhanVien đang đang nhập ứng với this.mode
        /// </summary>
        /// <returns></returns>
        private Boolean Check_Permission()
        {
            if (!Global._permission.Contains("nhanvien_view"))
            {
                return false;
            }
            if (!Global._permission.Contains("nhanvien_edit") && this.mode.Equals("sua"))
            {
                return false;
            }
            if (!Global._permission.Contains("nhanvien_add") && this.mode.Equals("them"))
            {
                return false;
            }
            return true;
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            if (!Check_Permission())
            {
                MessageBox.Show("Permission fail!");
                return;
            }
            NhanVienController ctr = new NhanVienController();
            if (this.mode.Equals("them"))
            {
                //mode them
                NhanVien tmp = new NhanVien();
                tmp.tendangnhap = TextLibrary.ToString(textBox_TenDangNhap.Text);
                tmp.tendaydu = TextLibrary.ToString(textBox_TenDayDu.Text);
                tmp.email = TextLibrary.ToString(textBox_Email.Text);
                tmp.active = this.checkBox_Active.Checked;
                int loainhanvien_id = Get_ComboBox_LoaiNhanVien_Value();
                tmp.loainhanvien = ctr._db.ds_loainhanvien.Where(x => x.id == loainhanvien_id).FirstOrDefault();
                //call add
                int max_id = ctr.add(tmp);
                tmp = ctr.get_by_id(max_id);
                //get id
                //set password
                ctr.set_password(tmp.id, TextLibrary.ToString(textBox_MatKhau.Text));
                //commit for sure
                ctr._db.SaveChanges();
                //show message
                MessageBox.Show("Thêm nhân viên mới thành công, id = "+tmp.id);
                //chuyển sang mode sua
                Reload("sua", tmp, sender, e);
                return;
            }
        }
        private int Get_ComboBox_LoaiNhanVien_Value()
        {
            ComboBoxItem tmp = (ComboBoxItem)this.comboBox_LoaiNhanVien.SelectedItem;
            return tmp.value;
        }
        /// <summary>
        /// Tự load lại thông tin form
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="obj"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void Reload(string mode, NhanVien obj, object sender, EventArgs e)
        {
            this.mode = mode;
            this.obj=obj;
            //reload
            this.NhanVien_ChiTiet_Load(sender, e);
        }
        /// <summary>
        /// Đặt Form Title dựa trên this.mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        private void Load_Title()
        {
            //set title
            switch (this.mode)
            {
                case "xem":
                    this.Text = this.title + " - Xem chi tiết";
                    break;
                case "them":
                    this.Text = this.title + " - Thêm";
                    break;
                case "sua":
                    this.Text = this.title + " - Sửa";
                    break;
                default:
                    this.Text = this.title;
                    break;
            }
        }
    }
}
