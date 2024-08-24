using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class Process
	{
        Connection db = new Connection();
        UI ui = new UI();
        public void ThemHoaDon(FlowLayoutPanel flp_BillDetail, string MAHD, TextBox txtMaSP, TextBox txtTongTien)
        {
            // Kiểm tra xem có bao nhiêu sản phẩm trong hóa đơn hiện tại
            string slResult = db.ExcuteReader($"SELECT COUNT(*) AS 'SL' FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{txtMaSP.Text}'", "SL");

            int ktra;
            if (!int.TryParse(slResult, out ktra))
            {
                MessageBox.Show("Lỗi khi đọc số lượng sản phẩm từ cơ sở dữ liệu.");
                return;
            }

            // Lấy số lượng sản phẩm hiện có
            string slQty = db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{txtMaSP.Text}'", "SOLUONG");

            int SL = 1; // Khởi tạo số lượng mặc định là 1
            if (!string.IsNullOrEmpty(slQty) && int.TryParse(slQty, out SL))
            {
                SL++; // Tăng số lượng lên nếu sản phẩm đã tồn tại trong hóa đơn
            }

            // Nếu sản phẩm chưa có trong hóa đơn, thêm mới, nếu có rồi thì cập nhật số lượng
            string Sql = ktra < 1 ?
                $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{MAHD}', '{txtMaSP.Text}', 1)" :
                $"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{MAHD}' AND MASP = '{txtMaSP.Text}'";

            db.ExcuteQuery(Sql);

            // Cập nhật lại chi tiết hóa đơn
            ui.UI_BillDetail(flp_BillDetail, MAHD, txtTongTien);
        }
    }
}
