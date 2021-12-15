using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using DevExpress.XtraCharts;

namespace ThietKeChucNang
{
    public partial class ucThongKeDoanhThu : UserControl
    {
        BLL_ThongKe bllThongKe = new BLL_ThongKe();
        public ucThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ucThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            
        }
        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThongKeTheoNgay_Click(object sender, EventArgs e)
        {
            chartControlDoanhThu.Series.Clear();
            chartControlDoanhThu.DataSource = bllThongKe.LoadThongKeDoanhThuTheoNgay(dptNgayBD.Value, dptNgayKT.Value);
            Series s1 = new Series("Doanh thu", ViewType.Line);
            s1.ArgumentDataMember = "NgayLap";
            s1.ValueDataMembers.AddRange("DoanhThu");
            chartControlDoanhThu.Series.Add(s1);
        }
    }
}
