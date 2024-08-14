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
using ConnectionDB.Logic;

namespace APP.Controllers
{
	//Summary:
	// Class này dùng để thực hiện UI trên giao diện người dùng
	public class UI
	{
		Connection db = new Connection();
		CustomTool custom = new CustomTool();
		Process p = new Process();
		public string MAHD;
		public Label BILLID;
		public Label NgayLap;
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		//Hàm hay dùng
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg")) ? fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg") : fullPath(@"../../Resources/Sp.jpg");
		public string getHoaDon() => db.ExcuteReader("SELECT TOP 1 TRANGTHAI FROM HOADON ORDER BY MAHD desc", "TRANGTHAI") == "Chưa xuất" ? db.ExcuteReader(UI.getBillID, "MAHD") : "";
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
				this.BILLID = _MAHD;
				this.NgayLap = NgayLap;
				custom.UI_Load("",
							   fullPath(@"../../Resources/iconHoaDon.png"),
							   flp, 
							   $"MAHD: {item["MAHD"].ToString()} { Environment.NewLine + DateTime.Parse(item["NGAYLAP"].ToString()).ToString("dd/MM/yyyy HH:mm:ss")}", 
							   140,
							   (sender, e) => Event_Bill_Process_Click(sender, e, item["MAHD"].ToString(), item["NGAYLAP"].ToString(), flowLayout));
			}
		}
		public void load_Product_Detail(TabControl tabControl1)
		{
			tabControl1.Controls.Clear();
			foreach (DataRow item in db.loadDB("SELECT * FROM LOAISP").Rows)
			{
				TabPage tabPage = new TabPage(item["TENLOAI"].ToString());
				FlowLayoutPanel flp = new FlowLayoutPanel();
				flp.Dock = DockStyle.Fill;
				foreach (DataRow pro in db.loadDB($"Select * from SANPHAM where MALOAI = {int.Parse(item["MALOAI"].ToString())}").Rows)
				{
					EventHandler e = (sender, ex) => { };
					custom.UI_Load(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"),
								   fpathImage(pro["MASP"].ToString()),
								   flp,
								   pro["TENSP"].ToString(),
								   145,
									e);
				}
				tabPage.Controls.Add(flp);
				tabControl1.Controls.Add(tabPage);
			}

		}
		//Xử lý sự kiện
		public void Event_Product_Click(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, TextBox ThanhTien)
		{
			try
			{
				Add_ProductToBill(MASP, ThanhTien);
				flp.Controls.Clear();
				UI_BillDetail(flp, this.BILLID.Text);
				//ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{db.ExcuteReader(UI.getBillID, "MAHD")}'", "Thành tiền");
				//ThanhTien.Text = string.IsNullOrEmpty(this.BILLID.Text) ? db.ExcuteReader($"EXEC Tong_ThanhTien '{db.ExcuteReader(UI.getBillID, "MAHD")}'", "Thành tiền") : 
				//	db.ExcuteReader($"EXEC Tong_ThanhTien '{this.BILLID.Text}'", "Thành tiền");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void Add_ProductToBill(string MASP, TextBox ThanhTien)
		{
			string MAHD = string.IsNullOrEmpty(this.BILLID.Text) ? p.getMAHD(db.ExcuteReader(UI.getBillID, "MAHD").Trim()) : this.BILLID.Text;
			try
			{
				if(MAHD != this.BILLID.Text)
				{
					string themHD = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', 'KH001', 'NV001')";
					db.ExcuteQuery(themHD);
					this.BILLID.Text = MAHD;
				}
				string is_Bill_Active = db.ExcuteReader($"SELECT * FROM HOADON WHERE MAHD = '{MAHD}'", "TRANGTHAI");
				if (is_Bill_Active == "Đã xuất hóa đơn" || is_Bill_Active == "Đã hủy")
				{
					MessageBox.Show("Không thể thêm sản phẩm khi đã xuất hóa đơn");
				}else
				{
					string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{MAHD}', '{MASP}', 1)";
					db.ExcuteQuery(Sql);					
					ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{MAHD}'", "Thành tiền");
				}

			} catch
			{
				db.close();
				int SL = int.Parse(db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'", "SOLUONG"));
				SL++;
				string Sql = $"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'";
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
			this.BILLID.Text = MAHD;
			this.NgayLap.Text = DateTime.Parse(NgayLap).ToString("dd/MM/yyyy HH:mm:ss");
			UI_BillDetail(flow, MAHD);
		}
		
	}
}
