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
    public partial class FmThongKeTonKho : Form
    {
        SanPham_ChiTietController SPCTCtr = new SanPham_ChiTietController();
        public FmThongKeTonKho()
        {
            InitializeComponent();
            dtgvSanPham.AutoGenerateColumns = false;
            LoadDTGV_SanPham();
        }

        void LoadDTGV_SanPham()
        {
            foreach (SanPham_ChiTiet spct in SPCTCtr.timkiem())
                dtgvSanPham.Rows.Add(spct.id, spct.sanpham.masp, spct.sanpham.ten, spct.mausac.giatri, spct.sanpham.anhmacdinh, false);   
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            List<SanPham_ChiTiet> dssp = LayDanhSachSP();
            List<DateTime> dsngay = LayDanhSachNgay();

            List<int> dstonkho = SPCTCtr.Lay_SoLuong_TonKho(dssp, dsngay);
            LoadDTGV_KetQua(dssp,dsngay,dstonkho);
        }

        void LoadDTGV_KetQua(List<SanPham_ChiTiet> dssp, List<DateTime> dsngay, List<int> dstonkho)
        {
            if(dtgvKetQua.Rows.Count > 0) dtgvKetQua.Rows.Clear();
            if (dstonkho.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả.");
                return;
            }
            int i = 0;
            foreach(SanPham_ChiTiet spct in dssp)
                foreach (DateTime dt in dsngay)
                {
                    string ngay = TextLibrary.DateTime_To_String(dt);
                    dtgvKetQua.Rows.Add(spct.id,spct.sanpham.masp,spct.sanpham.ten,ngay,dstonkho[i]);
                    i++;
                }
        }

        List<DateTime> LayDanhSachNgay()
        {
            List<DateTime> list = new List<DateTime>();
            bool[] thu = new bool[8] {true,ckbChuNhat.Checked, ckbThu2.Checked, ckbThu3.Checked, ckbThu4.Checked, ckbThu5.Checked, ckbThu6.Checked, ckbThu7.Checked};

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

        List<SanPham_ChiTiet> LayDanhSachSP()
        {
            List<SanPham_ChiTiet> list = new List<SanPham_ChiTiet>();
            foreach (DataGridViewRow dtr in dtgvSanPham.Rows)
            {
                if (dtr.Cells["chon"].Value.ToString() == "True")
                {
                    SanPham_ChiTiet spct = new SanPham_ChiTiet();
                    spct.id = Int32.Parse(dtr.Cells["id"].Value.ToString());
                    list.Add(spct);
                }
            }
            return list;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool b = (bool)dtgvSanPham.SelectedRows[0].Cells["chon"].Value;
            dtgvSanPham.SelectedRows[0].Cells["chon"].Value = !b;
        }

    }
}
