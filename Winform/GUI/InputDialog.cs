using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.GUI
{
    public partial class InputDialog : Form
    {
        public string GiaTri
        {
            get
            {
                return tbGiaTri.Text.Trim();
            }
        }
        public InputDialog()
        {
            InitializeComponent();
        }

        public InputDialog(string p1, string p2, string p3)
        {
            InitializeComponent();
            this.Text = p1;
            lbGiaTri.Text = p2;
            tbGiaTri.Text = p3;
        }

        private void btDuyet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(GiaTri))
            {
                MessageBox.Show("Không được nhập rỗng.");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

    }
}
