using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingPanel.Width += 3;
            if (loadingPanel.Width > 599)
            {
                timer1.Stop();
                Form_Main fm = new Form_Main();
                fm.Show();
                this.Hide();
            }
        }
    }
}
