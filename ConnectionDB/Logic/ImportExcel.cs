using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
namespace ConnectionDB.Logic
{
	public class ImportExcel
	{
		public readonly string fpath;
		public ImportExcel()
		{
		}
        public DataTable load(string fpath)
        {
            DataTable dt = new DataTable();
            try
            {
                var stream = File.Open(fpath, FileMode.Open, FileAccess.Read);
                var Reader = ExcelReaderFactory.CreateReader(stream);
                do
                {
                    while (Reader.Read())
                    {
                        if (Reader.Depth == 0)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                dt.Columns.Add(Reader.GetString(i));
                            }
                        }
                        else
                        {
                            DataRow dr = dt.NewRow();
                            for (int i = 0; i < 8; i++)
                            {
                                dr[i] = Reader.GetValue(i);
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                } while (Reader.NextResult());
            }
            catch
            {

            }
            return dt;
        }
    }
}
