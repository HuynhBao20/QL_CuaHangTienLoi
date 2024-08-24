using APP.Views;
using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class Event
	{
		public string BILLID { get; set; }
		public Label NgayLap { get; private set; }

		Connection db = new Connection();
		UI ui = new UI(new Label());
		public void Event_Product_Click(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, TextBox ThanhTien)
		{
			try
			{

				Add_ProductToBill(MASP, ThanhTien);
				flp.Controls.Clear();
				ui.UI_BillDetail(flp, this.BILLID, ThanhTien);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void Add_ProductToBill(string MASP, TextBox ThanhTien)
		{
			string MAHD = this.BILLID == null ? db.getMAHD(db.ExcuteReader(UI.getBillID, "MAHD").Trim(), "HD") : this.BILLID;
			try
			{
				if (MAHD != this.BILLID)
				{
					string themHD = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', 'KH001', 'NV001')";
					db.ExcuteQuery(themHD);
					this.BILLID = MAHD;
				}
				string is_Bill_Active = db.ExcuteReader($"SELECT * FROM HOADON WHERE MAHD = '{MAHD}'", "TRANGTHAI");
				if (is_Bill_Active == "Đã xuất hóa đơn" || is_Bill_Active == "Đã hủy")
				{
					MessageBox.Show("Không thể thêm sản phẩm khi đã xuất hóa đơn");
				}
				else
				{
					string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{MAHD}', '{MASP}', 1)";
					db.ExcuteQuery(Sql);
					ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{MAHD}'", "Thành tiền");
				}

			}
			catch
			{
				//kHI MÀ THỰC HIỆN CÂU LỆNH INSERT Ở TRÊN MÀ BỊ LỖI TRÙNG KHÓA CHI TÍNH (TRÙNG SẢN PHẨM)
				db.close();
				int SL = int.Parse(db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'", "SOLUONG"));
				SL++;
				string Sql = $"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'";
				db.ExcuteQuery(Sql);
			}
		}
		public void Event_Del_Product_BillDetail(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, string MAHD, TextBox ThanhTien)
		{
			try
			{
				string Sql = $"DELETE FROM CT_HOADON WHERE MASP = '{MASP}' AND MAHD = '{MAHD}'";
				db.ExcuteQuery(Sql);
				flp.Controls.Clear();
				ui.UI_BillDetail(flp, MAHD, ThanhTien);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		public void Event_Show_Bill(object sender, EventArgs e, string MAHD)
		{
			ChiTietHoaDon ct = new ChiTietHoaDon(MAHD);
			ct.Show();
		}
		public void Event_Bill_Process_Click(object sender, EventArgs e, string MAHD, string NgayLap, FlowLayoutPanel flow, TextBox ThanhTien)
		{
			flow.Controls.Clear();
			this.BILLID = MAHD;
			this.NgayLap.Text = DateTime.Parse(NgayLap).ToString("dd/MM/yyyy HH:mm:ss");
			ui.UI_BillDetail(flow, MAHD, ThanhTien);
		}

	}
}
