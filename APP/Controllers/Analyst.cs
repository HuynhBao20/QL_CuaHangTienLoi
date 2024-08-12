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
                ChartType = SeriesChartType.Line, // Set chart type to Column
                XValueType = ChartValueType.String, // X-axis type (e.g., categories)
                YValueType = ChartValueType.Double // Y-axis type (e.g., values)
            };
            foreach(DataRow item in da.Rows)
			{
                series.Points.AddXY(item["Ngày lập"].ToString(), int.Parse(item["Tổng giá trị hóa đơn"].ToString()));
			}

            // Add series to the chart
            chart.Series.Add(series);
        }
	}
}
