
namespace APP.Views
{
	partial class frmKhachHang
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboLoaiKH = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.1086F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 815F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.23529F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.76471F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 715);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
			this.groupBox1.Controls.Add(this.dgvKhachHang);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 276);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1176, 436);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh khách khách hàng";
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.ColumnHeadersHeight = 29;
			this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKhachHang.Location = new System.Drawing.Point(3, 23);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.RowHeadersWidth = 51;
			this.dgvKhachHang.RowTemplate.Height = 24;
			this.dgvKhachHang.Size = new System.Drawing.Size(1170, 410);
			this.dgvKhachHang.TabIndex = 1;
			this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1176, 267);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin khách hàng";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox3, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox4, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.cboLoaiKH, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.groupBox4, 2, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1170, 241);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khách hàng";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(221, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(313, 31);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(221, 40);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(313, 27);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(753, 3);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(259, 31);
			this.textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Location = new System.Drawing.Point(753, 40);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(259, 27);
			this.textBox4.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(540, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 37);
			this.label3.TabIndex = 5;
			this.label3.Text = "SDT";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(540, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(207, 33);
			this.label4.TabIndex = 5;
			this.label4.Text = "Địa chỉ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(212, 35);
			this.label5.TabIndex = 6;
			this.label5.Text = "Loại khách hàng";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboLoaiKH
			// 
			this.cboLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLoaiKH.FormattingEnabled = true;
			this.cboLoaiKH.Items.AddRange(new object[] {
            "Khách vãng lai",
            "Khách tích điểm"});
			this.cboLoaiKH.Location = new System.Drawing.Point(221, 73);
			this.cboLoaiKH.Name = "cboLoaiKH";
			this.cboLoaiKH.Size = new System.Drawing.Size(313, 28);
			this.cboLoaiKH.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.groupBox3, 2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 108);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(531, 130);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tìm kiếm";
			// 
			// groupBox4
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.groupBox4, 3);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(540, 108);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(627, 130);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chức năng";
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 715);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmKhachHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "THÔNG TIN KHÁCH HÀNG";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView dgvKhachHang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboLoaiKH;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}