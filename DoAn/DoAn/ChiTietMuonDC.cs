using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class ChiTietMuonDC : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();
        Boolean action = false;

        public ChiTietMuonDC()
        {
            InitializeComponent();
        }

        private void btnAddCtMuon_ItemClick(object sender, EventArgs e)
        {
            if (action == false)
            {
                CHITIETMUON ctMuon = new CHITIETMUON();

                ctMuon.SOPHIEUMUON = int.Parse(cbb_SoPhieuMuon.SelectedValue.ToString());
                ctMuon.MADUNGCU = cbb_MaDungCu.SelectedValue.ToString();

                ctMuon.NGAYTRA = new DateTime(
                    dtp_NgayTra.Value.Year,
                    dtp_NgayTra.Value.Month,
                    dtp_NgayTra.Value.Day);

                ctMuon.GIOTRA = new TimeSpan(
                    dtp_GioTra.Value.Hour,
                    dtp_GioTra.Value.Minute,
                    dtp_GioTra.Value.Second);

                data.CHITIETMUONs.Add(ctMuon);
                try
                {
                    data.SaveChanges();
                }
                catch
                (Exception)
                {
                    MessageBox.Show("Thông tin bạn nhập đã tồn tại", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }

                getData();
            }
            else
            {
                var chitietmuon = data.CHITIETMUONs.FirstOrDefault(x => x.MADUNGCU.Contains(cbb_MaDungCu.Text));

                chitietmuon.SOPHIEUMUON = int.Parse(cbb_SoPhieuMuon.SelectedValue.ToString());
                chitietmuon.MADUNGCU = cbb_MaDungCu.SelectedValue.ToString();

                chitietmuon.NGAYTRA = new DateTime(
                    dtp_NgayTra.Value.Year,
                    dtp_NgayTra.Value.Month,
                    dtp_NgayTra.Value.Day);

                chitietmuon.GIOTRA = new TimeSpan(
                    dtp_GioTra.Value.Hour,
                    dtp_GioTra.Value.Minute,
                    dtp_GioTra.Value.Second);

                data.CHITIETMUONs.Add(chitietmuon);

                data.SaveChanges();
                getData();
            }

        }

        void getData()
        {
            List<CHITIETMUON> ctMuon = data.CHITIETMUONs.ToList();

            dgv_CtMuon.DataSource = (from CtMuon in ctMuon
                                     select new
                                     {
                                         CtMuon.SOPHIEUMUON,
                                         CtMuon.MADUNGCU,
                                         CtMuon.NGAYTRA,
                                         CtMuon.GIOTRA
                                     }).ToList();
        }

        private void ChiTietMuonDC_Load(object sender, EventArgs e)
        {
            getData();

            List<MUON> muon = data.MUONs.ToList();

            cbb_SoPhieuMuon.DisplayMember = "SOPHIEUMUON";
            cbb_SoPhieuMuon.ValueMember = "SOPHIEUMUON";
            cbb_SoPhieuMuon.DataSource = (from Muon in muon
                                          select new
                                          {
                                              Muon.SOPHIEUMUON
                                          }).ToList();

            List<DUNGCU> lop = data.DUNGCUs.ToList();

            cbb_MaDungCu.DisplayMember = "TENDUNGCU";
            cbb_MaDungCu.ValueMember = "MADUNGCU";
            cbb_MaDungCu.DataSource = (from Lop in lop
                                       select new
                                       {
                                           Lop.MADUNGCU,
                                           Lop.TENDUNGCU
                                       }).ToList();

            dtp_GioTra.CustomFormat = "hh:mm:ss";

        }

        private void btnDeleteCtMuon_ItemClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng này?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                int temp = int.Parse(cbb_SoPhieuMuon.Text);
                var s = (from t in data.CHITIETMUONs
                         where t.SOPHIEUMUON == temp && t.MADUNGCU == cbb_MaDungCu.Text
                         select t).SingleOrDefault();
                data.CHITIETMUONs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void dgv_CtMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgv_CtMuon.Rows[e.RowIndex];
                cbb_SoPhieuMuon.Text = dgv.Cells[0].Value.ToString();
                cbb_MaDungCu.Text = dgv.Cells[1].Value.ToString();
                dtp_NgayTra.Value = DateTime.Parse(dgv.Cells[2].Value.ToString());
                dtp_GioTra.Value = DateTime.Parse(dgv.Cells[3].Value.ToString());
            }
            cbb_SoPhieuMuon.Enabled = false;
            cbb_MaDungCu.Enabled = false;
        }

        private void btnRefreshCtMuon_ItemClick(object sender, EventArgs e)
        {
            dgv_CtMuon.DataSource = null;
            cbb_SoPhieuMuon.Enabled = true;
            cbb_SoPhieuMuon.SelectedIndex = 0;
            cbb_MaDungCu.Enabled = true;
            cbb_MaDungCu.SelectedIndex = 0;
            dtp_NgayTra.Text = default;
            dtp_GioTra.Text = default;

            getData();
        }
    }
}
