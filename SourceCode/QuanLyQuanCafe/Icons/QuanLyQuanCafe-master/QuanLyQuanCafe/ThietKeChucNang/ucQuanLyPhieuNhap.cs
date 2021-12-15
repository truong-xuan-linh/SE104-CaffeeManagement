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
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.IO;
using System.Diagnostics;

namespace ThietKeChucNang
{
    public partial class ucQuanLyPhieuNhap : UserControl
    {
        BLL_PhieuNhapAndCTPN bllpnctpn = new BLL_PhieuNhapAndCTPN();
        private string username;
        public ucQuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        //Method
        public void GetUserName(string user)
        {
            username = user;
        }
        public void LoadPhieuNhap()
        {
            grcPhieuNhap.DataSource = bllpnctpn.LoadPhieuNhap();
        }
        public void LoadChiTietPhieuNhap(string maPhieuNhap)
        {
            grcChiTietPhieuNhap.DataSource = bllpnctpn.LoadCTPN(maPhieuNhap);
        }
        public bool ExportExcel(string filename)
        {
            try
            {
                if (grvPhieuNhap.FocusedRowHandle < 0)
                {
                    MessageBox.Show("Danh sách hóa đơn hiện đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Xuất hóa đơn ra Excel";
                    dialog.FileName = filename;
                    dialog.Filter = "Excel Files|*.xlsx;*.xlsm";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        grvPhieuNhap.ColumnPanelRowHeight = 40;
                        grvPhieuNhap.OptionsPrint.AutoWidth = AutoSize;
                        grvPhieuNhap.OptionsPrint.ShowPrintExportProgress = true;
                        grvPhieuNhap.OptionsPrint.AllowCancelPrintExport = true;

                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"Hóa đơn";

                        ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                        grvPhieuNhap.ExportToXlsx(dialog.FileName, options);
                        MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (File.Exists(dialog.FileName))
                        {
                            if (MessageBox.Show("Bạn có muốn mở file?", "Mở file", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Process.Start(dialog.FileName);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xuất file thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //-----------------------------------------------------
        private void ucQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }

        private void grvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadChiTietPhieuNhap(grvPhieuNhap.GetRowCellValue(e.FocusedRowHandle, "MaPhieuNhap").ToString());
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhap frmTPN = new frmTaoPhieuNhap();
            frmTPN.Username = username;
            frmTPN.ShowDialog();
            LoadPhieuNhap();
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            ExportExcel("sheet1");
        }
    }
}
