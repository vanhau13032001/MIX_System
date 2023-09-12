using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mix_System
{
    public partial class frm_Alarm : Form
    {
        public frm_Alarm()
        {
            InitializeComponent();
        }

        private void frm_Alarm_Load(object sender, EventArgs e)
        {

        }

        private void btt_SearchAlarm_Click(object sender, EventArgs e)
        {
            string tablename = "Alarm"; // Bảng cần truy vấn
            string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");
            string datetime_collum_name = "Date_time";
            string sqlSelect = "SELECT *FROM "
                + tablename + " where DATE_TIME between '"
                + Date_Start + " " + Time_Start
                + "' and '" + Date_End + " " + Time_End
                + "' ORDER BY " + datetime_collum_name + ";";
            class_Alarm.Display(sqlSelect, dataGridView1);
            // Đặt tên cho các cột datagridview
            dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
            dataGridView1.Columns[1].HeaderText = "Alarm ID";
            dataGridView1.Columns[2].HeaderText = "Trạng thái";
            dataGridView1.Columns[3].HeaderText = "Cảnh báo";
            dataGridView1.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        private void btt_ActiveAlarm_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT *FROM Alarm WHERE Status = 'I'";
            class_Alarm.Display(sqlSelect, dataGridView1);
            // Đặt tên cho các cột datagridview
            dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
            dataGridView1.Columns[1].HeaderText = "Alarm ID";
            dataGridView1.Columns[2].HeaderText = "Trạng thái";
            dataGridView1.Columns[3].HeaderText = "Cảnh báo";
            dataGridView1.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
