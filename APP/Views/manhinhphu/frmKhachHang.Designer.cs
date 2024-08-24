
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
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboLoaiKH = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 762);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
			this.groupBox1.Controls.Add(this.dgvKhachHang);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 294);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1178, 465);
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
			this.dgvKhachHang.Size = new System.Drawing.Size(1172, 439);
			this.dgvKhachHang.TabIndex = 1;
			this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
			// 
			// groupBox2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1178, 285);
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
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtMaKH, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtHoTen, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtSDT, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtDiaChi, 3, 1);
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
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1172, 259);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khách hàng";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMaKH.Location = new System.Drawing.Point(221, 3);
			this.txtMaKH.Multiline = true;
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.ReadOnly = true;
			this.txtMaKH.Size = new System.Drawing.Size(313, 30);
			this.txtMaKH.TabIndex = 2;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtHoTen.Location = new System.Drawing.Point(221, 39);
			this.txtHoTen.Multiline = true;
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(313, 30);
			this.txtHoTen.TabIndex = 3;
			// 
			// txtSDT
			// 
			this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSDT.Location = new System.Drawing.Point(753, 3);
			this.txtSDT.Multiline = true;
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(254, 30);
			this.txtSDT.TabIndex = 4;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDiaChi.Location = new System.Drawing.Point(753, 39);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(254, 30);
			this.txtDiaChi.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(540, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 36);
			this.label3.TabIndex = 5;
			this.label3.Text = "SDT";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(540, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(207, 36);
			this.label4.TabIndex = 5;
			this.label4.Text = "Địa chỉ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(212, 34);
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
			this.cboLoaiKH.Location = new System.Drawing.Point(221, 75);
			this.cboLoaiKH.Name = "cboLoaiKH";
			this.cboLoaiKH.Size = new System.Drawing.Size(313, 28);
			this.cboLoaiKH.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.groupBox3, 2);
			this.groupBox3.Controls.Add(this.tableLayoutPanel3);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 109);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(531, 147);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Bộ lọc";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.68132F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.31868F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(525, 121);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.groupBox4, 3);
			this.groupBox4.Controls.Add(this.tableLayoutPanel4);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(540, 109);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(629, 147);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chức năng";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 5;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel4.Controls.Add(this.btnThem, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnSua, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnXoa, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnLuu, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.btn, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnClear, 1, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(623, 121);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// btnThem
			// 
			this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnThem.Location = new System.Drawing.Point(3, 3);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(142, 53);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSua.Location = new System.Drawing.Point(151, 3);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(142, 53);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnXoa.Location = new System.Drawing.Point(299, 3);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(142, 53);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLuu.Location = new System.Drawing.Point(3, 62);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(142, 56);
			this.btnLuu.TabIndex = 1;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btn
			// 
			this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn.Location = new System.Drawing.Point(447, 3);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(142, 53);
			this.btn.TabIndex = 1;
			this.btn.Text = "Thống kê";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new System.Drawing.Point(151, 62);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(142, 56);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Làm mới";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(244, 32);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(253, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Tìm";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 762);
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
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
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
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboLoaiKH;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}