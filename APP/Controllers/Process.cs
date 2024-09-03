using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class process
	{
        Connection db = new Connection();
        UI ui = new UI();
        public static string get_NewBillID = "SELECT TOP 1 TRANGTHAI FROM HOADON ORDER BY MAHD desc";
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
        public string create_Pass(string MANV)
		{
            string birthDay = DateTime.Parse(db.ExcuteReader($"SELECT NGAYSINH FROM NHANVIEN WHERE MANV = '{MANV}'", "NGAYSINH")).ToString("dd/MM/yyyy");
            string[] sql = birthDay.Split('/');
            string NewPass = "";
            for(int i = 0; i < sql.Length; i++)
			{
                if(i < sql.Length - 1) NewPass += sql[i];
                else
				{
                    NewPass += sql[i].Substring(2, 2);
				}
			}
            return NewPass;
		}
        public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
        public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg")) ? fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg") : fullPath(@"../../Resources/Sp.jpg");
        public string getHoaDon() => db.ExcuteReader(process.get_NewBillID, "TRANGTHAI") == "Chưa xuất" ? db.ExcuteReader(UI.getBillID, "MAHD") : "";

    }
}
