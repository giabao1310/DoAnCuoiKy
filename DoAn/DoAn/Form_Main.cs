using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using xls = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Table;
using Aspose.Cells;
using DevExpress.Utils.Drawing;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace DoAn
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnDungCu_ItemClick(object sender, ItemClickEventArgs e)
        {
            DM_DungCu dc = new DM_DungCu();
            dc.MdiParent = this;
            dc.Show();
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            DM_Lop dc = new DM_Lop();
            dc.MdiParent = this;
            dc.Show();
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            DM_GiaoVien dc = new DM_GiaoVien();
            dc.MdiParent = this;
            dc.Show();
        }

        private void btnMuonDC_ItemClick(object sender, ItemClickEventArgs e)
        {
            MuonDungCu dc = new MuonDungCu();
            dc.MdiParent = this;
            dc.Show();
        }

        private void btnCtMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChiTietMuonDC dc = new ChiTietMuonDC();
            dc.MdiParent = this;
            dc.Show();
        }

        private void readFile(string path)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = package.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRow = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRow.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRow.ToArray());
                }
                dtg_excelData.DataSource = dataTable;
            }
        }   

        private void btn_browse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Chọn file excel";
            //openFileDialog.Filter = "excel file | *.xls;*.xlsx"; // open file with xls and xlsx format
            //openFileDialog.RestoreDirectory = true; // remember last path

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    tb_fileAddress.Text = openFileDialog.FileName;
            //    try
            //    {
            //        readFile(openFileDialog.FileName);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Không thể mở file excel!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"Downloads",
                Title = "Chọn File Cần Nhập",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xls",
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb_fileAddress.Text = openFileDialog.FileName;

                try
                {
                    readFile(openFileDialog.FileName);
                    MessageBox.Show("Đọc file thành công!", "Message");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đọc file không thành công!" + ex.Message);
                }
            }
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics g2 = Graphics.FromImage(bmp);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            List<DUNGCU> dungcus = data.DUNGCUs.ToList();

            dataGridView1.DataSource = (from dungcu in dungcus
                                       select new
                                       {
                                           dungcu.MADUNGCU,
                                           dungcu.TENDUNGCU,
                                           dungcu.GIATIEN,
                                           dungcu.NGAYMUA,
                                           dungcu.CONSUDUNGDUOC
                                       }).ToList();
        }

        private void writeFile(string path)
        {
            xls.Application application = new xls.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i+2 , j+1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export excel";
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    writeFile(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!" + ex.Message);
                }
            }
        }
    }
}