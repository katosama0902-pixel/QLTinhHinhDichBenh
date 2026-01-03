using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTinhHinh.DAL
{
    public class TrangThaiDAL
    {
        // Hàm lấy tất cả danh sách trạng thái để đổ vào ComboBox
        public List<TrangThai> GetListTrangThai()
        {
            // Khởi tạo đối tượng Context (QLTinhHinhEntities là tên mặc định trong App.config)
            using (var db = new QLTinhHinhEntities())
            {
                // Trả về danh sách tất cả các dòng trong bảng TrangThai
                return db.TrangThais.ToList();
            }
        }
    }
}