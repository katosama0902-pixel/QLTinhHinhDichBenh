using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// QUAN TRỌNG: Thư viện này giúp dùng câu lệnh .Include()
using System.Data.Entity;

namespace QLTinhHinh.DAL
{
    public class DiaPhuongDAL
    {
        // 1. Lấy danh sách địa phương để hiển thị lên DataGridView
        public List<DiaPhuong> GetAll()
        {
            using (var db = new QLTinhHinhEntities())
            {
                // .Include("TrangThai") giúp lấy luôn thông tin tên trạng thái đi kèm
                // để hiển thị cột "Tên Trạng Thái" thay vì chỉ hiện số ID
                return db.DiaPhuongs.Include("TrangThai").ToList();
            }
        }

        // 2. Tìm một địa phương theo Mã (Dùng để kiểm tra tồn tại trước khi Thêm/Sửa)
        public DiaPhuong GetByID(string maDP)
        {
            using (var db = new QLTinhHinhEntities())
            {
                // Tìm dòng có MaDP trùng khớp
                return db.DiaPhuongs.FirstOrDefault(p => p.MaDP == maDP);
            }
        }

        // 3. Hàm Thêm mới
        public void Add(DiaPhuong dp)
        {
            using (var db = new QLTinhHinhEntities())
            {
                db.DiaPhuongs.Add(dp); // Thêm vào bộ nhớ
                db.SaveChanges();      // Lưu xuống SQL Server
            }
        }

        // 4. Hàm Cập nhật
        public void Update(DiaPhuong dpNew)
        {
            using (var db = new QLTinhHinhEntities())
            {
                // Tìm lại đối tượng cũ trong DB để sửa
                // Lưu ý: Phải tìm lại thì Entity Framework mới biết dòng nào để update
                var dpOld = db.DiaPhuongs.FirstOrDefault(p => p.MaDP == dpNew.MaDP);

                if (dpOld != null)
                {
                    dpOld.TenDP = dpNew.TenDP;
                    dpOld.SoCaNhiemMoi = dpNew.SoCaNhiemMoi;
                    dpOld.MaTT = dpNew.MaTT;

                    db.SaveChanges(); // Lưu thay đổi
                }
            }
        }
    }
}