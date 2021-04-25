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
namespace FinalProject
{
    public partial class fQuanLiXeGoi : Form
    {
        public fQuanLiXeGoi()
        {
            InitializeComponent();
        }

        private void lBangSo_Click(object sender, EventArgs e)
        {

        }

        private void pbBangSo_Click(object sender, EventArgs e)
        {

        }

        private void QuanLiXeGoi_Load(object sender, EventArgs e)
        {

        }

        private void lLoaiXe_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            string id = txtMaXe.Text;
            string name = txtChuXe.Text;
            string hinhThucGoi = cbGoiTheo.Text;
            DateTime ngayGoi = DateTime.Now;
            MemoryStream picXe = new MemoryStream();
            MemoryStream picNguoi = new MemoryStream();
            MemoryStream picHieuXe = new MemoryStream();
            MemoryStream picBangSo = new MemoryStream();
            try
            {


                if (Them() == 0)
                {
                    pbHinhXe.Image.Save(picXe, pbHinhXe.Image.RawFormat);
                    pbNguoiGoi.Image.Save(picNguoi, pbHinhXe.Image.RawFormat);
                    XeDap xeDap = new XeDap();
                    if (xeDap.ThemXe(id, name, hinhThucGoi, ngayGoi, picXe, picNguoi))
                    {
                        MessageBox.Show("Đã thêm!", "Thêm xe Đạp");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int Them()
        {
            if (cbLoaiXe.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn loại xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbLoaiXe.Text.Contains("Xe đạp"))
            {
                btnAnhNguoiGoi.Enabled = true;
                btnAnhXe.Enabled = true;
                txtHieuXe.Enabled = false;
                btnAnhHieuXe.Enabled = false;
                txtBangSo.Enabled = false;
                btnAnhBangSo.Enabled = false;
                return 0;
            }
            else
            {
                if (cbLoaiXe.Text.Contains("Xe máy"))
                {
                    txtBangSo.Enabled = true;
                    btnAnhBangSo.Enabled = true;
                    txtHieuXe.Enabled = false;
                    btnAnhHieuXe.Enabled = false;
                    btnAnhXe.Enabled = false;
                    return 1;
                }
                else
                {
                    txtHieuXe.Enabled = true;
                    btnAnhHieuXe.Enabled = true;
                    txtBangSo.Enabled = true;
                    btnAnhBangSo.Enabled = true;
                    btnAnhNguoiGoi.Enabled = false;
                    btnAnhXe.Enabled = false;
                    return 2;
                }
            }
        }

        private void btnAnhHieuXe_Click(object sender, EventArgs e)
        {
            TaiAnh(pbHieuXe);
        }
        public void TaiAnh(PictureBox pb)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pb.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAnhBangSo_Click(object sender, EventArgs e)
        {
            TaiAnh(pbBangSo);
        }

        private void btnAnhXe_Click(object sender, EventArgs e)
        {
            TaiAnh(pbHinhXe);
        }

        private void btnAnhNguoiGoi_Click(object sender, EventArgs e)
        {
            TaiAnh(pbNguoiGoi);
        }

        private void cbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Them();
        }
    }
}
