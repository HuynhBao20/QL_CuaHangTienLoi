
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
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Trang chủ");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Quản lý bán hàng");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Quản lý hàng hóa");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Quản lý kho");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Danh mục bán hàng", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnl_Load_Main = new System.Windows.Forms.Panel();
			this.tv_DanhMuc = new System.Windows.Forms.TreeView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0829F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.9171F));
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
			this.pnl_Load_Main.Location = new System.Drawing.Point(205, 47);
			this.pnl_Load_Main.Margin = new System.Windows.Forms.Padding(4);
			this.pnl_Load_Main.Name = "pnl_Load_Main";
			this.pnl_Load_Main.Size = new System.Drawing.Size(1335, 727);
			this.pnl_Load_Main.TabIndex = 0;
			// 
			// tv_DanhMuc
			// 
			this.tv_DanhMuc.BackColor = System.Drawing.Color.White;
			this.tv_DanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_DanhMuc.Location = new System.Drawing.Point(4, 47);
			this.tv_DanhMuc.Margin = new System.Windows.Forms.Padding(4);
			this.tv_DanhMuc.Name = "tv_DanhMuc";
			treeNode11.Name = "Node5";
			treeNode11.Text = "Trang chủ";
			treeNode12.Name = "Node1";
			treeNode12.Text = "Quản lý bán hàng";
			treeNode13.Name = "Node3";
			treeNode13.Text = "Quản lý hàng hóa";
			treeNode14.Name = "Node4";
			treeNode14.Text = "Quản lý kho";
			treeNode15.Name = "Node0";
			treeNode15.Text = "Danh mục bán hàng";
			this.tv_DanhMuc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode15});
			this.tv_DanhMuc.Size = new System.Drawing.Size(193, 727);
			this.tv_DanhMuc.TabIndex = 1;
			this.tv_DanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_DanhMuc_NodeMouseClick);
			// 
			// toolStrip1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1544, 43);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
			this.toolStripButton1.Image = global::APP.Properties.Resources.images;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(141, 40);
			this.toolStripButton1.Text = "Tên đăng nhập";
			// 
			// đổiMậtKhẩuToolStripMenuItem
			// 
			this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
			this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1544, 778);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
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
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
	}
}