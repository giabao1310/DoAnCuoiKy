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
    public partial class DM_GiaoVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();
        Boolean action = false;

        public DM_GiaoVien()
        {
            InitializeComponent();
        }

        void getData()
        {
            List<GIAOVIEN> giaovien = data.GIAOVIENs.ToList();

            dgv_GiaoVien.DataSource = (from gv in giaovien
                                   select new
                                   {
                                       gv.MAGIAOVIEN,
                                       gv.TENGIAOVIEN,
                                       gv.THUOCBOMON
                                   }).ToList();
        }

        private void DM_GiaoVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnAddGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false)
            {
                GIAOVIEN gv = new GIAOVIEN();

                gv.TENGIAOVIEN = tb_TenGV.Text.Trim();
                gv.MAGIAOVIEN = tb_MaGV.Text.Trim();
                gv.THUOCBOMON = tb_ThuocBM.Text.Trim();

                data.GIAOVIENs.Add(gv);
                data.SaveChanges();
                getData();
            }
            else
            {
                var giaovien = data.GIAOVIENs.FirstOrDefault(x => x.MAGIAOVIEN.Contains(tb_MaGV.Text));

                giaovien.TENGIAOVIEN = tb_TenGV.Text.Trim();
                giaovien.MAGIAOVIEN = tb_MaGV.Text.Trim();
                giaovien.THUOCBOMON = tb_ThuocBM.Text.Trim();

                data.GIAOVIENs.Add(giaovien);
                data.SaveChanges();
                getData();
            }
        }

        private void btnDeleteGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng này?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                var s = (from t in data.GIAOVIENs
                         where t.MAGIAOVIEN == tb_MaGV.Text
                         select t).SingleOrDefault();
                data.GIAOVIENs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void btnRefreshGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            tb_MaGV.Text = "";
            tb_TenGV.Text = "";
            tb_ThuocBM.Text = "";
            tb_MaGV.ReadOnly = false;
            tb_TenGV.ReadOnly = false;
            tb_ThuocBM.ReadOnly = false;

            getData();
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }
    }
}