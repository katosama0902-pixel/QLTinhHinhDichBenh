using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLTinhHinh.BLL; // Gọi lớp nghiệp vụ
using QLTinhHinh.DAL; // Gọi lớp dữ liệu để dùng các class Model

namespace QLTinhHinh.GUI
{
    public partial class Form1 : Form
    {
        // Khởi tạo BLL
        private DiaPhuongBLL bll = new DiaPhuongBLL();
        // Biến cờ để kiểm tra đang sắp xếp tăng hay giảm (cho chức năng F1)
        private bool isAscending = true;

        public Form1()
        {
            InitializeComponent();
        }

        // ===============================================
        // 1. SỰ KIỆN LOAD FORM
        // ===============================================
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataToGrid(bll.GetAll()); // Mặc định load tất cả

            // Đăng ký phím tắt cho Menu (F1, F2)
            mnuSapXep.ShortcutKeys = Keys.F1;
            mnuNguyCo.ShortcutKeys = Keys.F2;
        }

        // Hàm đổ dữ liệu vào DataGridView
        private void LoadDataToGrid(List<DiaPhuong> list)
        {
            // Dùng Select để chỉ lấy những cột cần thiết và hiển thị Tên trạng thái thay vì Mã
            dgvDiaPhuong.DataSource = list.Select(x => new
            {
                MaDP = x.MaDP,
                TenDP = x.TenDP,
                SoCaNhiem = x.SoCaNhiemMoi,
                TrangThai = x.TrangThai != null ? x.TrangThai.TenTT : "" // Lấy tên trạng thái
            }).ToList();
        }

        // Hàm đổ dữ liệu vào ComboBox
        private void LoadComboBox()
        {
            cmbTrangThai.DataSource = bll.GetListTrangThai();
            cmbTrangThai.DisplayMember = "TenTT"; // Hiển thị tên
            cmbTrangThai.ValueMember = "MaTT";    // Giá trị ngầm là Mã
        }

        // ===============================================
        // 2. SỰ KIỆN CLICK VÀO GRID (Đổ dữ liệu ngược lên ô nhập) [cite: 173]
        // ===============================================
        private void dgvDiaPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiaPhuong.Rows[e.RowIndex];
                txtMaDP.Text = row.Cells["MaDP"].Value.ToString();
                txtTenDP.Text = row.Cells["TenDP"].Value.ToString();
                txtSoCa.Text = row.Cells["SoCaNhiem"].Value.ToString();

                // Chọn lại ComboBox cho đúng tên trạng thái đang hiển thị
                string tenTT = row.Cells["TrangThai"].Value.ToString();
                cmbTrangThai.Text = tenTT;
            }
        }

        // ===============================================
        // 3. CHỨC NĂNG THÊM [cite: 174-179]
        // ===============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate 1: Không được để trống
                if (string.IsNullOrWhiteSpace(txtMaDP.Text) || string.IsNullOrWhiteSpace(txtTenDP.Text) || string.IsNullOrWhiteSpace(txtSoCa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                // Validate 2: Mã phải 3 ký tự
                if (txtMaDP.Text.Length != 3)
                {
                    MessageBox.Show("Mã địa phương phải đúng 3 ký tự!", "Lỗi");
                    return;
                }

                // Validate 3: Số ca nhiễm >= 0
                int soCa;
                if (!int.TryParse(txtSoCa.Text, out soCa) || soCa < 0)
                {
                    MessageBox.Show("Số ca nhiễm phải là số và lớn hơn hoặc bằng 0!", "Lỗi");
                    return;
                }

                // Kiểm tra trùng mã
                if (bll.GetDiaPhuongByID(txtMaDP.Text) != null)
                {
                    MessageBox.Show("Mã địa phương này đã tồn tại!", "Lỗi");
                    return;
                }

                // Thêm mới
                DiaPhuong dp = new DiaPhuong();
                dp.MaDP = txtMaDP.Text;
                dp.TenDP = txtTenDP.Text;
                dp.SoCaNhiemMoi = soCa;
                dp.MaTT = (int)cmbTrangThai.SelectedValue;

                bll.AddDiaPhuong(dp);
                MessageBox.Show("Thêm mới thành công!");
                LoadDataToGrid(bll.GetAll()); // Load lại lưới
                ResetControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ===============================================
        // 4. CHỨC NĂNG CẬP NHẬT [cite: 180-195]
        // ===============================================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maDP = txtMaDP.Text;
                // Kiểm tra tồn tại
                DiaPhuong oldDP = bll.GetDiaPhuongByID(maDP);
                if (oldDP == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin địa phương!", "Thông báo");
                    return;
                }

                int newMaTT = (int)cmbTrangThai.SelectedValue;
                int soCa = int.Parse(txtSoCa.Text);

                // LOGIC CẢNH BÁO: Kiểm tra xem trạng thái có đổi không?
                if (bll.IsStatusChanged(maDP, newMaTT))
                {
                    string oldStatusName = bll.GetTenTrangThaiByID(oldDP.MaTT);
                    string newStatusName = cmbTrangThai.Text;

                    DialogResult result = MessageBox.Show(
                        $"Địa phương có sự thay đổi từ {oldStatusName} -> {newStatusName}?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return; // Nếu chọn No thì dừng lại, không sửa
                    }
                }

                // Thực hiện cập nhật
                DiaPhuong dpNew = new DiaPhuong();
                dpNew.MaDP = maDP;
                dpNew.TenDP = txtTenDP.Text;
                dpNew.SoCaNhiemMoi = soCa;
                dpNew.MaTT = newMaTT;

                bll.UpdateDiaPhuong(dpNew);
                MessageBox.Show("Cập nhật thành công!");
                LoadDataToGrid(bll.GetAll());
                ResetControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Hàm xóa trắng ô nhập liệu
        private void ResetControl()
        {
            txtMaDP.Clear();
            txtTenDP.Clear();
            txtSoCa.Clear();
            cmbTrangThai.SelectedIndex = 0;
        }

        // ===============================================
        // 5. CHỨC NĂNG MENU (F1, F2) [cite: 198-240]
                    // ===============================================

        // F1: Sắp xếp
        private void mnuSapXep_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái sắp xếp (Tăng -> Giảm -> Tăng)
            isAscending = !isAscending;

            var list = bll.SortByInfection(isAscending);
            LoadDataToGrid(list);
        }

        // F2: Nhóm nguy cơ
        private void mnuNguyCo_Click(object sender, EventArgs e)
        {
            var list = bll.GetRiskGroup();
            LoadDataToGrid(list);
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao frm = new FormBaoCao();
            frm.ShowDialog(); // Hiển thị form báo cáo
        }
    }
}