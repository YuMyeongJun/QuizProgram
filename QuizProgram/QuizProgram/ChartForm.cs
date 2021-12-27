using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuizProgram
{
    public partial class ChartForm : Form
    {
        public ChartForm(string[] paramArr)
        {
            InitializeComponent();

            Console.WriteLine(paramArr);

            chart.Series.Clear();
            /*for (int i = 0; i < paramArr.Length; i++)
            {
                string param = paramArr[i];
                Console.WriteLine(paramArr);
                Series[] series = new Series[paramArr.Length];
                series[i] = new Series(paramArr[i].name);
                series[i].Points.AddXY("공격", paramArr[i].attack);
                series[i].Points.AddXY("수비", paramArr[i].defence);
                series[i].Points.AddXY("패스", paramArr[i].pass);
                series[i].Points.AddXY("슛", paramArr[i].shoot);
                series[i].ChartType = SeriesChartType.Radar;
                chart.Series.Add(series[i]);
            }*/
        }
    }
}
