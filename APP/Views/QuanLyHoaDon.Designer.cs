
namespace APP.Views
{
	partial class QuanLyHoaDon
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
			this.flp_LoadHoaDon = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dt_NgayChon = new System.Windows.Forms.DateTimePicker();
			this.rd_HomNay = new System.Windows.Forms.RadioButton();
			this.rd_ChonNgay = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.19422F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.80578F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1349, 754);
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
			this.groupBox1.Size = new System.Drawing.Size(831, 746);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh mục hóa đơn";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.06197F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93803F));
			this.tableLayoutPanel2.Controls.Add(this.flp_LoadHoaDon, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 24);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.571031F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.42897F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(823, 718);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// flp_LoadHoaDon
			// 
			this.flp_LoadHoaDon.AutoScroll = true;
			this.tableLayoutPanel2.SetColumnSpan(this.flp_LoadHoaDon, 2);
			this.flp_LoadHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flp_LoadHoaDon.Location = new System.Drawing.Point(3, 43);
			this.flp_LoadHoaDon.Name = "flp_LoadHoaDon";
			this.flp_LoadHoaDon.Size = new System.Drawing.Size(817, 672);
			this.flp_LoadHoaDon.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
			this.tableLayoutPanel3.Controls.Add(this.dt_NgayChon, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.rd_HomNay, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.rd_ChonNgay, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(513, 34);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// dt_NgayChon
			// 
			this.dt_NgayChon.CustomFormat = "dd/MM/yyyy";
			this.dt_NgayChon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dt_NgayChon.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dt_NgayChon.Enabled = false;
			this.dt_NgayChon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_NgayChon.Location = new System.Drawing.Point(351, 3);
			this.dt_NgayChon.Name = "dt_NgayChon";
			this.dt_NgayChon.Size = new System.Drawing.Size(159, 27);
			this.dt_NgayChon.TabIndex = 1;
			this.dt_NgayChon.ValueChanged += new System.EventHandler(this.dt_NgayChon_ValueChanged);
			// 
			// rd_HomNay
			// 
			this.rd_HomNay.AutoSize = true;
			this.rd_HomNay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rd_HomNay.Location = new System.Drawing.Point(3, 3);
			this.rd_HomNay.Name = "rd_HomNay";
			this.rd_HomNay.Size = new System.Drawing.Size(168, 28);
			this.rd_HomNay.TabIndex = 0;
			this.rd_HomNay.TabStop = true;
			this.rd_HomNay.Text = "Hôm nay";
			this.rd_HomNay.UseVisualStyleBackColor = true;
			this.rd_HomNay.CheckedChanged += new System.EventHandler(this.rd_HomNay_CheckedChanged);
			// 
			// rd_ChonNgay
			// 
			this.rd_ChonNgay.AutoSize = true;
			this.rd_ChonNgay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rd_ChonNgay.Location = new System.Drawing.Point(177, 3);
			this.rd_ChonNgay.Name = "rd_ChonNgay";
			this.rd_ChonNgay.Size = new System.Drawing.Size(168, 28);
			this.rd_ChonNgay.TabIndex = 0;
			this.rd_ChonNgay.TabStop = true;
			this.rd_ChonNgay.Text = "Chọn ngày";
			this.rd_ChonNgay.UseVisualStyleBackColor = true;
			this.rd_ChonNgay.CheckedChanged += new System.EventHandler(this.rd_ChonNgay_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(842, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(504, 371);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Doanh thu";
			// 
			// QuanLyHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1349, 754);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "QuanLyHoaDon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuanLyDoanhThu";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flp_LoadHoaDon;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RadioButton rd_HomNay;
		private System.Windows.Forms.RadioButton rd_ChonNgay;
		private System.Windows.Forms.DateTimePicker dt_NgayChon;
	}
}