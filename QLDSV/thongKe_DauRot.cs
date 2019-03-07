using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class thongKe_DauRot : Form
    {
        public thongKe_DauRot()
        {
            InitializeComponent();
        }

        private void thongKe_DauRot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetThongke.DSSV' table. You can move, or remove it, as needed.
            this.DSSVTableAdapter.Fill(this.DataSetThongke.DSSV);

            this.reportViewer1.RefreshReport();
        }
    }
}
