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
    public partial class MuonDungCu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();

        public MuonDungCu()
        {
            InitializeComponent();
        }

        private void MuonDungCu_Load(object sender, EventArgs e)
        {
            getData();

            List<GIAOVIEN> maGV = data.GIAOVIENs.ToList();

            cbb_MaGV.DisplayMember = "TENGIAOVIEN";
            cbb_MaGV.ValueMember = "MAGIAOVIEN";
            cbb_MaGV.DataSource = (from magv in maGV
                                   select new
                                   {
                                       magv.MAGIAOVIEN,
                                       magv.TENGIAOVIEN
                                   }).ToList();

            List<LOP> lop = data.LOPs.ToList();

            cbb_MaLop.DisplayMember = "TENLOP";
            cbb_MaLop.ValueMember = "MALOP";
            cbb_MaLop.DataSource = (from Lop in lop
                                    select new
                                    {
                                        Lop.MALOP,
                                        Lop.TENLOP
                                    }).ToList();


            dtp_GioMuon.CustomFormat = "hh:mm:ss";
        }

        private void btnAddMuon_ItemClick(object sender, EventArgs e)
        {
            MUON muon = new MUON();

            muon.SOPHIEUMUON = int.Parse(tb_SoPM.Text.Trim());
            muon.NGAYMUON = new DateTime(
                dtp_NgayMuon.Value.Year,
                dtp_NgayMuon.Value.Month,
                dtp_NgayMuon.Value.Day);
            muon.GIOMUON = new TimeSpan(
                dtp_GioMuon.Value.Hour,
                dtp_GioMuon.Value.Minute,
                dtp_GioMuon.Value.Second);
            muon.MALOP = cbb_MaLop.SelectedValue.ToString();
            muon.MAGIAOVIEN = cbb_MaGV.SelectedValue.ToString();
            data.MUONs.Add(muon);
            data.SaveChanges();
            getData();
        }

        void getData()
        {
            List<MUON> muon = data.MUONs.ToList();

            dgv_MuonDC.DataSource = (from Muon in muon
                                     select new
                                     {
                                         Muon.SOPHIEUMUON,
                                         Muon.NGAYMUON,
                                         Muon.GIOMUON,
                                         Muon.MAGIAOVIEN,
                                         Muon.MALOP
                                     }).ToList();
        }

        private void dgv_MuonDC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgv_MuonDC.Rows[e.RowIndex];
                tb_SoPM.Text = dgv.Cells[0].Value.ToString();
                dtp_NgayMuon.Value = DateTime.Parse(dgv.Cells[1].Value.ToString());
                dtp_GioMuon.Value = DateTime.Parse(dgv.Cells[2].Value.ToString());
                cbb_MaGV.Text = dgv.Cells[3].Value.ToString();
                cbb_MaLop.Text = dgv.Cells[4].Value.ToString();
            }
            tb_SoPM.ReadOnly = true;
            dtp_GioMuon.Enabled = false;
            dtp_NgayMuon.Enabled = false;
            cbb_MaGV.Enabled = false;
            cbb_MaLop.Enabled = false;
        }

        private void btnDeleteMuon_ItemClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng này?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                int temp = int.Parse(tb_SoPM.Text);
                var s = (from t in data.MUONs
                         where t.SOPHIEUMUON == temp
                         select t).SingleOrDefault();
                data.MUONs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void btnRefreshMuon_ItemClick(object sender, EventArgs e)
        {
            dgv_MuonDC.DataSource = null;
            tb_SoPM.ReadOnly = false;
            tb_SoPM.Text = "";
            dtp_GioMuon.Text = default;
            dtp_GioMuon.Enabled = true;
            dtp_NgayMuon.Text = default;
            dtp_NgayMuon.Enabled = true;
            cbb_MaLop.Enabled = true;
            cbb_MaLop.SelectedIndex = 0;
            cbb_MaGV.Enabled = true;
            cbb_MaGV.SelectedIndex = 0;

            getData();
        }
    }
}
