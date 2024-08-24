
namespace APP.Views.manhinhphu
{
	partial class frmResetPass
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
			this.txtOldPass = new System.Windows.Forms.TextBox();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.txtConfirmPass = new System.Windows.Forms.TextBox();
			this.btnResetPass = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtOldPass
			// 
			this.txtOldPass.Location = new System.Drawing.Point(216, 55);
			this.txtOldPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtOldPass.Multiline = true;
			this.txtOldPass.Name = "txtOldPass";
			this.txtOldPass.Size = new System.Drawing.Size(278, 32);
			this.txtOldPass.TabIndex = 0;
			// 
			// txtNewPass
			// 
			this.txtNewPass.Location = new System.Drawing.Point(216, 118);
			this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewPass.Multiline = true;
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.Size = new System.Drawing.Size(278, 32);
			this.txtNewPass.TabIndex = 1;
			// 
			// txtConfirmPass
			// 
			this.txtConfirmPass.Location = new System.Drawing.Point(216, 180);
			this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtConfirmPass.Multiline = true;
			this.txtConfirmPass.Name = "txtConfirmPass";
			this.txtConfirmPass.Size = new System.Drawing.Size(278, 32);
			this.txtConfirmPass.TabIndex = 2;
			// 
			// btnResetPass
			// 
			this.btnResetPass.BackColor = System.Drawing.Color.LightGreen;
			this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResetPass.ForeColor = System.Drawing.Color.White;
			this.btnResetPass.Location = new System.Drawing.Point(292, 236);
			this.btnResetPass.Name = "btnResetPass";
			this.btnResetPass.Size = new System.Drawing.Size(202, 45);
			this.btnResetPass.TabIndex = 3;
			this.btnResetPass.Text = "Đổi mật khẩu";
			this.btnResetPass.UseVisualStyleBackColor = false;
			this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mật khẩu cũ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu mới";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nhập lại mật khẩu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(514, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "(*)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(514, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "(*)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(514, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "(*)";
			// 
			// frmResetPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 317);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnResetPass);
			this.Controls.Add(this.txtConfirmPass);
			this.Controls.Add(this.txtNewPass);
			this.Controls.Add(this.txtOldPass);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmResetPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ĐỔI MẬT KHẨU";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOldPass;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.TextBox txtConfirmPass;
		private System.Windows.Forms.Button btnResetPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}