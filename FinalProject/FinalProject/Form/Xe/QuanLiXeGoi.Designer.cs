
namespace FinalProject
{
    partial class QuanLiXeGoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSachXe = new System.Windows.Forms.DataGridView();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.lLoaiXe = new System.Windows.Forms.Label();
            this.lNguoiGoi = new System.Windows.Forms.Label();
            this.pbNguoiGoi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHinhXe = new System.Windows.Forms.PictureBox();
            this.lTongXe = new System.Windows.Forms.Label();
            this.lChoTrong = new System.Windows.Forms.Label();
            this.lBangSo = new System.Windows.Forms.Label();
            this.pbBangSo = new System.Windows.Forms.PictureBox();
            this.lHieuXe = new System.Windows.Forms.Label();
            this.txtBangSo = new System.Windows.Forms.TextBox();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.pbHieuXe = new System.Windows.Forms.PictureBox();
            this.lNgayGoi = new System.Windows.Forms.Label();
            this.dtpNgayGoi = new System.Windows.Forms.DateTimePicker();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.lChuXe = new System.Windows.Forms.Label();
            this.txtChuXe = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lLoc = new System.Windows.Forms.Label();
            this.rbCo = new System.Windows.Forms.RadioButton();
            this.rbKhong = new System.Windows.Forms.RadioButton();
            this.lKieuGoi = new System.Windows.Forms.Label();
            this.rbGio = new System.Windows.Forms.RadioButton();
            this.rbNgay = new System.Windows.Forms.RadioButton();
            this.rbTuan = new System.Windows.Forms.RadioButton();
            this.rbThang = new System.Windows.Forms.RadioButton();
            this.lTrongKhoang = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lVa = new System.Windows.Forms.Label();
            this.lGoiTheo = new System.Windows.Forms.Label();
            this.cbGoiTheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNguoiGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBangSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHieuXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachXe
            // 
            this.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXe.Location = new System.Drawing.Point(481, 135);
            this.dgvDanhSachXe.Name = "dgvDanhSachXe";
            this.dgvDanhSachXe.Size = new System.Drawing.Size(318, 312);
            this.dgvDanhSachXe.TabIndex = 5;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Location = new System.Drawing.Point(149, 11);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiXe.TabIndex = 4;
            // 
            // lLoaiXe
            // 
            this.lLoaiXe.AutoSize = true;
            this.lLoaiXe.Location = new System.Drawing.Point(97, 11);
            this.lLoaiXe.Name = "lLoaiXe";
            this.lLoaiXe.Size = new System.Drawing.Size(46, 13);
            this.lLoaiXe.TabIndex = 3;
            this.lLoaiXe.Text = "Loại Xe:";
            this.lLoaiXe.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // lNguoiGoi
            // 
            this.lNguoiGoi.AutoSize = true;
            this.lNguoiGoi.Location = new System.Drawing.Point(236, 287);
            this.lNguoiGoi.Name = "lNguoiGoi";
            this.lNguoiGoi.Size = new System.Drawing.Size(57, 13);
            this.lNguoiGoi.TabIndex = 6;
            this.lNguoiGoi.Text = "Người Gởi:";
            // 
            // pbNguoiGoi
            // 
            this.pbNguoiGoi.Location = new System.Drawing.Point(299, 288);
            this.pbNguoiGoi.Name = "pbNguoiGoi";
            this.pbNguoiGoi.Size = new System.Drawing.Size(150, 146);
            this.pbNguoiGoi.TabIndex = 7;
            this.pbNguoiGoi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hình Xe:";
            // 
            // pbHinhXe
            // 
            this.pbHinhXe.Location = new System.Drawing.Point(79, 287);
            this.pbHinhXe.Name = "pbHinhXe";
            this.pbHinhXe.Size = new System.Drawing.Size(150, 146);
            this.pbHinhXe.TabIndex = 7;
            this.pbHinhXe.TabStop = false;
            // 
            // lTongXe
            // 
            this.lTongXe.AutoSize = true;
            this.lTongXe.Location = new System.Drawing.Point(478, 119);
            this.lTongXe.Name = "lTongXe";
            this.lTongXe.Size = new System.Drawing.Size(51, 13);
            this.lTongXe.TabIndex = 3;
            this.lTongXe.Text = "Tổng Xe:";
            // 
            // lChoTrong
            // 
            this.lChoTrong.AutoSize = true;
            this.lChoTrong.Location = new System.Drawing.Point(662, 119);
            this.lChoTrong.Name = "lChoTrong";
            this.lChoTrong.Size = new System.Drawing.Size(99, 13);
            this.lChoTrong.TabIndex = 3;
            this.lChoTrong.Text = "Chố Trống Còn Lại:";
            // 
            // lBangSo
            // 
            this.lBangSo.AutoSize = true;
            this.lBangSo.Location = new System.Drawing.Point(22, 235);
            this.lBangSo.Name = "lBangSo";
            this.lBangSo.Size = new System.Drawing.Size(51, 13);
            this.lBangSo.TabIndex = 6;
            this.lBangSo.Text = "Bảng Số:";
            this.lBangSo.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // pbBangSo
            // 
            this.pbBangSo.Location = new System.Drawing.Point(263, 232);
            this.pbBangSo.Name = "pbBangSo";
            this.pbBangSo.Size = new System.Drawing.Size(186, 28);
            this.pbBangSo.TabIndex = 7;
            this.pbBangSo.TabStop = false;
            this.pbBangSo.Click += new System.EventHandler(this.pbBangSo_Click);
            // 
            // lHieuXe
            // 
            this.lHieuXe.AutoSize = true;
            this.lHieuXe.Location = new System.Drawing.Point(25, 197);
            this.lHieuXe.Name = "lHieuXe";
            this.lHieuXe.Size = new System.Drawing.Size(48, 13);
            this.lHieuXe.TabIndex = 6;
            this.lHieuXe.Text = "Hiệu Xe:";
            this.lHieuXe.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // txtBangSo
            // 
            this.txtBangSo.Location = new System.Drawing.Point(79, 232);
            this.txtBangSo.Name = "txtBangSo";
            this.txtBangSo.Size = new System.Drawing.Size(178, 20);
            this.txtBangSo.TabIndex = 8;
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(79, 197);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(178, 20);
            this.txtHieuXe.TabIndex = 8;
            // 
            // pbHieuXe
            // 
            this.pbHieuXe.Location = new System.Drawing.Point(263, 189);
            this.pbHieuXe.Name = "pbHieuXe";
            this.pbHieuXe.Size = new System.Drawing.Size(186, 28);
            this.pbHieuXe.TabIndex = 7;
            this.pbHieuXe.TabStop = false;
            this.pbHieuXe.Click += new System.EventHandler(this.pbBangSo_Click);
            // 
            // lNgayGoi
            // 
            this.lNgayGoi.AutoSize = true;
            this.lNgayGoi.Location = new System.Drawing.Point(19, 158);
            this.lNgayGoi.Name = "lNgayGoi";
            this.lNgayGoi.Size = new System.Drawing.Size(54, 13);
            this.lNgayGoi.TabIndex = 6;
            this.lNgayGoi.Text = "Ngày Gởi:";
            this.lNgayGoi.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // dtpNgayGoi
            // 
            this.dtpNgayGoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGoi.Location = new System.Drawing.Point(79, 158);
            this.dtpNgayGoi.Name = "dtpNgayGoi";
            this.dtpNgayGoi.Size = new System.Drawing.Size(108, 20);
            this.dtpNgayGoi.TabIndex = 9;
            // 
            // btnThemXe
            // 
            this.btnThemXe.Location = new System.Drawing.Point(79, 455);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(75, 23);
            this.btnThemXe.TabIndex = 10;
            this.btnThemXe.Text = "Thêm Xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Location = new System.Drawing.Point(169, 455);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(75, 23);
            this.btnSuaXe.TabIndex = 10;
            this.btnSuaXe.Text = "Sửa Xe";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Location = new System.Drawing.Point(263, 455);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(75, 23);
            this.btnXoaXe.TabIndex = 10;
            this.btnXoaXe.Text = "Xóa Xe";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            // 
            // lChuXe
            // 
            this.lChuXe.AutoSize = true;
            this.lChuXe.Location = new System.Drawing.Point(28, 57);
            this.lChuXe.Name = "lChuXe";
            this.lChuXe.Size = new System.Drawing.Size(45, 13);
            this.lChuXe.TabIndex = 6;
            this.lChuXe.Text = "Chủ Xe:";
            this.lChuXe.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // txtChuXe
            // 
            this.txtChuXe.Location = new System.Drawing.Point(79, 54);
            this.txtChuXe.Name = "txtChuXe";
            this.txtChuXe.Size = new System.Drawing.Size(178, 20);
            this.txtChuXe.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(724, 453);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lLoc
            // 
            this.lLoc.AutoSize = true;
            this.lLoc.Location = new System.Drawing.Point(481, 9);
            this.lLoc.Name = "lLoc";
            this.lLoc.Size = new System.Drawing.Size(76, 13);
            this.lLoc.TabIndex = 3;
            this.lLoc.Text = "Sử Dụng Lọc :";
            this.lLoc.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // rbCo
            // 
            this.rbCo.AutoSize = true;
            this.rbCo.Location = new System.Drawing.Point(590, 7);
            this.rbCo.Name = "rbCo";
            this.rbCo.Size = new System.Drawing.Size(38, 17);
            this.rbCo.TabIndex = 11;
            this.rbCo.TabStop = true;
            this.rbCo.Text = "Có";
            this.rbCo.UseVisualStyleBackColor = true;
            // 
            // rbKhong
            // 
            this.rbKhong.AutoSize = true;
            this.rbKhong.Location = new System.Drawing.Point(679, 7);
            this.rbKhong.Name = "rbKhong";
            this.rbKhong.Size = new System.Drawing.Size(56, 17);
            this.rbKhong.TabIndex = 11;
            this.rbKhong.TabStop = true;
            this.rbKhong.Text = "Không";
            this.rbKhong.UseVisualStyleBackColor = true;
            // 
            // lKieuGoi
            // 
            this.lKieuGoi.AutoSize = true;
            this.lKieuGoi.Location = new System.Drawing.Point(504, 41);
            this.lKieuGoi.Name = "lKieuGoi";
            this.lKieuGoi.Size = new System.Drawing.Size(53, 13);
            this.lKieuGoi.TabIndex = 3;
            this.lKieuGoi.Text = "Kiểu Gởi :";
            this.lKieuGoi.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // rbGio
            // 
            this.rbGio.AutoSize = true;
            this.rbGio.Location = new System.Drawing.Point(563, 37);
            this.rbGio.Name = "rbGio";
            this.rbGio.Size = new System.Drawing.Size(41, 17);
            this.rbGio.TabIndex = 11;
            this.rbGio.TabStop = true;
            this.rbGio.Text = "Giờ";
            this.rbGio.UseVisualStyleBackColor = true;
            // 
            // rbNgay
            // 
            this.rbNgay.AutoSize = true;
            this.rbNgay.Location = new System.Drawing.Point(612, 37);
            this.rbNgay.Name = "rbNgay";
            this.rbNgay.Size = new System.Drawing.Size(50, 17);
            this.rbNgay.TabIndex = 11;
            this.rbNgay.TabStop = true;
            this.rbNgay.Text = "Ngày";
            this.rbNgay.UseVisualStyleBackColor = true;
            // 
            // rbTuan
            // 
            this.rbTuan.AutoSize = true;
            this.rbTuan.Location = new System.Drawing.Point(661, 37);
            this.rbTuan.Name = "rbTuan";
            this.rbTuan.Size = new System.Drawing.Size(50, 17);
            this.rbTuan.TabIndex = 11;
            this.rbTuan.TabStop = true;
            this.rbTuan.Text = "Tuần";
            this.rbTuan.UseVisualStyleBackColor = true;
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Location = new System.Drawing.Point(708, 37);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(56, 17);
            this.rbThang.TabIndex = 11;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            // 
            // lTrongKhoang
            // 
            this.lTrongKhoang.AutoSize = true;
            this.lTrongKhoang.Location = new System.Drawing.Point(482, 70);
            this.lTrongKhoang.Name = "lTrongKhoang";
            this.lTrongKhoang.Size = new System.Drawing.Size(75, 13);
            this.lTrongKhoang.TabIndex = 3;
            this.lTrongKhoang.Text = "Trong Khoảng";
            this.lTrongKhoang.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(703, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lVa
            // 
            this.lVa.AutoSize = true;
            this.lVa.Location = new System.Drawing.Point(677, 75);
            this.lVa.Name = "lVa";
            this.lVa.Size = new System.Drawing.Size(20, 13);
            this.lVa.TabIndex = 3;
            this.lVa.Text = "Và";
            this.lVa.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // lGoiTheo
            // 
            this.lGoiTheo.AutoSize = true;
            this.lGoiTheo.Location = new System.Drawing.Point(20, 86);
            this.lGoiTheo.Name = "lGoiTheo";
            this.lGoiTheo.Size = new System.Drawing.Size(54, 13);
            this.lGoiTheo.TabIndex = 3;
            this.lGoiTheo.Text = "Gởi Theo:";
            this.lGoiTheo.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // cbGoiTheo
            // 
            this.cbGoiTheo.FormattingEnabled = true;
            this.cbGoiTheo.Location = new System.Drawing.Point(79, 86);
            this.cbGoiTheo.Name = "cbGoiTheo";
            this.cbGoiTheo.Size = new System.Drawing.Size(121, 21);
            this.cbGoiTheo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // QuanLiXeGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbKhong);
            this.Controls.Add(this.rbThang);
            this.Controls.Add(this.rbTuan);
            this.Controls.Add(this.rbNgay);
            this.Controls.Add(this.rbGio);
            this.Controls.Add(this.rbCo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoaXe);
            this.Controls.Add(this.btnSuaXe);
            this.Controls.Add(this.btnThemXe);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpNgayGoi);
            this.Controls.Add(this.txtChuXe);
            this.Controls.Add(this.txtHieuXe);
            this.Controls.Add(this.txtBangSo);
            this.Controls.Add(this.pbHieuXe);
            this.Controls.Add(this.pbBangSo);
            this.Controls.Add(this.pbHinhXe);
            this.Controls.Add(this.pbNguoiGoi);
            this.Controls.Add(this.lChuXe);
            this.Controls.Add(this.lNgayGoi);
            this.Controls.Add(this.lHieuXe);
            this.Controls.Add(this.lBangSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNguoiGoi);
            this.Controls.Add(this.dgvDanhSachXe);
            this.Controls.Add(this.cbGoiTheo);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.lChoTrong);
            this.Controls.Add(this.lTongXe);
            this.Controls.Add(this.lVa);
            this.Controls.Add(this.lTrongKhoang);
            this.Controls.Add(this.lGoiTheo);
            this.Controls.Add(this.lKieuGoi);
            this.Controls.Add(this.lLoc);
            this.Controls.Add(this.lLoaiXe);
            this.Name = "QuanLiXeGoi";
            this.Text = "QuanLiXeGoi";
            this.Load += new System.EventHandler(this.QuanLiXeGoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNguoiGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBangSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHieuXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachXe;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Label lLoaiXe;
        private System.Windows.Forms.Label lNguoiGoi;
        private System.Windows.Forms.PictureBox pbNguoiGoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHinhXe;
        private System.Windows.Forms.Label lTongXe;
        private System.Windows.Forms.Label lChoTrong;
        private System.Windows.Forms.Label lBangSo;
        private System.Windows.Forms.PictureBox pbBangSo;
        private System.Windows.Forms.Label lHieuXe;
        private System.Windows.Forms.TextBox txtBangSo;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.PictureBox pbHieuXe;
        private System.Windows.Forms.Label lNgayGoi;
        private System.Windows.Forms.DateTimePicker dtpNgayGoi;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Button btnSuaXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Label lChuXe;
        private System.Windows.Forms.TextBox txtChuXe;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lLoc;
        private System.Windows.Forms.RadioButton rbCo;
        private System.Windows.Forms.RadioButton rbKhong;
        private System.Windows.Forms.Label lKieuGoi;
        private System.Windows.Forms.RadioButton rbGio;
        private System.Windows.Forms.RadioButton rbNgay;
        private System.Windows.Forms.RadioButton rbTuan;
        private System.Windows.Forms.RadioButton rbThang;
        private System.Windows.Forms.Label lTrongKhoang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lVa;
        private System.Windows.Forms.Label lGoiTheo;
        private System.Windows.Forms.ComboBox cbGoiTheo;
        private System.Windows.Forms.Label label2;
    }
}