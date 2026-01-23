using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;
using QLSV_ConnectDB.BLL;
using QLSV_ConnectDB.DTO;

namespace QLSV_ConnectDB.GUI
{
    public partial class Form1 : Form
    {
        List<SinhVien> dsGoc = new List<SinhVien>();
        SinhVienBLL bll = new SinhVienBLL();

        public Form1()
        {
            InitializeComponent();
            LoadData();

            // Định dạng ngày tháng
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            dtpNgayNhapHoc.Format = DateTimePickerFormat.Custom;
            dtpNgayNhapHoc.CustomFormat = "dd/MM/yyyy";
        }

        void LoadData()
        {
            try
            {
                dgvSinhVien.DataSource = null;
                dgvSinhVien.AutoGenerateColumns = false;
                dgvSinhVien.Columns.Clear();

                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "STT", HeaderText = "STT", Width = 50 });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSV", HeaderText = "Mã SV", Name = "MaSV" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên", Name = "HoTen" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgaySinh", HeaderText = "Ngày sinh" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioiTinh", HeaderText = "Giới tính" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "QueQuan", HeaderText = "Quê quán" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayNhapHoc", HeaderText = "Ngày nhập học" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Khoa", HeaderText = "Khoa" });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaLop", HeaderText = "Mã lớp" });

                dsGoc = bll.GetDS();
                dgvSinhVien.DataSource = dsGoc;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private SinhVien GetEntity()
        {
            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = rbNam.Checked ? "Nam" : (rbNu.Checked ? "Nữ" : null),
                QueQuan = cboQueQuan.SelectedItem?.ToString() ?? cboQueQuan.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                NgayNhapHoc = dtpNgayNhapHoc.Value,
                Khoa = cboKhoa.SelectedItem?.ToString() ?? cboKhoa.Text,
                MaLop = txtMaLop.Text.Trim()
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string res = bll.CheckAndSave(GetEntity(), false);
                if (res == "OK")
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnLamMoi.PerformClick();
                }
                else MessageBox.Show(res, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string res = bll.CheckAndSave(GetEntity(), true);
                if (res == "OK")
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else MessageBox.Show(res, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }
            if (MessageBox.Show($"Xác nhận xóa SV mã: {ma}?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.DeleteSV(ma);
                LoadData();
                btnLamMoi.PerformClick();
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvSinhVien.Rows[e.RowIndex];

            txtMaSV.Text = r.Cells["MaSV"].Value?.ToString() ?? "";
            txtHoTen.Text = r.Cells["HoTen"].Value?.ToString() ?? "";

            if (r.Cells[3].Value != null && DateTime.TryParse(r.Cells[3].Value.ToString(), out DateTime ns))
                dtpNgaySinh.Value = ns;

            string gt = r.Cells[4].Value?.ToString();
            rbNam.Checked = (gt == "Nam");
            rbNu.Checked = (gt == "Nữ");

            cboQueQuan.Text = r.Cells[5].Value?.ToString() ?? "";
            txtDiaChi.Text = r.Cells[6].Value?.ToString() ?? "";

            if (r.Cells[7].Value != null && DateTime.TryParse(r.Cells[7].Value.ToString(), out DateTime nh))
                dtpNgayNhapHoc.Value = nh;

            string khoa = r.Cells[8].Value?.ToString() ?? "";
            cboKhoa.Text = khoa;

            txtMaLop.Text = r.Cells[9].Value?.ToString() ?? "";
            txtMaSV.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = true;
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaLop.Clear();
            cboQueQuan.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayNhapHoc.Value = DateTime.Now;
            txtMaSV.Focus();
        }

        private void dgvSinhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSinhVien.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvSinhVien.DataSource = dsGoc;
                return;
            }

            var ketQua = dsGoc.Where(sv =>
                (sv.MaSV != null && sv.MaSV.ToLower().Contains(keyword)) ||
                (sv.HoTen != null && sv.HoTen.ToLower().Contains(keyword))
            ).ToList();

            if (ketQua.Count > 0)
            {
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show($"Không tìm thấy: '{keyword}'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSinhVien.DataSource = dsGoc;
            }
        }

        
    }
}