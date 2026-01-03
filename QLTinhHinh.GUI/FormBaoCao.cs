using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLTinhHinh.BLL;
using QLTinhHinh.DAL;

namespace QLTinhHinh.GUI
{
    public partial class FormBaoCao : Form
    {
        private DiaPhuongBLL bll = new DiaPhuongBLL();

        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // Load danh sách trạng thái vào ComboBox
            cmbTrangThai.DataSource = bll.GetListTrangThai();
            cmbTrangThai.DisplayMember = "TenTT";
            cmbTrangThai.ValueMember = "MaTT";

            // Mặc định grid trống hoặc load tất cả tùy ý (ở đây để trống cho clean)
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy mã trạng thái đang chọn
                int maTT = (int)cmbTrangThai.SelectedValue;

                // 2. Lấy dữ liệu từ BLL theo mã trạng thái
                List<DiaPhuong> list = bll.GetDiaPhuongByMaTT(maTT);

                // 3. Đổ dữ liệu vào DataGridView (Giả lập báo cáo)
                dgvBaoCao.DataSource = list.Select(x => new
                {
                    MaDP = x.MaDP,
                    TenDP = x.TenDP,
                    SoCaNhiem = x.SoCaNhiemMoi
                }).ToList();

                // 4. Đặt lại tên cột cho đẹp (giống trong hình báo cáo)
                dgvBaoCao.Columns[0].HeaderText = "Mã ĐP";
                dgvBaoCao.Columns[1].HeaderText = "Tên ĐP";
                dgvBaoCao.Columns[2].HeaderText = "Số ca nhiễm";

                // 5. Cập nhật dòng chữ tiêu đề phụ
                // Ví dụ: Tình hình: Bình thường Mới
                lblSubTitle.Text = "Tình hình: " + cmbTrangThai.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}