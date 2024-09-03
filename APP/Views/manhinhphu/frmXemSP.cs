using ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Views.manhinhphu
{
	public partial class frmXemSP : Form
	{
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg")) ? fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg") : fullPath(@"../../Resources/Sp.jpg");

		Connection db = new Connection();
		public frmXemSP(string MASP)
		{
			InitializeComponent();
			lb_dongia.Text = db.ExcuteReader($"SELECT DONGIA FROM SANPHAM WHERE MASP = '{MASP}'", "DONGIA");
			lb_MASP.Text = MASP;
			lb_TenSP.Text = db.ExcuteReader($"SELECT TENSP FROM SANPHAM WHERE MASP = '{MASP}'", "TENSP");
			lb_loai.Text = db.ExcuteReader($"SELECT TENLOAI FROM SANPHAM sp, LOAISP l WHERE sp.MALOAI = l.MALOAI AND MASP = '{MASP}'", "TENLOAI");
			ptb.Image = Image.FromFile(fpathImage(MASP));
			ptb.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
