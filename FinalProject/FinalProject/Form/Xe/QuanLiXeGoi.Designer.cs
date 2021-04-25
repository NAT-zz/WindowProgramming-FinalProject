
namespace FinalProject
{
    partial class fQuanLiXeGoi
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
            this.lCho = new System.Windows.Forms.Label();
            this.lBangSo = new System.Windows.Forms.Label();
            this.pbBangSo = new System.Windows.Forms.PictureBox();
            this.lHieuXe = new System.Windows.Forms.Label();
            this.txtBangSo = new System.Windows.Forms.TextBox();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.pbHieuXe = new System.Windows.Forms.PictureBox();
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
            this.lTong = new System.Windows.Forms.Label();
            this.lChoTrong = new System.Windows.Forms.Label();
            this.btnAnhHieuXe = new System.Windows.Forms.Button();
            this.btnAnhBangSo = new System.Windows.Forms.Button();
            this.btnAnhNguoiGoi = new System.Windows.Forms.Button();
            this.btnAnhXe = new System.Windows.Forms.Button();
            this.txtMaXe = new System.Windows.Forms.TextBox();
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
            this.dgvDanhSachXe.Location = new System.Drawing.Point(518, 208);
            this.dgvDanhSachXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhSachXe.Name = "dgvDanhSachXe";
            this.dgvDanhSachXe.RowHeadersWidth = 62;
            this.dgvDanhSachXe.Size = new System.Drawing.Size(681, 480);
            this.dgvDanhSachXe.TabIndex = 5;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy ",
            "Xe hơi"});
            this.cbLoaiXe.Location = new System.Drawing.Point(120, 25);
            this.cbLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(139, 28);
            this.cbLoaiXe.TabIndex = 4;
            this.cbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiXe_SelectedIndexChanged);
            // 
            // lLoaiXe
            // 
            this.lLoaiXe.AutoSize = true;
            this.lLoaiXe.Location = new System.Drawing.Point(42, 25);
            this.lLoaiXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLoaiXe.Name = "lLoaiXe";
            this.lLoaiXe.Size = new System.Drawing.Size(67, 20);
            this.lLoaiXe.TabIndex = 3;
            this.lLoaiXe.Text = "Loại Xe:";
            this.lLoaiXe.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // lNguoiGoi
            // 
            this.lNguoiGoi.AutoSize = true;
            this.lNguoiGoi.Location = new System.Drawing.Point(263, 459);
            this.lNguoiGoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNguoiGoi.Name = "lNguoiGoi";
            this.lNguoiGoi.Size = new System.Drawing.Size(116, 20);
            this.lNguoiGoi.TabIndex = 6;
            this.lNguoiGoi.Text = "Ảnh Người Gởi:";
            // 
            // pbNguoiGoi
            // 
            this.pbNguoiGoi.Location = new System.Drawing.Point(267, 480);
            this.pbNguoiGoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbNguoiGoi.Name = "pbNguoiGoi";
            this.pbNguoiGoi.Size = new System.Drawing.Size(225, 170);
            this.pbNguoiGoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNguoiGoi.TabIndex = 7;
            this.pbNguoiGoi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ảnh Xe:";
            // 
            // pbHinhXe
            // 
            this.pbHinhXe.Location = new System.Drawing.Point(34, 480);
            this.pbHinhXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHinhXe.Name = "pbHinhXe";
            this.pbHinhXe.Size = new System.Drawing.Size(225, 170);
            this.pbHinhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhXe.TabIndex = 7;
            this.pbHinhXe.TabStop = false;
            // 
            // lTongXe
            // 
            this.lTongXe.AutoSize = true;
            this.lTongXe.Location = new System.Drawing.Point(514, 183);
            this.lTongXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTongXe.Name = "lTongXe";
            this.lTongXe.Size = new System.Drawing.Size(73, 20);
            this.lTongXe.TabIndex = 3;
            this.lTongXe.Text = "Tổng Xe:";
            // 
            // lCho
            // 
            this.lCho.AutoSize = true;
            this.lCho.Location = new System.Drawing.Point(843, 183);
            this.lCho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCho.Name = "lCho";
            this.lCho.Size = new System.Drawing.Size(145, 20);
            this.lCho.TabIndex = 3;
            this.lCho.Text = "Chố Trống Còn Lại:";
            // 
            // lBangSo
            // 
            this.lBangSo.AutoSize = true;
            this.lBangSo.Location = new System.Drawing.Point(33, 349);
            this.lBangSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBangSo.Name = "lBangSo";
            this.lBangSo.Size = new System.Drawing.Size(75, 20);
            this.lBangSo.TabIndex = 6;
            this.lBangSo.Text = "Bảng Số:";
            this.lBangSo.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // pbBangSo
            // 
            this.pbBangSo.Location = new System.Drawing.Point(398, 344);
            this.pbBangSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBangSo.Name = "pbBangSo";
            this.pbBangSo.Size = new System.Drawing.Size(111, 92);
            this.pbBangSo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBangSo.TabIndex = 7;
            this.pbBangSo.TabStop = false;
            this.pbBangSo.Click += new System.EventHandler(this.pbBangSo_Click);
            // 
            // lHieuXe
            // 
            this.lHieuXe.AutoSize = true;
            this.lHieuXe.Location = new System.Drawing.Point(42, 227);
            this.lHieuXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHieuXe.Name = "lHieuXe";
            this.lHieuXe.Size = new System.Drawing.Size(70, 20);
            this.lHieuXe.TabIndex = 6;
            this.lHieuXe.Text = "Hiệu Xe:";
            this.lHieuXe.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // txtBangSo
            // 
            this.txtBangSo.Location = new System.Drawing.Point(118, 344);
            this.txtBangSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBangSo.Name = "txtBangSo";
            this.txtBangSo.Size = new System.Drawing.Size(265, 26);
            this.txtBangSo.TabIndex = 8;
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(122, 227);
            this.txtHieuXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(265, 26);
            this.txtHieuXe.TabIndex = 8;
            // 
            // pbHieuXe
            // 
            this.pbHieuXe.Location = new System.Drawing.Point(398, 227);
            this.pbHieuXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHieuXe.Name = "pbHieuXe";
            this.pbHieuXe.Size = new System.Drawing.Size(112, 83);
            this.pbHieuXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHieuXe.TabIndex = 7;
            this.pbHieuXe.TabStop = false;
            this.pbHieuXe.Click += new System.EventHandler(this.pbBangSo_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Location = new System.Drawing.Point(118, 700);
            this.btnThemXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(112, 35);
            this.btnThemXe.TabIndex = 10;
            this.btnThemXe.Text = "Thêm Xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Location = new System.Drawing.Point(254, 700);
            this.btnSuaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(112, 35);
            this.btnSuaXe.TabIndex = 10;
            this.btnSuaXe.Text = "Sửa Xe";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Location = new System.Drawing.Point(394, 700);
            this.btnXoaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(112, 35);
            this.btnXoaXe.TabIndex = 10;
            this.btnXoaXe.Text = "Xóa Xe";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            // 
            // lChuXe
            // 
            this.lChuXe.AutoSize = true;
            this.lChuXe.Location = new System.Drawing.Point(42, 139);
            this.lChuXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChuXe.Name = "lChuXe";
            this.lChuXe.Size = new System.Drawing.Size(66, 20);
            this.lChuXe.TabIndex = 6;
            this.lChuXe.Text = "Chủ Xe:";
            this.lChuXe.Click += new System.EventHandler(this.lBangSo_Click);
            // 
            // txtChuXe
            // 
            this.txtChuXe.Location = new System.Drawing.Point(118, 134);
            this.txtChuXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChuXe.Name = "txtChuXe";
            this.txtChuXe.Size = new System.Drawing.Size(265, 26);
            this.txtChuXe.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1086, 697);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lLoc
            // 
            this.lLoc.AutoSize = true;
            this.lLoc.Location = new System.Drawing.Point(722, 14);
            this.lLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLoc.Name = "lLoc";
            this.lLoc.Size = new System.Drawing.Size(110, 20);
            this.lLoc.TabIndex = 3;
            this.lLoc.Text = "Sử Dụng Lọc :";
            this.lLoc.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // rbCo
            // 
            this.rbCo.AutoSize = true;
            this.rbCo.Location = new System.Drawing.Point(885, 11);
            this.rbCo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCo.Name = "rbCo";
            this.rbCo.Size = new System.Drawing.Size(54, 24);
            this.rbCo.TabIndex = 11;
            this.rbCo.TabStop = true;
            this.rbCo.Text = "Có";
            this.rbCo.UseVisualStyleBackColor = true;
            // 
            // rbKhong
            // 
            this.rbKhong.AutoSize = true;
            this.rbKhong.Location = new System.Drawing.Point(1018, 11);
            this.rbKhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKhong.Name = "rbKhong";
            this.rbKhong.Size = new System.Drawing.Size(80, 24);
            this.rbKhong.TabIndex = 11;
            this.rbKhong.TabStop = true;
            this.rbKhong.Text = "Không";
            this.rbKhong.UseVisualStyleBackColor = true;
            // 
            // lKieuGoi
            // 
            this.lKieuGoi.AutoSize = true;
            this.lKieuGoi.Location = new System.Drawing.Point(756, 63);
            this.lKieuGoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lKieuGoi.Name = "lKieuGoi";
            this.lKieuGoi.Size = new System.Drawing.Size(77, 20);
            this.lKieuGoi.TabIndex = 3;
            this.lKieuGoi.Text = "Kiểu Gởi :";
            this.lKieuGoi.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // rbGio
            // 
            this.rbGio.AutoSize = true;
            this.rbGio.Location = new System.Drawing.Point(844, 57);
            this.rbGio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbGio.Name = "rbGio";
            this.rbGio.Size = new System.Drawing.Size(59, 24);
            this.rbGio.TabIndex = 11;
            this.rbGio.TabStop = true;
            this.rbGio.Text = "Giờ";
            this.rbGio.UseVisualStyleBackColor = true;
            // 
            // rbNgay
            // 
            this.rbNgay.AutoSize = true;
            this.rbNgay.Location = new System.Drawing.Point(918, 57);
            this.rbNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNgay.Name = "rbNgay";
            this.rbNgay.Size = new System.Drawing.Size(70, 24);
            this.rbNgay.TabIndex = 11;
            this.rbNgay.TabStop = true;
            this.rbNgay.Text = "Ngày";
            this.rbNgay.UseVisualStyleBackColor = true;
            // 
            // rbTuan
            // 
            this.rbTuan.AutoSize = true;
            this.rbTuan.Location = new System.Drawing.Point(992, 57);
            this.rbTuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTuan.Name = "rbTuan";
            this.rbTuan.Size = new System.Drawing.Size(70, 24);
            this.rbTuan.TabIndex = 11;
            this.rbTuan.TabStop = true;
            this.rbTuan.Text = "Tuần";
            this.rbTuan.UseVisualStyleBackColor = true;
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Location = new System.Drawing.Point(1062, 57);
            this.rbThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(79, 24);
            this.rbThang.TabIndex = 11;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            // 
            // lTrongKhoang
            // 
            this.lTrongKhoang.AutoSize = true;
            this.lTrongKhoang.Location = new System.Drawing.Point(723, 108);
            this.lTrongKhoang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTrongKhoang.Name = "lTrongKhoang";
            this.lTrongKhoang.Size = new System.Drawing.Size(109, 20);
            this.lTrongKhoang.TabIndex = 3;
            this.lTrongKhoang.Text = "Trong Khoảng";
            this.lTrongKhoang.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(844, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1054, 108);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lVa
            // 
            this.lVa.AutoSize = true;
            this.lVa.Location = new System.Drawing.Point(1016, 115);
            this.lVa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVa.Name = "lVa";
            this.lVa.Size = new System.Drawing.Size(29, 20);
            this.lVa.TabIndex = 3;
            this.lVa.Text = "Và";
            this.lVa.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // lGoiTheo
            // 
            this.lGoiTheo.AutoSize = true;
            this.lGoiTheo.Location = new System.Drawing.Point(288, 28);
            this.lGoiTheo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGoiTheo.Name = "lGoiTheo";
            this.lGoiTheo.Size = new System.Drawing.Size(78, 20);
            this.lGoiTheo.TabIndex = 3;
            this.lGoiTheo.Text = "Gởi Theo:";
            this.lGoiTheo.Click += new System.EventHandler(this.lLoaiXe_Click);
            // 
            // cbGoiTheo
            // 
            this.cbGoiTheo.FormattingEnabled = true;
            this.cbGoiTheo.Items.AddRange(new object[] {
            "Giờ",
            "Ngày",
            "Tuần",
            "Tháng"});
            this.cbGoiTheo.Location = new System.Drawing.Point(374, 24);
            this.cbGoiTheo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGoiTheo.Name = "cbGoiTheo";
            this.cbGoiTheo.Size = new System.Drawing.Size(180, 28);
            this.cbGoiTheo.TabIndex = 4;
            // 
            // lTong
            // 
            this.lTong.AutoSize = true;
            this.lTong.Location = new System.Drawing.Point(631, 183);
            this.lTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTong.Name = "lTong";
            this.lTong.Size = new System.Drawing.Size(51, 20);
            this.lTong.TabIndex = 12;
            this.lTong.Text = "label2";
            this.lTong.Click += new System.EventHandler(this.label2_Click);
            // 
            // lChoTrong
            // 
            this.lChoTrong.AutoSize = true;
            this.lChoTrong.Location = new System.Drawing.Point(1016, 183);
            this.lChoTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChoTrong.Name = "lChoTrong";
            this.lChoTrong.Size = new System.Drawing.Size(51, 20);
            this.lChoTrong.TabIndex = 13;
            this.lChoTrong.Text = "label3";
            // 
            // btnAnhHieuXe
            // 
            this.btnAnhHieuXe.Location = new System.Drawing.Point(398, 306);
            this.btnAnhHieuXe.Name = "btnAnhHieuXe";
            this.btnAnhHieuXe.Size = new System.Drawing.Size(113, 30);
            this.btnAnhHieuXe.TabIndex = 14;
            this.btnAnhHieuXe.Text = "Tải ảnh lên";
            this.btnAnhHieuXe.UseVisualStyleBackColor = true;
            this.btnAnhHieuXe.Click += new System.EventHandler(this.btnAnhHieuXe_Click);
            // 
            // btnAnhBangSo
            // 
            this.btnAnhBangSo.Location = new System.Drawing.Point(398, 432);
            this.btnAnhBangSo.Name = "btnAnhBangSo";
            this.btnAnhBangSo.Size = new System.Drawing.Size(113, 30);
            this.btnAnhBangSo.TabIndex = 15;
            this.btnAnhBangSo.Text = "Tải ảnh lên";
            this.btnAnhBangSo.UseVisualStyleBackColor = true;
            this.btnAnhBangSo.Click += new System.EventHandler(this.btnAnhBangSo_Click);
            // 
            // btnAnhNguoiGoi
            // 
            this.btnAnhNguoiGoi.Location = new System.Drawing.Point(267, 649);
            this.btnAnhNguoiGoi.Name = "btnAnhNguoiGoi";
            this.btnAnhNguoiGoi.Size = new System.Drawing.Size(225, 30);
            this.btnAnhNguoiGoi.TabIndex = 16;
            this.btnAnhNguoiGoi.Text = "Tải ảnh lên";
            this.btnAnhNguoiGoi.UseVisualStyleBackColor = true;
            this.btnAnhNguoiGoi.Click += new System.EventHandler(this.btnAnhNguoiGoi_Click);
            // 
            // btnAnhXe
            // 
            this.btnAnhXe.Location = new System.Drawing.Point(34, 649);
            this.btnAnhXe.Name = "btnAnhXe";
            this.btnAnhXe.Size = new System.Drawing.Size(225, 30);
            this.btnAnhXe.TabIndex = 17;
            this.btnAnhXe.Text = "Tải ảnh lên";
            this.btnAnhXe.UseVisualStyleBackColor = true;
            this.btnAnhXe.Click += new System.EventHandler(this.btnAnhXe_Click);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(118, 87);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(265, 26);
            this.txtMaXe.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã Xe:";
            // 
            // fQuanLiXeGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 757);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnhXe);
            this.Controls.Add(this.btnAnhNguoiGoi);
            this.Controls.Add(this.btnAnhBangSo);
            this.Controls.Add(this.btnAnhHieuXe);
            this.Controls.Add(this.lChoTrong);
            this.Controls.Add(this.lTong);
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
            this.Controls.Add(this.txtChuXe);
            this.Controls.Add(this.txtHieuXe);
            this.Controls.Add(this.txtBangSo);
            this.Controls.Add(this.pbHieuXe);
            this.Controls.Add(this.pbBangSo);
            this.Controls.Add(this.pbHinhXe);
            this.Controls.Add(this.pbNguoiGoi);
            this.Controls.Add(this.lChuXe);
            this.Controls.Add(this.lHieuXe);
            this.Controls.Add(this.lBangSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNguoiGoi);
            this.Controls.Add(this.dgvDanhSachXe);
            this.Controls.Add(this.cbGoiTheo);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.lCho);
            this.Controls.Add(this.lTongXe);
            this.Controls.Add(this.lVa);
            this.Controls.Add(this.lTrongKhoang);
            this.Controls.Add(this.lGoiTheo);
            this.Controls.Add(this.lKieuGoi);
            this.Controls.Add(this.lLoc);
            this.Controls.Add(this.lLoaiXe);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fQuanLiXeGoi";
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
        private System.Windows.Forms.Label lCho;
        private System.Windows.Forms.Label lBangSo;
        private System.Windows.Forms.PictureBox pbBangSo;
        private System.Windows.Forms.Label lHieuXe;
        private System.Windows.Forms.TextBox txtBangSo;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.PictureBox pbHieuXe;
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
        private System.Windows.Forms.Label lTong;
        private System.Windows.Forms.Label lChoTrong;
        private System.Windows.Forms.Button btnAnhHieuXe;
        private System.Windows.Forms.Button btnAnhBangSo;
        private System.Windows.Forms.Button btnAnhNguoiGoi;
        private System.Windows.Forms.Button btnAnhXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
    }
}