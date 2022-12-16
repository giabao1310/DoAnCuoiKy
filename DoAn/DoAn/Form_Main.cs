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

namespace DoAn
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file excel";
            openFileDialog.Filter = "excel file | *.xls;*.xlsx"; // open file with xls and xlsx format
            openFileDialog.RestoreDirectory = true; // remember last path

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb_fileAddress.Text = openFileDialog.FileName;

                //copy file to another folder
                string sourcePath = Path.GetDirectoryName(openFileDialog.FileName);
                string targetPath = "C:\\TDT\\hk3nam1\\CNPM\\DoAn\\DoAn\\bin\\Debug";
                   
                //combine file and path
                string sourceFile = System.IO.Path.Combine(sourcePath, Path.GetFileName(openFileDialog.FileName));
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(openFileDialog.FileName));

                //copy file from source folder to destination folder
                System.IO.File.Copy(sourceFile, destFile, true);

                Workbook workbook = new Workbook(openFileDialog.FileName);
                // Create a file stream for Excel file
                FileStream stream = new FileStream("output.xlsx", FileMode.CreateNew);

                // Export Excel file to stream
                workbook.Save(stream, new OoxmlSaveOptions(SaveFormat.Xlsx));

                // Perform operations on stream

                // Close the stream
                stream.Close();
            }
            

        }
    }
}