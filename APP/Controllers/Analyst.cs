using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace APP.Controllers
{
	public class Analyst
	{
		Connection db = new Connection();
		public void Analyst_Month(Chart chart)
		{
            ChartArea chartArea = new ChartArea("");
            DataTable da = db.loadDB("EXEC sp_ThongKeTheoNgay");
            //chart.ChartAreas.Add(chartArea);

            // Create a new series
            Series series = new Series("Doanh thu theo ngày")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double 
            };
            foreach(DataRow item in da.Rows)
			{
                series.Points.AddXY(item["Ngày lập"].ToString(), int.Parse(item["Tổng giá trị hóa đơn"].ToString()));
			}

            // Add series to the chart
            chart.Series.Add(series);
        }
        public void Analyst_Product_Buy(Chart chart)
		{
            ChartArea chartArea = new ChartArea("");
            DataTable da = db.loadDB("EXEC sp_SoSP");
            Series series = new Series("")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };
            foreach (DataRow item in da.Rows)
            {
                series.Points.AddXY(item["TENSP"].ToString(), int.Parse(item["SOLUONG"].ToString()));
            }

            // Add series to the chart
            chart.Series.Add(series);
        }
	}
}
