using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTinhHinh.DAL; // Kết nối với lớp DAL

namespace QLTinhHinh.BLL
{
    public class DiaPhuongBLL
    {
        // Khởi tạo các đối tượng DAL để dùng
        private DiaPhuongDAL dal = new DiaPhuongDAL();
        private TrangThaiDAL ttDal = new TrangThaiDAL();

        // 1. Lấy danh sách địa phương (Gọi từ DAL)
        public List<DiaPhuong> GetAll()
        {
            return dal.GetAll();
        }

        // 2. Lấy danh sách trạng thái (Để đổ vào ComboBox)
        public List<TrangThai> GetListTrangThai()
        {
            return ttDal.GetListTrangThai();
        }

        // 3. Lấy thông tin 1 địa phương theo Mã (Dùng để kiểm tra khi Thêm/Sửa)
        public DiaPhuong GetDiaPhuongByID(string maDP)
        {
            return dal.GetByID(maDP);
        }

        public List<DiaPhuong> GetDiaPhuongByMaTT(int maTT)
        {
            // Lấy tất cả dữ liệu, sau đó lọc theo Mã Trạng Thái
            return dal.GetAll().Where(x => x.MaTT == maTT).ToList();
        }

        // 4. Thêm mới địa phương
        public void AddDiaPhuong(DiaPhuong dp)
        {
            // Kiểm tra logic nghiệp vụ (nếu cần)
            // Ví dụ: Đề bài yêu cầu số ca nhiễm >= 0, ta có thể check ở đây hoặc ở GUI
            if (dp.SoCaNhiemMoi < 0)
            {
                throw new Exception("Số ca nhiễm phải lớn hơn hoặc bằng 0");
            }

            dal.Add(dp);
        }

        // 5. Cập nhật địa phương
        public void UpdateDiaPhuong(DiaPhuong dp)
        {
            dal.Update(dp);
        }

        // ==============================================================
        // CÁC HÀM XỬ LÝ NGHIỆP VỤ ĐẶC THÙ CỦA ĐỀ BÀI (F1, F2, Cảnh báo)
        // ==============================================================

        // Xử lý yêu cầu Cảnh báo (Trang 4 - Mục 4): 
        // Kiểm tra xem trạng thái mới có khác trạng thái cũ không?
        public bool IsStatusChanged(string maDP, int newMaTT)
        {
            DiaPhuong oldDP = dal.GetByID(maDP);
            if (oldDP != null)
            {
                // Nếu mã trạng thái cũ KHÁC mã trạng thái mới -> Trả về True (Có thay đổi)
                return oldDP.MaTT != newMaTT;
            }
            return false;
        }

        // Lấy tên trạng thái cũ để hiện lên thông báo: "Thay đổi từ {Bình thường} -> ..."
        public string GetTenTrangThaiByID(int maTT)
        {
            var list = ttDal.GetListTrangThai();
            var tt = list.FirstOrDefault(x => x.MaTT == maTT);
            return tt != null ? tt.TenTT : "";
        }

        // Xử lý yêu cầu F1 (Trang 5 - Mục 5.1): Sắp xếp số ca nhiễm
        public List<DiaPhuong> SortByInfection(bool isAscending)
        {
            List<DiaPhuong> list = dal.GetAll();

            if (isAscending)
            {
                // Sắp xếp tăng dần
                return list.OrderBy(x => x.SoCaNhiemMoi).ToList();
            }
            else
            {
                // Sắp xếp giảm dần
                return list.OrderByDescending(x => x.SoCaNhiemMoi).ToList();
            }
        }

        // Xử lý yêu cầu F2 (Trang 5 - Mục 5.2): Lọc nhóm nguy cơ
        // Nhóm nguy cơ là nhóm có trạng thái KHÁC "Bình thường" (Mã 1)
        public List<DiaPhuong> GetRiskGroup()
        {
            List<DiaPhuong> list = dal.GetAll();
            // Lọc ra những địa phương có MaTT != 1
            return list.Where(x => x.MaTT != 1).ToList();
        }
    }
}