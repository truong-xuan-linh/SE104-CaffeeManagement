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
    public partial class ucQuanLyHoaDon : UserControl
    {
        //Fields
        BLL_HoaDonAndCTHD bllhdcthd = new BLL_HoaDonAndCTHD();
        //----------------------------------------------------------
        //Contructors
        public ucQuanLyHoaDon()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------
        //Method
        public void LoadHoaDon()
        {
            grcHoaDon.DataSource = bllhdcthd.LoadHoaDon();
        }
        public void LoadChiTietHoaDon(string maHoaDon)
        {
            grcChiTietHoaDon.DataSource = bllhdcthd.LoadCTHD(maHoaDon);
        }
        public bool ExportExcel(string filename)
        {
            try
            {
                if (grvHoaDon.FocusedRowHandle < 0)
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
                        grvHoaDon.ColumnPanelRowHeight = 40;
                        grvHoaDon.OptionsPrint.AutoWidth = AutoSize;
                        grvHoaDon.OptionsPrint.ShowPrintExportProgress = true;
                        grvHoaDon.OptionsPrint.AllowCancelPrintExport = true;
                        
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"Hóa đơn";

                        ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                        grvHoaDon.ExportToXlsx(dialog.FileName, options);
                        MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (File.Exists(dialog.FileName))
                        {
                            if(MessageBox.Show("Bạn có muốn mở file?", "Mở file", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
        //----------------------------------------------------------
        private void ucQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void grvHoaDon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadChiTietHoaDon(grvHoaDon.GetRowCellValue(e.FocusedRowHandle, "MaHoaDon").ToString());
        }
        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            ExportExcel("hoadon1");
        }

        
    }
}
