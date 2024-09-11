using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class process
	{
        Connection db = new Connection();
        public static string get_NewBillID = "SELECT TOP 1 TRANGTHAI FROM HOADON ORDER BY MAHD desc";
        public string create_Pass(string MANV)
		{
            string birthDay = DateTime.Parse(db.ExcuteReader($"SELECT NGAYSINH FROM NHANVIEN WHERE MANV = '{MANV}'", "NGAYSINH")).ToString("dd/MM/yyyy");
            string[] sql = birthDay.Split('/');
            string NewPass = "";
            for(int i = 0; i < sql.Length; i++)
			{
                if(i < sql.Length - 1) NewPass += sql[i];
                else
				{
                    NewPass += sql[i].Substring(2, 2);
				}
			}
            return NewPass;
		}
        public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
        public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg")) ? fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg") : fullPath(@"../../Resources/Sp.jpg");
        public string getHoaDon() => db.ExcuteReader(process.get_NewBillID, "TRANGTHAI") == "Chưa xuất" ? db.ExcuteReader(process.get_NewBillID, "MAHD") : "";
        public void loadCombobox(ComboBox combo, string Sql, string display, string Value)
        {
            combo.DataSource = db.loadDB(Sql);
            combo.DisplayMember = display;
            combo.ValueMember = Value;
        }
        public void loadTreeView(TreeView tv)
        {
            tv.Nodes.Clear();
            DataTable da = db.loadDB(Connection.Query_List_LoaiSP);
            foreach (DataRow item in da.Rows)
            {
                tv.Nodes.Add(item["TENLOAI"].ToString());
            }
        }
        public void load_Interface(Form a, Panel flp)
        {
            flp.Controls.Clear();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            flp.Controls.Add(a);
            a.Show();
        }

    }
}
