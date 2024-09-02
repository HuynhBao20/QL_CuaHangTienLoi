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
using APP.Views.manhinhphu;
using ConnectionDB;
using ConnectionDB.Logic;

namespace APP.Controllers
{
	//Summary:
	// Class này dùng để thực hiện UI trên giao diện người dùng
	public class UI
	{
		Connection db { get; set; }
		CustomTool custom = new CustomTool();
		public string MAHD;
		public Label BILLID;
		public Label NgayLap;
		public string UserName { get; set; }
		public string PassWord { get; set; }

		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		public UI() {
			db = new Connection();
		}
		public UI(Label BILLID)
		{
			this.BILLID = BILLID;
			db = new Connection();
		}
		public UI(string User, string Pass)
		{
			this.UserName = User;
			this.PassWord = Pass;
			db = new Connection(User, Pass);
		}
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
			tv.Nodes.Clear();
			DataTable da = db.loadDB(Connection.Query_List_LoaiSP);
			foreach (DataRow item in da.Rows)
			{
				tv.Nodes.Add(item["TENLOAI"].ToString());
			}
		}
		//Load 
		public void UI_LoadProduct(FlowLayoutPanel flp, FlowLayoutPanel billDetail, TextBox ThanhTien, string SDT)
		{
			DataTable da = db.loadDB("SELECT * FROM SANPHAM");
			flp.Controls.Clear();
			billDetail.Controls.Clear();
			if (da.Rows.Count > 0)
			{
				foreach (DataRow item in da.Rows)
				{
					custom.UI_Load(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"),
								   fpathImage(item["MASP"].ToString()), 
								   flp,
								   item["TENSP"].ToString(),
								   135,
								   (sender, e) => Event_Product_Click(sender, e, item["MASP"].ToString(), billDetail, ThanhTien, SDT));
				}
			} 
			else
			{
				MessageBox.Show("Không tìm thấy");
			}
		}
		public void UI_BillDetail(FlowLayoutPanel flp, string MAHD, TextBox ThanhTien)
		{
			flp.Controls.Clear();
			Tilte(flp);
			ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien {MAHD}", "Thành tiền");
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
							   ThanhTien,
							   (sender, e) => Event_Del_Product_BillDetail(sender, e, item["Mã sản phẩm"].ToString(), flp, MAHD, ThanhTien));
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
			   new TextBox(),
			   (sender, e) => handler(sender, e));
		}
		public void Ui_Filter_Product(FlowLayoutPanel flp, string SQL, FlowLayoutPanel billDetail, TextBox ThanhTien, string SDT)
		{
			DataTable da = db.loadDB(SQL);
			foreach (DataRow item in da.Rows)
			{
				custom.UI_Load(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"),
							   fpathImage(item["MASP"].ToString()),
							   flp,
							   item["TENSP"].ToString(),
							   135,
							   (sender, e) => Event_Product_Click(sender, e, item["MASP"].ToString(), billDetail, ThanhTien, SDT));

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
        public void load_HoaDon_ChuaXuat(FlowLayoutPanel flp, string SQL, Label NgayLap, FlowLayoutPanel flowLayout, TextBox ThanhTien)
        {
            flp.Controls.Clear(); // Xóa các hóa đơn trước đó trong danh sách
            DataTable da = db.loadDB(SQL);
            foreach (DataRow item in da.Rows)
            {
                // Tạo một custom UI cho mỗi hóa đơn
                // Khi click vào hóa đơn
                custom.UI_Load("",
                fullPath(@"../../Resources/iconHoaDon.png"),
                flp,
                $"MAHD: {item["MAHD"].ToString()} {Environment.NewLine + DateTime.Parse(item["NGAYLAP"].ToString()).ToString("dd/MM/yyyy HH:mm:ss")}",
                140,
                (sender, e) => Event_Bill_Process_Click(sender, e, item["MAHD"].ToString(), item["NGAYLAP"].ToString(), flowLayout, ThanhTien, NgayLap)); // Truyền lb_NgayLap từ lớp QuanLyHangHoa

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
		public void load_SanPham_PhieuNhap(FlowLayoutPanel flp)
		{
			DataTable da = db.loadDB("SELECT * FROM SANPHAM");
			flp.Controls.Clear();
			if (da.Rows.Count > 0)
			{
				foreach (DataRow item in da.Rows)
				{
					custom.UI_Load("",
								   fpathImage(item["MASP"].ToString()),
								   flp,
								   item["TENSP"].ToString(),
								   145,
								   (sender, e) => {});
				}
			}
			else
			{
				MessageBox.Show("Không có sản phẩm");
			}
		}
		public void load_PhieuNhap(FlowLayoutPanel flp)
		{
			flp.AutoScroll = true;
			DataTable da = db.loadDB("SELECT DISTINCT MAPN, NGAYNHAP FROM PHIEUNHAP");
			foreach(DataRow item in da.Rows)
			{
				Panel pnl = new Panel()
				{
					Width = 145,
					Height = 190,
					BackColor = Color.Transparent
				};
				Button btn = new Button()
				{
					Width = flp.Width - 10,
					Height = 200,
					BackColor = Color.Transparent,
					Dock = DockStyle.Fill,
					BackgroundImage = Image.FromFile(fullPath(@"../../Resources/IconKho.png")),
					BackgroundImageLayout = ImageLayout.Stretch,
					FlatStyle = FlatStyle.Flat
				};
				btn.FlatAppearance.BorderSize = 0;
				Panel pn = new Panel()
				{
					Width = pnl.Width,
					Height = 50,
					Dock = DockStyle.Bottom,
					BackColor = Color.White
				};
				Label ProductName = new Label()
				{
					Height = 50,
					Text = item["MAPN"].ToString() + Environment.NewLine + item["NGAYNHAP"].ToString(),
					Dock = DockStyle.Left,
					BackColor = Color.Transparent,
					TextAlign = ContentAlignment.MiddleCenter,
				
				};
				Button btnXem = new Button()
				{
					Text = "Xem",
					Width = 60,
					Height = 50,
					Dock = DockStyle.Right,
					BackColor = Color.Green,
					ForeColor = Color.White
				};
				//btn.Click += e;
				pnl.Controls.Add(btn);
				pn.Controls.Add(btnXem);
				pn.Controls.Add(ProductName);
				pnl.Controls.Add(pn);
				flp.Controls.Add(pnl);

			}
		}
		public void load_Interface(Form a, Panel flp)
		{
			flp.Controls.Clear();
			a.FormBorderStyle = FormBorderStyle.None;
			a.Dock = DockStyle.Fill;
			a.TopLevel = false;
			flp.Controls.Add(a);
			a.Show();

		}
		//Xử lý sự kiện
		public void Event_Product_Click(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, TextBox ThanhTien, string SDT)
			{
				try
				{
					ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien {MAHD}", "Thành tiền");
					Add_ProductToBill(MAHD, MASP,SDT ,ThanhTien);
					flp.Controls.Clear();
					UI_BillDetail(flp, this.BILLID.Text, ThanhTien);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		public void Add_ProductToBill(string MAHD, string MASP, string SDT, TextBox ThanhTien)
			{
				try
				{
					// Xác định mã hóa đơn (MAHD)
					MAHD = this.BILLID == null ? db.getMAHD(db.ExcuteReader(UI.getBillID, "MAHD").Trim(), "HD") : this.BILLID.Text;

					// Nếu mã hóa đơn chưa tồn tại trong BILLID, thực hiện thêm mới
					if (MAHD != this.BILLID.Text)
					{
						// Nếu số điện thoại (SDT) không được cung cấp, gán giá trị mặc định
						SDT = SDT == "" ? "VL000" : db.ExcuteReader($"SELECT MAKH FROM KHACHHANG WHERE SDT = '{SDT}'", "SDT");

						// Tạo câu lệnh SQL để thêm hóa đơn vào bảng HOADON
						string themHD = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', '{SDT}', '{UserName}')";
						db.ExcuteQuery(themHD);

						// Cập nhật mã hóa đơn vào control BILLID
						this.BILLID.Text = MAHD;
					}

					// Kiểm tra trạng thái của hóa đơn
					string is_Bill_Active = db.ExcuteReader($"SELECT * FROM HOADON WHERE MAHD = '{MAHD}'", "TRANGTHAI");
					if (is_Bill_Active == "Đã xuất hóa đơn" || is_Bill_Active == "Đã hủy")
					{
						// Hiển thị thông báo nếu hóa đơn đã xuất hoặc đã bị hủy
						MessageBox.Show("Không thể thêm sản phẩm khi đã xuất hóa đơn");
					}
					else
					{
						// Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
						string kt = $"SELECT COUNT(*) AS 'SL' FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'";
						int is_Exist = int.Parse(db.ExcuteReader(kt, "SL"));

						// Xác định số lượng sản phẩm hiện có trong hóa đơn
						int SL = is_Exist > 0 ?
							int.Parse(db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'", "SOLUONG")) :
							0;

						// Tăng số lượng sản phẩm lên 1
						SL++;

						// Tạo câu lệnh SQL để thêm hoặc cập nhật sản phẩm trong hóa đơn
						string Sql = is_Exist < 1 ?
							$"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{MAHD}', '{MASP}', 1)" :
							$"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'";

						// Thực thi câu lệnh SQL
						db.ExcuteQuery(Sql);

						// Cập nhật thành tiền vào control ThanhTien
						ThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{MAHD}'", "Thành tiền");
					}
				}
				catch (Exception e)
				{
					// Hiển thị thông báo lỗi nếu có ngoại lệ xảy ra
					MessageBox.Show(e.Message);
				}
			}
        public void Event_Del_Product_BillDetail(object sender, EventArgs e, string MASP, FlowLayoutPanel flp, string MAHD, TextBox ThanhTien)
		{
			try
			{
				string Sql = $"DELETE FROM CT_HOADON WHERE MASP = '{MASP}' AND MAHD = '{MAHD}'";
				db.ExcuteQuery(Sql);
				flp.Controls.Clear();
				UI_BillDetail(flp, MAHD, ThanhTien);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		public void Event_Show_Bill(object sender, EventArgs e, string MAHD)
		{
			frmChiTietHoaDon ct = new frmChiTietHoaDon(MAHD);
			ct.Show();
		}
        public void Event_Bill_Process_Click(object sender, EventArgs e, string MAHD, string NgayLap, FlowLayoutPanel flow, TextBox ThanhTien, Label lb_NgayLap)
        {
            try
            {
                flow.Controls.Clear(); // Xóa các thông tin chi tiết hóa đơn trước đó
                this.BILLID.Text = MAHD; // Gán mã hóa đơn vào Label

                // Gán giá trị cho lb_NgayLap
                lb_NgayLap.Text = DateTime.Parse(NgayLap).ToString("dd/MM/yyyy HH:mm:ss");

                // Gán giá trị cho this.MAHD để lưu mã hóa đơn
                this.MAHD = MAHD; // Đây là bước quan trọng để lưu mã hóa đơn

                // Hiển thị thông tin chi tiết của hóa đơn
                UI_BillDetail(flow, MAHD, ThanhTien);

                // Thêm kiểm tra mã hóa đơn (MAHD) sau khi được gán
                MessageBox.Show($"Mã hóa đơn hiện tại: {this.MAHD}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xử lý hóa đơn: {ex.Message}");
            }
        }

    }
}
