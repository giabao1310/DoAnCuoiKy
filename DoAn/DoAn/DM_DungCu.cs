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

namespace DoAn
{
    public partial class DM_DungCu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();
        Boolean action = false;

        public DM_DungCu()
        {
            InitializeComponent();
        }

        void getData()
        {
            List<DUNGCU> dungcus = data.DUNGCUs.ToList();

            gridControl1.DataSource = (from dungcu in dungcus
                                       select new
                                       {
                                           dungcu.MADUNGCU,
                                           dungcu.TENDUNGCU,
                                           dungcu.GIATIEN,
                                           dungcu.NGAYMUA,
                                           dungcu.CONSUDUNGDUOC
                                       }).ToList();
        }

        private void DM_DungCu_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void BarBtnAddDC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false)
            {
                DUNGCU dUNGCU = new DUNGCU();
                dUNGCU.MADUNGCU = tb_MaDC.Text.Trim();
                dUNGCU.TENDUNGCU = tb_TenDC.Text.Trim();
                dUNGCU.GIATIEN = int.Parse(tb_GiaTien.Text.Trim());
                dUNGCU.CONSUDUNGDUOC = rb_Yes.Checked ? "Được" : "Không";
                dUNGCU.NGAYMUA = new DateTime(
                    dtp_NgayMua.Value.Year,
                    dtp_NgayMua.Value.Month,
                    dtp_NgayMua.Value.Day);

                data.DUNGCUs.Add(dUNGCU);
                data.SaveChanges();

                getData();
            }
            else
            {
                var s = (from t in data.DUNGCUs
                         where t.MADUNGCU == tb_MaDC.Text
                         select t).SingleOrDefault();

                var dungcu = data.DUNGCUs.FirstOrDefault(x => x.MADUNGCU.Contains(tb_MaDC.Text));

                dungcu.MADUNGCU = tb_MaDC.Text.Trim();
                dungcu.TENDUNGCU = tb_TenDC.Text.Trim();
                dungcu.GIATIEN = int.Parse(tb_GiaTien.Text.Trim());
                dungcu.CONSUDUNGDUOC = rb_Yes.Checked ? "Được" : "Không";
                dungcu.NGAYMUA = new DateTime(
                    dtp_NgayMua.Value.Year,
                    dtp_NgayMua.Value.Month,
                    dtp_NgayMua.Value.Day);

                data.DUNGCUs.Add(dungcu);
                data.SaveChanges();
                getData();
            }
        }

        private void BarBtnDeleteDC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng này?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                var s = (from t in data.DUNGCUs
                         where t.MADUNGCU == tb_MaDC.Text
                         select t).SingleOrDefault();
                data.DUNGCUs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void BarBtnDC_Refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            tb_MaDC.Text = "";
            tb_TenDC.Text = "";
            dtp_NgayMua.Enabled = true;
            dtp_NgayMua.Text = default;
            tb_GiaTien.Text = "";
            rb_No.Enabled = true;
            rb_Yes.Enabled = true;

            tb_MaDC.ReadOnly = false;
            tb_TenDC.ReadOnly = false;
            tb_GiaTien.ReadOnly = false;

            getData();
        }


        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

        }
    }
}