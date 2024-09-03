
namespace APP
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnl_Load_Main = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._UserName = new System.Windows.Forms.ToolStripDropDownButton();
			this.resetPass = new System.Windows.Forms.ToolStripMenuItem();
			this._Logout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnHangHoa = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnBill = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnDoanhThu = new System.Windows.Forms.Button();
			this.btnNhanSu = new System.Windows.Forms.Button();
			this.btnKhachHang = new System.Windows.Forms.Button();
			this.btnBanHang = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tt_Kho = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2487F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.7513F));
			this.tableLayoutPanel1.Controls.Add(this.pnl_Load_Main, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1544, 778);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pnl_Load_Main
			// 
			this.pnl_Load_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Load_Main.Location = new System.Drawing.Point(223, 47);
			this.pnl_Load_Main.Margin = new System.Windows.Forms.Padding(4);
			this.pnl_Load_Main.Name = "pnl_Load_Main";
			this.pnl_Load_Main.Size = new System.Drawing.Size(1317, 727);
			this.pnl_Load_Main.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._UserName,
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(219, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1325, 43);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// _UserName
			// 
			this._UserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this._UserName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPass,
            this._Logout});
			this._UserName.Image = global::APP.Properties.Resources.images;
			this._UserName.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._UserName.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
			this._UserName.Name = "_UserName";
			this._UserName.Size = new System.Drawing.Size(141, 40);
			this._UserName.Text = "Tên đăng nhập";
			// 
			// resetPass
			// 
			this.resetPass.Name = "resetPass";
			this.resetPass.Size = new System.Drawing.Size(224, 26);
			this.resetPass.Text = "Đổi mật khẩu";
			this.resetPass.Click += new System.EventHandler(this.resetPass_Click);
			// 
			// _Logout
			// 
			this._Logout.Name = "_Logout";
			this._Logout.Size = new System.Drawing.Size(224, 26);
			this._Logout.Text = "Đăng xuất";
			this._Logout.Click += new System.EventHandler(this._Logout_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(56, 40);
			this.toolStripButton1.Text = "File";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHangHoa,
            this.tt_Kho});
			this.toolStripButton2.Image = global::APP.Properties.Resources.Asset_3_1;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(116, 40);
			this.toolStripButton2.Text = "Nhập hàng";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// btnHangHoa
			// 
			this.btnHangHoa.Name = "btnHangHoa";
			this.btnHangHoa.Size = new System.Drawing.Size(224, 26);
			this.btnHangHoa.Text = "Quản lý nhập hàng";
			this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btnBill);
			this.panel1.Controls.Add(this.btnDoanhThu);
			this.panel1.Controls.Add(this.btnNhanSu);
			this.panel1.Controls.Add(this.btnKhachHang);
			this.panel1.Controls.Add(this.btnBanHang);
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
			this.panel1.Size = new System.Drawing.Size(213, 772);
			this.panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 590);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 182);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cài đặt";
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button2.Location = new System.Drawing.Point(3, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(207, 39);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cài đặt";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(3, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(207, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Thông tin cá nhân";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnBill
			// 
			this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnBill.FlatAppearance.BorderSize = 0;
			this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBill.ImageKey = "iconBill.png";
			this.btnBill.ImageList = this.imageList1;
			this.btnBill.Location = new System.Drawing.Point(0, 333);
			this.btnBill.Name = "btnBill";
			this.btnBill.Size = new System.Drawing.Size(213, 60);
			this.btnBill.TabIndex = 6;
			this.btnBill.Text = "Quản lý hóa đơn";
			this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBill.UseVisualStyleBackColor = true;
			this.btnBill.Click += new System.EventHandler(this.button6_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon-thiet-ke-linh-vuc-logo-hang-tieu-dung-baa-brand-1.png");
			this.imageList1.Images.SetKeyName(1, "icon-10.png");
			this.imageList1.Images.SetKeyName(2, "iconBill.png");
			this.imageList1.Images.SetKeyName(3, "30.1.2021-06.png");
			this.imageList1.Images.SetKeyName(4, "iconDoanhThu.png");
			this.imageList1.Images.SetKeyName(5, "quan-ly-ton-kho-la-gi.png");
			this.imageList1.Images.SetKeyName(6, "Asset-3-1.png");
			// 
			// btnDoanhThu
			// 
			this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDoanhThu.FlatAppearance.BorderSize = 0;
			this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoanhThu.ImageKey = "iconDoanhThu.png";
			this.btnDoanhThu.ImageList = this.imageList1;
			this.btnDoanhThu.Location = new System.Drawing.Point(0, 273);
			this.btnDoanhThu.Name = "btnDoanhThu";
			this.btnDoanhThu.Size = new System.Drawing.Size(213, 60);
			this.btnDoanhThu.TabIndex = 5;
			this.btnDoanhThu.Text = "Quản lý doanh thu";
			this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDoanhThu.UseVisualStyleBackColor = true;
			this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
			// 
			// btnNhanSu
			// 
			this.btnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNhanSu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnNhanSu.FlatAppearance.BorderSize = 0;
			this.btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhanSu.ImageKey = "icon-10.png";
			this.btnNhanSu.ImageList = this.imageList1;
			this.btnNhanSu.Location = new System.Drawing.Point(0, 213);
			this.btnNhanSu.Name = "btnNhanSu";
			this.btnNhanSu.Size = new System.Drawing.Size(213, 60);
			this.btnNhanSu.TabIndex = 4;
			this.btnNhanSu.Text = "Quản lý nhân sự";
			this.btnNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNhanSu.UseVisualStyleBackColor = true;
			this.btnNhanSu.Click += new System.EventHandler(this.btnNhanSu_Click);
			// 
			// btnKhachHang
			// 
			this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnKhachHang.FlatAppearance.BorderSize = 0;
			this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHang.ImageList = this.imageList1;
			this.btnKhachHang.Location = new System.Drawing.Point(0, 153);
			this.btnKhachHang.Name = "btnKhachHang";
			this.btnKhachHang.Size = new System.Drawing.Size(213, 60);
			this.btnKhachHang.TabIndex = 3;
			this.btnKhachHang.Text = "Quản lý khách hàng";
			this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKhachHang.UseVisualStyleBackColor = true;
			this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
			// 
			// btnBanHang
			// 
			this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBanHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnBanHang.FlatAppearance.BorderSize = 0;
			this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBanHang.ImageKey = "30.1.2021-06.png";
			this.btnBanHang.ImageList = this.imageList1;
			this.btnBanHang.Location = new System.Drawing.Point(0, 93);
			this.btnBanHang.Name = "btnBanHang";
			this.btnBanHang.Size = new System.Drawing.Size(213, 60);
			this.btnBanHang.TabIndex = 2;
			this.btnBanHang.Text = "Quản lý bán hàng";
			this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBanHang.UseVisualStyleBackColor = true;
			this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Location = new System.Drawing.Point(0, 40);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(213, 53);
			this.btnHome.TabIndex = 1;
			this.btnHome.Text = "Trang chủ";
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(213, 40);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tt_Kho
			// 
			this.tt_Kho.Name = "tt_Kho";
			this.tt_Kho.Size = new System.Drawing.Size(224, 26);
			this.tt_Kho.Text = "Quản lý kho";
			this.tt_Kho.Click += new System.EventHandler(this.tt_Kho_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(1544, 778);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG TIỆN LỢI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel pnl_Load_Main;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton _UserName;
		private System.Windows.Forms.ToolStripMenuItem resetPass;
		private System.Windows.Forms.ToolStripMenuItem _Logout;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Button btnBill;
		private System.Windows.Forms.Button btnDoanhThu;
		private System.Windows.Forms.Button btnNhanSu;
		private System.Windows.Forms.Button btnKhachHang;
		private System.Windows.Forms.Button btnBanHang;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
		private System.Windows.Forms.ToolStripMenuItem btnHangHoa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem tt_Kho;
	}
}