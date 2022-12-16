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
    public partial class DM_Lop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDUNGCUEntities data = new QLDUNGCUEntities();
        Boolean action = false;

        public DM_Lop()
        {
            InitializeComponent();
        }

        void getData()
        {
            List<LOP> lops = data.LOPs.ToList();

            dgv_Lop.DataSource = (from lOp in lops
                                    select new
                                    {
                                        lOp.MALOP,
                                        lOp.TENLOP,
                                        lOp.TENLOPTRUONG
                                    }).ToList();
        }

        private void DM_Lop_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnAddLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false)
            {
                LOP lop = new LOP();

                lop.TENLOP = tb_TenLop.Text.Trim();
                lop.MALOP = tb_MaLop.Text.Trim();
                lop.TENLOPTRUONG = tb_TenLopTruong.Text.Trim();

                data.LOPs.Add(lop);
                data.SaveChanges();
                getData();
            }
            else
            {
                var Lop = data.LOPs.FirstOrDefault(x => x.MALOP.Contains(tb_MaLop.Text));


                Lop.TENLOP = tb_TenLop.Text.Trim();
                Lop.MALOP = tb_MaLop.Text.Trim();
                Lop.TENLOPTRUONG = tb_TenLopTruong.Text.Trim();

                data.LOPs.Add(Lop);
                data.SaveChanges();
                getData();
            }
        }

        private void btnDeleteLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng này?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                var s = (from t in data.LOPs
                         where t.MALOP == tb_MaLop.Text
                         select t).SingleOrDefault();
                data.LOPs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void btnRefreshLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            tb_MaLop.Text = "";
            tb_TenLop.Text = "";
            tb_TenLopTruong.Text = "";
            tb_MaLop.ReadOnly = false;
            tb_TenLop.ReadOnly = false;
            tb_TenLopTruong.ReadOnly = false;

            getData();
        }

        private void dgv_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgv_Lop.Rows[e.RowIndex];
                tb_MaLop.Text = dgv.Cells[0].Value.ToString();
                tb_TenLop.Text = dgv.Cells[1].Value.ToString();
                tb_TenLopTruong.Text = dgv.Cells[2].Value.ToString();
            }
            tb_MaLop.ReadOnly = true;
            tb_TenLop.ReadOnly = true;
            tb_TenLopTruong.ReadOnly = true;
        }
    }
}