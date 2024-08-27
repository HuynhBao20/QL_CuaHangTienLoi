
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Trang chủ");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý bán hàng");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý nhập hàng");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý kho");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh mục hàng hóa", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hóa đơn trong ngày");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quản lý hóa đơn", new System.Windows.Forms.TreeNode[] {
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quản lý khách hàng");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Quản lý nhân sự");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Quản lý doanh thu");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnl_Load_Main = new System.Windows.Forms.Panel();
			this.tv_DanhMuc = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._UserName = new System.Windows.Forms.ToolStripDropDownButton();
			this.resetPass = new System.Windows.Forms.ToolStripMenuItem();
			this._Logout = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.76684F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.23316F));
			this.tableLayoutPanel1.Controls.Add(this.pnl_Load_Main, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tv_DanhMuc, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
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
			this.pnl_Load_Main.Location = new System.Drawing.Point(232, 47);
			this.pnl_Load_Main.Margin = new System.Windows.Forms.Padding(4);
			this.pnl_Load_Main.Name = "pnl_Load_Main";
			this.pnl_Load_Main.Size = new System.Drawing.Size(1308, 727);
			this.pnl_Load_Main.TabIndex = 0;
			// 
			// tv_DanhMuc
			// 
			this.tv_DanhMuc.BackColor = System.Drawing.Color.White;
			this.tv_DanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_DanhMuc.ImageIndex = 0;
			this.tv_DanhMuc.ImageList = this.imageList1;
			this.tv_DanhMuc.Location = new System.Drawing.Point(4, 47);
			this.tv_DanhMuc.Margin = new System.Windows.Forms.Padding(4);
			this.tv_DanhMuc.Name = "tv_DanhMuc";
			treeNode1.Name = "Node5";
			treeNode1.Text = "Trang chủ";
			treeNode2.BackColor = System.Drawing.Color.Transparent;
			treeNode2.Name = "Node1";
			treeNode2.Text = "Quản lý bán hàng";
			treeNode3.Name = "Node4";
			treeNode3.Text = "Quản lý nhập hàng";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Quản lý kho";
			treeNode5.ImageIndex = -2;
			treeNode5.Name = "Node0";
			treeNode5.Text = "Danh mục hàng hóa";
			treeNode6.Name = "Node1";
			treeNode6.Text = "Hóa đơn trong ngày";
			treeNode7.Name = "Node0";
			treeNode7.Text = "Quản lý hóa đơn";
			treeNode8.Name = "Node0";
			treeNode8.Text = "Quản lý khách hàng";
			treeNode9.Name = "Node1";
			treeNode9.Text = "Quản lý nhân sự";
			treeNode10.Name = "Node2";
			treeNode10.Text = "Quản lý doanh thu";
			this.tv_DanhMuc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
			this.tv_DanhMuc.SelectedImageIndex = 0;
			this.tv_DanhMuc.Size = new System.Drawing.Size(220, 727);
			this.tv_DanhMuc.TabIndex = 1;
			this.tv_DanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_DanhMuc_NodeMouseClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon-thiet-ke-linh-vuc-logo-hang-tieu-dung-baa-brand-1.png");
			// 
			// toolStrip1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._UserName});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1544, 43);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1544, 778);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG TIỆN LỢI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel pnl_Load_Main;
		private System.Windows.Forms.TreeView tv_DanhMuc;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton _UserName;
		private System.Windows.Forms.ToolStripMenuItem resetPass;
		private System.Windows.Forms.ToolStripMenuItem _Logout;
		private System.Windows.Forms.ImageList imageList1;
	}
}