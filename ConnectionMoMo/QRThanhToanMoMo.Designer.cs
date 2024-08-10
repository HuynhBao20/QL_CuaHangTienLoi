
namespace ConnectionMoMo
{
	partial class QRThanhToanMoMo
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnXuatHoaDon = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(21, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 431);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXacNhan.Location = new System.Drawing.Point(469, 12);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(278, 50);
			this.btnXacNhan.TabIndex = 1;
			this.btnXacNhan.Text = "Xác nhận thanh toán";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// btnXuatHoaDon
			// 
			this.btnXuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXuatHoaDon.Location = new System.Drawing.Point(469, 83);
			this.btnXuatHoaDon.Name = "btnXuatHoaDon";
			this.btnXuatHoaDon.Size = new System.Drawing.Size(278, 50);
			this.btnXuatHoaDon.TabIndex = 1;
			this.btnXuatHoaDon.Text = "Xuất hóa đơn";
			this.btnXuatHoaDon.UseVisualStyleBackColor = true;
			this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
			// 
			// QRThanhToanMoMo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 485);
			this.Controls.Add(this.btnXuatHoaDon);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.pictureBox1);
			this.Name = "QRThanhToanMoMo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Thanh Toán";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Button btnXuatHoaDon;
	}
}

