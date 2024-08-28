
namespace APP.Views
{
	partial class frmQuanLySanPham
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMASP = new System.Windows.Forms.TextBox();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.ms_NgaySX = new System.Windows.Forms.MaskedTextBox();
			this.ms_HanSD = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cboMaLoai = new System.Windows.Forms.ComboBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.ptbProduct = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_ImportExcel = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnNH = new System.Windows.Forms.Button();
			this.flpPhieuNhap = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7249F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2751F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.55263F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.44737F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1454, 787);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(4, 4);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
			this.groupBox1.Size = new System.Drawing.Size(715, 779);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách sản phẩm";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 24);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.558011F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.44199F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(707, 751);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.tabControl1, 2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 37);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(701, 711);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(693, 678);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(726, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(725, 297);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Quản lý";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.22807F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.77193F));
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.txtMASP, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtTenSP, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.ms_NgaySX, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.ms_HanSD, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.label3, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.label4, 2, 3);
			this.tableLayoutPanel3.Controls.Add(this.cboMaLoai, 3, 2);
			this.tableLayoutPanel3.Controls.Add(this.txtDonGia, 3, 3);
			this.tableLayoutPanel3.Controls.Add(this.ptbProduct, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 4);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(719, 271);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(10, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sản phẩm";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(10, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 33);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên sản phẩm";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(374, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 34);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ngày sản xuất";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(374, 34);
			this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 33);
			this.label6.TabIndex = 1;
			this.label6.Text = "Hạn sử dụng";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMASP
			// 
			this.txtMASP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMASP.Location = new System.Drawing.Point(175, 3);
			this.txtMASP.Multiline = true;
			this.txtMASP.Name = "txtMASP";
			this.txtMASP.Size = new System.Drawing.Size(186, 28);
			this.txtMASP.TabIndex = 2;
			// 
			// txtTenSP
			// 
			this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTenSP.Location = new System.Drawing.Point(175, 37);
			this.txtTenSP.Multiline = true;
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(186, 27);
			this.txtTenSP.TabIndex = 2;
			// 
			// ms_NgaySX
			// 
			this.ms_NgaySX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ms_NgaySX.Location = new System.Drawing.Point(513, 3);
			this.ms_NgaySX.Mask = "00/00/0000";
			this.ms_NgaySX.Name = "ms_NgaySX";
			this.ms_NgaySX.Size = new System.Drawing.Size(203, 27);
			this.ms_NgaySX.TabIndex = 3;
			this.ms_NgaySX.ValidatingType = typeof(System.DateTime);
			// 
			// ms_HanSD
			// 
			this.ms_HanSD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ms_HanSD.Location = new System.Drawing.Point(513, 37);
			this.ms_HanSD.Mask = "00/00/0000";
			this.ms_HanSD.Name = "ms_HanSD";
			this.ms_HanSD.Size = new System.Drawing.Size(203, 27);
			this.ms_HanSD.TabIndex = 3;
			this.ms_HanSD.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(374, 67);
			this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 34);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã loại";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(374, 101);
			this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboMaLoai
			// 
			this.cboMaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaLoai.FormattingEnabled = true;
			this.cboMaLoai.Location = new System.Drawing.Point(513, 70);
			this.cboMaLoai.Name = "cboMaLoai";
			this.cboMaLoai.Size = new System.Drawing.Size(203, 28);
			this.cboMaLoai.TabIndex = 4;
			// 
			// txtDonGia
			// 
			this.txtDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDonGia.Location = new System.Drawing.Point(513, 104);
			this.txtDonGia.Multiline = true;
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(203, 27);
			this.txtDonGia.TabIndex = 2;
			// 
			// ptbProduct
			// 
			this.ptbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptbProduct.Image = global::APP.Properties.Resources.icona;
			this.ptbProduct.Location = new System.Drawing.Point(175, 70);
			this.ptbProduct.Name = "ptbProduct";
			this.tableLayoutPanel3.SetRowSpan(this.ptbProduct, 3);
			this.ptbProduct.Size = new System.Drawing.Size(186, 198);
			this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbProduct.TabIndex = 5;
			this.ptbProduct.TabStop = false;
			this.ptbProduct.Click += new System.EventHandler(this.ptbProduct_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(10, 101);
			this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 33);
			this.label7.TabIndex = 0;
			this.label7.Text = "Hình ảnh";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.btn_ImportExcel, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.btnThem, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnSua, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnXoa, 2, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(367, 137);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(349, 131);
			this.tableLayoutPanel4.TabIndex = 6;
			// 
			// btn_ImportExcel
			// 
			this.btn_ImportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_ImportExcel.Location = new System.Drawing.Point(3, 68);
			this.btn_ImportExcel.Name = "btn_ImportExcel";
			this.btn_ImportExcel.Size = new System.Drawing.Size(110, 60);
			this.btn_ImportExcel.TabIndex = 0;
			this.btn_ImportExcel.Text = "Import";
			this.btn_ImportExcel.UseVisualStyleBackColor = true;
			this.btn_ImportExcel.Click += new System.EventHandler(this.btn_ImportExcel_Click);
			// 
			// btnThem
			// 
			this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnThem.Location = new System.Drawing.Point(3, 3);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(110, 59);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSua.Location = new System.Drawing.Point(119, 3);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(110, 59);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnXoa.Location = new System.Drawing.Point(235, 3);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(111, 59);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel5);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(726, 306);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(725, 478);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Phiếu nhập";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 494F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			this.tableLayoutPanel5.Controls.Add(this.btnNH, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.flpPhieuNhap, 0, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(719, 452);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// btnNH
			// 
			this.btnNH.BackColor = System.Drawing.Color.Green;
			this.btnNH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNH.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnNH.Location = new System.Drawing.Point(607, 3);
			this.btnNH.Name = "btnNH";
			this.btnNH.Size = new System.Drawing.Size(109, 40);
			this.btnNH.TabIndex = 0;
			this.btnNH.Text = "Nhập hàng";
			this.btnNH.UseVisualStyleBackColor = false;
			this.btnNH.Click += new System.EventHandler(this.btnNH_Click);
			// 
			// flpPhieuNhap
			// 
			this.flpPhieuNhap.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tableLayoutPanel5.SetColumnSpan(this.flpPhieuNhap, 3);
			this.flpPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpPhieuNhap.Location = new System.Drawing.Point(3, 49);
			this.flpPhieuNhap.Name = "flpPhieuNhap";
			this.flpPhieuNhap.Size = new System.Drawing.Size(713, 400);
			this.flpPhieuNhap.TabIndex = 1;
			// 
			// frmQuanLySanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1454, 787);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmQuanLySanPham";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuanLySanPham";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_ImportExcel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMASP;
		private System.Windows.Forms.TextBox txtTenSP;
		private System.Windows.Forms.MaskedTextBox ms_NgaySX;
		private System.Windows.Forms.MaskedTextBox ms_HanSD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboMaLoai;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.PictureBox ptbProduct;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button btnNH;
		private System.Windows.Forms.FlowLayoutPanel flpPhieuNhap;
	}
}