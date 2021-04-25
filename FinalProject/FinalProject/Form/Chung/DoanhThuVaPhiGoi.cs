using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class fDoanhThuVaPhiGoi : Form
    {
        public fDoanhThuVaPhiGoi()
        {
            InitializeComponent();
        }

        private void quảnLýPhíGởiVàChỗTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPhiGoiVaChoTrong.Visible = true;
            pDoanhThu.Visible = false;
        }

        private void fDoanhThuVaPhiGoi_Load(object sender, EventArgs e)
        {
            pPhiGoiVaChoTrong.Visible = true;
            pDoanhThu.Visible = false;
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPhiGoiVaChoTrong.Visible = false;
            pDoanhThu.Visible = true;
        }
    }
}
