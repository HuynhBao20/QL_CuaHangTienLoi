using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Views.LoadControl
{
	public partial class load_Infor_Product : UserControl
	{
		public load_Infor_Product(string MASP)
		{
			InitializeComponent();
			label4.Text = MASP;
		}
		public load_Infor_Product()
		{
			InitializeComponent();
		}
	}
}
