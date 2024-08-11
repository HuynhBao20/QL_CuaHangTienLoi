using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Views;
using ConnectionDB;
namespace APP.Controllers
{
	//Summary:
	// Class này dùng để thực hiện UI trên giao diện người dùng
	public class UI
	{
		Connection db = new Connection();
		CustomTool custom = new CustomTool();
		public Label MAHD;
		public Label NgayLap;
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		//Hàm hay dùng
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName + ".jpg")) ? fullPath(@"../../Resources/" + ImageName + ".jpg") : fullPath(@"../../Resources/Sp.jpg");
		public string getHoaDon() => db.ExcuteReader("SELECT TRANGTHAI FROM HOADON", "TRANGTHAI") == "Chưa xuất" ? db.ExcuteReader(UI.getBillID, "MAHD") : "";
		//load san pham
		public void loadCombobox(ComboBox combo, string Sql, string display, string Value)
		{
			combo.DataSource = db.loadDB(Sql);
			combo.DisplayMember = display;
			combo.ValueMember = Value;
		}
		public void loadTreeView(TreeView tv)
		{
			DataTable da = db.loadDB("SELECT TENLOAI FROM LOAISP");
			foreach (DataRow item in da.Rows)
			{
				tv.Nodes.Add(item["TENLOAI"].ToString());
			}
		}
		//Load 
		public void UI_LoadProduct(FlowLayoutPanel flp, FlowLayoutPanel billDetail, TextBox ThanhTien)
		{
			DataTable da = db.loadDB("SELECT * FROM SANPHAM");
			if (da.Rows.Count > 0)
			{
				foreach (DataRow item in da.Rows)
				{
					custom.UI_Load(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"),
								   fpathImage(item["MASP"].ToString()), 
								   flp,
								   item["TENSP"].ToString(),
								   135,
								   (sender, e) => Event_Product_Click(sender, e, item["MASP"].ToString(), billDetail, ThanhTien));
				}
			} 
			else
			{
				MessageBox.Show("Không tìm thấy");
			}
		}
		public void UI_BillDetail(FlowLayoutPanel flp, string MAHD)
		{
			Tilte(flp);
			DataTable da = db.loadDB($"exec Select_CTHoaDon '{MAHD}'");
			foreach(DataRow item in da.Rows)
			{
				custom.UI_Load(flp,
							   MAHD,
							   item["Tên sản phẩm"].ToString(),
							   fpathImage(item["Mã sản phẩm"].ToString()),
							   item["Đơn giá"].ToString(),
							   item["Số lượng"].ToString(),
							   item["Thành Tiền"].ToString(),
							   0,
							   (sender, e) => Event_Del_Product_BillDetail(sender, e, item["Mã sản phẩm"].ToString(), flp, MAHD));
			}
		}
		public void Tilte(FlowLayoutPanel flp)
		{
			EventHandler handler = (sender, e) => { };
			custom.UI_Load(flp,
				"",
			   "Tên sản phẩm",
			   fpathImage(""),
			   "Đơn giá",
			   "Số lượng",
			   "Thành Tiền",
			   1,
			   (sender, e) => handler(sender, e));
		}
		public void Ui_Filter_Product(FlowLayoutPanel flp, string SQL, FlowLayoutPanel billDetail, TextBox ThanhTien)
		{
			DataTable da = db.loadDB(SQL);
			foreach (DataRow item in da.Rows)
			{
				custom.UI_Load(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"),
							   fpathImage(item["MASP"].ToString()),
							   flp,
							   item["TENSP"].ToString(),
							   135,
							   (sender, e) => Event_Product_Click(sender, e, item["MASP"].ToString(), billDetail, ThanhTien));

			}
		}
		public void loadCT_HoaDon(FlowLayoutPanel flp, string MAHD)
		{
			string Sql = $"EXEC sp_XuatHoaDon '{MAHD}'";
			DataTable da = db.loadDB(Sql);
			foreach(DataRow item in da.Rows)
			{
				string fpath = fullPath(@"../../Resources/Sp.jpg");
				Panel pnl = new Panel()
				{
					Width = (flp.Width) - 40,
					Height = 210,
					BackColor = Color.White
				};

				Button btn = new Button()
				{
					Width = 150,
					Height = 150,
					Dock = DockStyle.Left,
					BackColor = Color.Transparent,
					BackgroundImage = Image.FromFile(fullPath(fpath)),
					BackgroundImageLayout = ImageLayout.Stretch

				};
				btn.FlatAppearance.BorderSize = 1;
				Label ProductName = new Label()
				{
					Text = item["TENSP"].ToString(),
					Dock = DockStyle.Bottom,
					BackColor = Color.Transparent
				};
				pnl.Controls.Add(btn);
				pnl.Controls.Add(ProductName);
				flp.Controls.Add(pnl);
			}
		}
		public void load_HoaDon_ChuaXuat(FlowLayoutPanel flp, string SQL, Label _MAHD, Label NgayLap, FlowLayoutPanel flowLayout)
		{
			flp.Controls.Clear();
			DataTable da = db.loadDB(SQL);
			foreach (DataRow item in da.Rows)
			{
				this.MAHD = _MAHD;
				this.NgayLap = NgayLap;
				custom.UI_Load("",
							   fullPath(@"../../Resources/iconHoaDon.png"),
							   flp, 
							   $"MAHD: {item["MAHD"].ToString()} { Environment.NewLine + DateTime.Parse(item["NGAYLAP"].ToString()).ToString("dd/MM/yyyy HH:mm:ss")}", 
							   140,
							   (sender, e) => Event_Bill_Process_Click(sender, e, item["MAHD"].ToString(), item["NGAYLAP"].ToString(), flowLayout));
			}
		}
		
		//Xử lý sự kiện
		public void Event_Product_Click(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, TextBox ThanhTien)
		{
			try
			{
				Add_Product_Bill(MASP);
				flp.Controls.Clear();
				if(getHoaDon() == "")
				{
					MessageBox.Show("Chưa tạo hóa đơn");
				} else
				{
					UI_BillDetail(flp, getHoaDon());
				}	
				
				ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien {getHoaDon()}", "Thành tiền");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void Add_Product_Bill(string MASP)
		{
			try
			{
				string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{db.ExcuteReader(UI.getBillID, "MAHD")}', '{MASP}', 1)";
				db.ExcuteQuery(Sql);
			} catch
			{
				db.close();
				int SL = int.Parse(db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{getHoaDon()}' AND MASP = '{MASP}'", "SOLUONG"));
				SL++;
				string Sql = $"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{getHoaDon()}' AND MASP = '{MASP}'";
				db.ExcuteQuery(Sql);
			}
		}
		public void Event_Del_Product_BillDetail(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, string MAHD)
		{
			try
			{
				string Sql = $"DELETE FROM CT_HOADON WHERE MASP = '{MASP}' AND MAHD = '{MAHD}'";
				db.ExcuteQuery(Sql);
				flp.Controls.Clear();
				UI_BillDetail(flp, MAHD);
			}catch(SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		public void Event_Show_Bill(object sender, EventArgs e, string MAHD)
		{
			ChiTietHoaDon ct = new ChiTietHoaDon(MAHD);
			ct.Show();
		}
		public void Event_Bill_Process_Click(object sender, EventArgs e, string MAHD, string NgayLap, FlowLayoutPanel flow)
		{
			flow.Controls.Clear();
			this.MAHD.Text = MAHD;
			this.NgayLap.Text = DateTime.Parse(NgayLap).ToString("dd/MM/yyyy HH:mm:ss");
			UI_BillDetail(flow, MAHD);
		}
		
	}
}
