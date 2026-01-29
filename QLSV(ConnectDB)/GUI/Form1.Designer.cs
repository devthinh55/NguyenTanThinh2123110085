using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLSV_ConnectDB.GUI
{
    // Đảm bảo cùng Namespace và partial class với Form1.cs
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhapHoc = new System.Windows.Forms.DateTimePicker();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaynhaphoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cboKhoaFilter = new System.Windows.Forms.ComboBox();
            this.cboGioiTinhFilter = new System.Windows.Forms.ComboBox();
            this.dtFromYear = new System.Windows.Forms.DateTimePicker();
            this.dtToYear = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnXoaNhieu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(571, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.cboQueQuan);
            this.groupBox1.Controls.Add(this.dtpNgayNhapHoc);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(407, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(289, 163);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Nữ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(175, 163);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 16);
            this.label19.TabIndex = 19;
            this.label19.Text = "Nam";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 329);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Mã lớp:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 295);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Khoa:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Địa chỉ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Quê quán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 196);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ngày nhập học:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ngày sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã sv:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(151, 325);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(217, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // cboKhoa
            // 
            this.cboKhoa.Items.AddRange(new object[] {
            "CNTT",
            "Kinh tế",
            "Quản trị",
            "Ngoại ngữ",
            "Kỹ thuật điện",
            "Cơ khí Luật",
            "Y dược ",
            "Du lịch - Khách sạn",
            "Sư phạm Xây dựng"});
            this.cboKhoa.Location = new System.Drawing.Point(151, 292);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(217, 24);
            this.cboKhoa.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(151, 259);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 22);
            this.txtDiaChi.TabIndex = 3;
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.Items.AddRange(new object[] {
            "An Giang ",
            "Bà Rịa - Vũng Tàu ",
            "Bắc Giang",
            "Bắc Kạn ",
            "Bạc Liêu ",
            "Bắc Ninh",
            "Bến Tre ",
            "Bình Định ",
            "Bình Dương ",
            "Bình Phước ",
            "Bình Thuận ",
            "Cà Mau",
            "Cần Thơ ",
            "Cao Bằng ",
            "Đà Nẵng",
            "Đắk Lắk ",
            "Đắk Nông ",
            "Điện Biên ",
            "Đồng Nai",
            "Đồng Tháp ",
            "Gia Lai ",
            "Hà Giang",
            "Hà Nam ",
            "Hà Nội ",
            "Hà Tĩnh ",
            "Hải Dương ",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình ",
            "Hưng Yên ",
            "Khánh Hòa ",
            "Kiên Giang ",
            "Kon Tum ",
            "Lai Châu ",
            "Lâm Đồng ",
            "Lạng Sơn ",
            "Lào Cai ",
            "Long An ",
            "Nam Định ",
            "Nghệ An ",
            "Ninh Bình ",
            "Ninh Thuận ",
            "Phú Thọ ",
            "Phú Yên ",
            "Quảng Bình",
            "Quảng Nam ",
            "Quảng Ngãi ",
            "Quảng Ninh ",
            "Quảng Trị ",
            "Sóc Trăng",
            "Sơn La ",
            "Tây Ninh ",
            "Thái Bình ",
            "Thái Nguyên ",
            "Thanh Hóa ",
            "Thừa Thiên Huế ",
            "Tiền Giang ",
            "TP. Hồ Chí Minh ",
            "Trà Vinh ",
            "Tuyên Quang ",
            "Vĩnh Long ",
            "Vĩnh Phúc ",
            "Yên Bái"});
            this.cboQueQuan.Location = new System.Drawing.Point(151, 222);
            this.cboQueQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(217, 24);
            this.cboQueQuan.TabIndex = 4;
            // 
            // dtpNgayNhapHoc
            // 
            this.dtpNgayNhapHoc.Location = new System.Drawing.Point(151, 188);
            this.dtpNgayNhapHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc";
            this.dtpNgayNhapHoc.Size = new System.Drawing.Size(217, 22);
            this.dtpNgayNhapHoc.TabIndex = 5;
            // 
            // rbNu
            // 
            this.rbNu.Location = new System.Drawing.Point(323, 156);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(139, 30);
            this.rbNu.TabIndex = 6;
            // 
            // rbNam
            // 
            this.rbNam.Location = new System.Drawing.Point(216, 158);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(139, 30);
            this.rbNam.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(151, 132);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(217, 22);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(151, 97);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(217, 22);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(151, 60);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(217, 22);
            this.txtMaSV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSV,
            this.colHoten,
            this.colNgaysinh,
            this.colGioitinh,
            this.colNgaynhaphoc,
            this.colQuequan,
            this.colDiachi,
            this.colKhoa,
            this.colMalop});
            this.dgvSinhVien.Location = new System.Drawing.Point(407, 177);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1029, 325);
            this.dgvSinhVien.TabIndex = 2;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSinhVien_RowPostPaint);
            // 
            // colMaSV
            // 
            this.colMaSV.MinimumWidth = 6;
            this.colMaSV.Name = "colMaSV";
            // 
            // colHoten
            // 
            this.colHoten.MinimumWidth = 6;
            this.colHoten.Name = "colHoten";
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.MinimumWidth = 6;
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colGioitinh
            // 
            this.colGioitinh.MinimumWidth = 6;
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colNgaynhaphoc
            // 
            this.colNgaynhaphoc.MinimumWidth = 6;
            this.colNgaynhaphoc.Name = "colNgaynhaphoc";
            // 
            // colQuequan
            // 
            this.colQuequan.MinimumWidth = 6;
            this.colQuequan.Name = "colQuequan";
            // 
            // colDiachi
            // 
            this.colDiachi.MinimumWidth = 6;
            this.colDiachi.Name = "colDiachi";
            // 
            // colKhoa
            // 
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            // 
            // colMalop
            // 
            this.colMalop.MinimumWidth = 6;
            this.colMalop.Name = "colMalop";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 510);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(136, 510);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(18, 567);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 37);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(268, 510);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 37);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(415, 144);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(221, 22);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(644, 141);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(44, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "🔎";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportExcel.Location = new System.Drawing.Point(1311, 127);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(125, 42);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Xuất file Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cboKhoaFilter
            // 
            this.cboKhoaFilter.FormattingEnabled = true;
            this.cboKhoaFilter.Items.AddRange(new object[] {
            "CNTT",
            "Kinh tế",
            "Quản trị",
            "Ngoại ngữ",
            "Kỹ thuật điện",
            "Cơ khí Luật",
            "Y dược ",
            "Du lịch - Khách sạn",
            "Sư phạm Xây dựng"});
            this.cboKhoaFilter.Location = new System.Drawing.Point(737, 96);
            this.cboKhoaFilter.Name = "cboKhoaFilter";
            this.cboKhoaFilter.Size = new System.Drawing.Size(121, 24);
            this.cboKhoaFilter.TabIndex = 10;
            // 
            // cboGioiTinhFilter
            // 
            this.cboGioiTinhFilter.FormattingEnabled = true;
            this.cboGioiTinhFilter.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhFilter.Location = new System.Drawing.Point(737, 141);
            this.cboGioiTinhFilter.Name = "cboGioiTinhFilter";
            this.cboGioiTinhFilter.Size = new System.Drawing.Size(121, 24);
            this.cboGioiTinhFilter.TabIndex = 11;
            // 
            // dtFromYear
            // 
            this.dtFromYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromYear.Location = new System.Drawing.Point(911, 96);
            this.dtFromYear.Name = "dtFromYear";
            this.dtFromYear.Size = new System.Drawing.Size(200, 22);
            this.dtFromYear.TabIndex = 12;
            // 
            // dtToYear
            // 
            this.dtToYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToYear.Location = new System.Drawing.Point(911, 144);
            this.dtToYear.Name = "dtToYear";
            this.dtToYear.Size = new System.Drawing.Size(200, 22);
            this.dtToYear.TabIndex = 13;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoc.Location = new System.Drawing.Point(644, 98);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 38);
            this.btnLoc.TabIndex = 14;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSapXep.Location = new System.Drawing.Point(1155, 92);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 39);
            this.btnSapXep.TabIndex = 15;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cboSapXep
            // 
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "Họ tên",
            "Ngày sinh",
            "Ngày nhập học",
            ""});
            this.cboSapXep.Location = new System.Drawing.Point(1155, 137);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(121, 24);
            this.cboSapXep.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(738, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 16);
            this.label21.TabIndex = 17;
            this.label21.Text = "Khoa:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(738, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 16);
            this.label22.TabIndex = 18;
            this.label22.Text = "Giới tính:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(912, 76);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 16);
            this.label23.TabIndex = 19;
            this.label23.Text = "Năm nhập học từ:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(913, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 16);
            this.label24.TabIndex = 20;
            this.label24.Text = "Đến:";
            // 
            // btnXoaNhieu
            // 
            this.btnXoaNhieu.Location = new System.Drawing.Point(136, 567);
            this.btnXoaNhieu.Name = "btnXoaNhieu";
            this.btnXoaNhieu.Size = new System.Drawing.Size(100, 37);
            this.btnXoaNhieu.TabIndex = 21;
            this.btnXoaNhieu.Text = "Xóa nhiều";
            this.btnXoaNhieu.UseVisualStyleBackColor = true;
            this.btnXoaNhieu.Click += new System.EventHandler(this.btnXoaNhieu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 645);
            this.Controls.Add(this.btnXoaNhieu);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dtToYear);
            this.Controls.Add(this.dtFromYear);
            this.Controls.Add(this.cboGioiTinhFilter);
            this.Controls.Add(this.cboKhoaFilter);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // KHAI BÁO BIẾN CÁC CONTROL
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapHoc;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaynhaphoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMalop;
        // Tên các nút đã fix khớp với Form1.cs
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private Label label4;
        private Label label18;
        private Label label17;
        private Label label15;
        private Label label16;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label20;
        private Label label19;
        private Button btnExportExcel;
        private ComboBox cboKhoaFilter;
        private ComboBox cboGioiTinhFilter;
        private DateTimePicker dtFromYear;
        private DateTimePicker dtToYear;
        private Button btnLoc;
        private Button btnSapXep;
        private ComboBox cboSapXep;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnXoaNhieu;
    }
}