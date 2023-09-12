using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart; // Trend
namespace Mix_System
{
    public partial class frm_Trend : Form
    {
        public frm_Trend()
        {
            InitializeComponent();
        }
        // Khai báo trend trong đồ thị
        kayChart trend_Nglieu1; // Nguyên liệu 1
        kayChart trend_Nglieu2; // Nguyên liệu 2
        // Form load
        private void frm_Trend_Load(object sender, EventArgs e)
        {
            trend_Nglieu1 = new kayChart(chart1, 50);
            trend_Nglieu1.serieName = "Nguyên Liệu 1";
            trend_Nglieu2 = new kayChart(chart1, 50);
            trend_Nglieu2.serieName = "Nguyên Liệu 2";
        }

        private void trend_Update_Tick(object sender, EventArgs e)
        {
            // Trend nguyên liệu 1
            string getdataNL1 = frm_Main.trend_data_NL1();
            double data1;
            bool result1 = Double.TryParse(getdataNL1, out data1);
            if (result1)
            {
                trend_Nglieu1.TriggeredUpdate(data1);
            }
            // Trend nguyên liệu 2
            string getdataNL2 = frm_Main.trend_data_NL2();
            double data2;
            bool result2 = Double.TryParse(getdataNL2, out data2);
            if (result2)
            {
                trend_Nglieu2.TriggeredUpdate(data2);
            }
        }
    }
}
