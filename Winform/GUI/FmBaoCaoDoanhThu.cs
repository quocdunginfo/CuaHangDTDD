using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseClass.ModelControllers;
using BaseClass.Models;
using BaseClass._Library;

namespace Winform.GUI
{
    public partial class FmBaoCaoDoanhThu : Form
    {
        DonHangController DHCtr = new DonHangController();
        List<ChiTiet_DonHang> ds_chitiet_donhang = new List<ChiTiet_DonHang>();
        long tongcong = 0;
        public FmBaoCaoDoanhThu()
        {
            InitializeComponent();
            dtgvKetQua.AutoGenerateColumns = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            List<DateTime> list_ngay = LayDanhSachNgay();
            if (list_ngay.Count == 0)
            {
                if (ds_chitiet_donhang.Count > 0) ds_chitiet_donhang.Clear();
            }
            else ds_chitiet_donhang = DHCtr.Lay_ThongTin_BanHang(list_ngay);

            LoadDTGV_KetQua();
        }

        void LoadDTGV_KetQua()
        {
            dtgvKetQua.DataSource = null;
            if (ds_chitiet_donhang.Count == 0) MessageBox.Show("Không tìm thấy kết quả.");
            else
            {
                dtgvKetQua.DataSource = ds_chitiet_donhang;
            }
            tongcong = 0;
            foreach (ChiTiet_DonHang ctdh in ds_chitiet_donhang)
                tongcong += ctdh.thanhtien;
            if (tongcong > 0) lbTongCong.Text = TextLibrary.ToCommaStringNumber(tongcong);
            else lbTongCong.Text = "0";
        }

        List<DateTime> LayDanhSachNgay()
        {
            List<DateTime> list = new List<DateTime>();
            bool[] thu = new bool[8] { true, ckbChuNhat.Checked, ckbThu2.Checked, ckbThu3.Checked, ckbThu4.Checked, ckbThu5.Checked, ckbThu6.Checked, ckbThu7.Checked };

            DateTime dtTu = dtpkTGTu.Value;
            dtTu = new DateTime(dtTu.Year, dtTu.Month, dtTu.Day, 23, 59, 59, 999);
            DateTime dtDen = dtpkTGDen.Value;
            dtDen = new DateTime(dtDen.Year, dtDen.Month, dtDen.Day, 23, 59, 59, 999);

            int i = 0;
            switch (dtTu.DayOfWeek.ToString())
            {
                case "Sunday": i = 1; break;
                case "Monday": i = 2; break;
                case "Tuesday": i = 3; break;
                case "Wednesday": i = 4; break;
                case "Thursday": i = 5; break;
                case "Friday": i = 6; break;
                case "Saturday": i = 7; break;
                default: break;
            }

            while (dtTu <= dtDen)
            {
                if (thu[i]) list.Add(dtTu);
                i++; if (i == 8) i = 1;
                dtTu = dtTu.AddDays(1);
            }

            return list;
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            if (ds_chitiet_donhang.Count == 0)
            {
                MessageBox.Show("Không có thông tin để xuất báo cáo.");
                return;
            }
            FmInBaoCao fm = new FmInBaoCao(ds_chitiet_donhang,TextLibrary.ToCommaStringNumber(tongcong));
            fm.ShowDialog();
        }
    }
}
