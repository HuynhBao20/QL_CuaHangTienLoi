
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Trang chủ");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý bán hàng");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý hàng hóa");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý kho");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh mục bán hàng", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnl_Load_Main = new System.Windows.Forms.Panel();
			this.tv_DanhMuc = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.04179F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.95821F));
			this.tableLayoutPanel1.Controls.Add(this.pnl_Load_Main, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tv_DanhMuc, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.087629F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.91237F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1544, 778);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pnl_Load_Main
			// 
			this.pnl_Load_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Load_Main.Location = new System.Drawing.Point(251, 59);
			this.pnl_Load_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnl_Load_Main.Name = "pnl_Load_Main";
			this.pnl_Load_Main.Size = new System.Drawing.Size(1289, 715);
			this.pnl_Load_Main.TabIndex = 0;
			// 
			// tv_DanhMuc
			// 
			this.tv_DanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_DanhMuc.Location = new System.Drawing.Point(4, 59);
			this.tv_DanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tv_DanhMuc.Name = "tv_DanhMuc";
			treeNode1.Name = "Node5";
			treeNode1.Text = "Trang chủ";
			treeNode2.Name = "Node1";
			treeNode2.Text = "Quản lý bán hàng";
			treeNode3.Name = "Node3";
			treeNode3.Text = "Quản lý hàng hóa";
			treeNode4.Name = "Node4";
			treeNode4.Text = "Quản lý kho";
			treeNode5.Name = "Node0";
			treeNode5.Text = "Danh mục bán hàng";
			this.tv_DanhMuc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
			this.tv_DanhMuc.Size = new System.Drawing.Size(239, 715);
			this.tv_DanhMuc.TabIndex = 1;
			this.tv_DanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_DanhMuc_NodeMouseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1544, 778);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel pnl_Load_Main;
		private System.Windows.Forms.TreeView tv_DanhMuc;
	}
}