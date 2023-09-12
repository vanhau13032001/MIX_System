
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Mix_System
{
    public partial class frm_Production_Data : Form
    {
        public frm_Production_Data()
        {
            InitializeComponent();
        }
        class_Excel_Export fn_Excel = new class_Excel_Export();
        private void frm_Production_Data_Load(object sender, EventArgs e)
        {
            grb_SortbyShift.Visible = false;
            Clear_data.Visible = false;
        }
        private void rdb_SortbyTime_CheckedChanged(object sender, EventArgs e)
        {
            grb_SortbyTime.Visible = true;
            grb_SortbyShift.Visible = false;
            grb_SortbyTime.Location = new System.Drawing.Point(184, 12);
        }
        private void rdb_SortbyShift_CheckedChanged(object sender, EventArgs e)
        {
            grb_SortbyShift.Visible = true;
            grb_SortbyTime.Visible = false;
            grb_SortbyShift.Location = new System.Drawing.Point(184, 12);
        }
        private void btt_Search_Click(object sender, EventArgs e)
        {
            string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");
            if (rdb_SortbyTime.Checked == true) // Chọn tìm kiếm theo thời gian
            {
                string tablename = "Mix_System_Data"; // Bảng cần truy vấn
                string datetime_collum_name = "Datetime";
                string sqlSelect = "SELECT * FROM "
                    + tablename + " WHERE " + datetime_collum_name + " BETWEEN '"
                    + Date_Start + " " + Time_Start
                    + "' AND '" + Date_End + " " + Time_End
                    + "' ORDER BY " + datetime_collum_name + ";";
                class_Database.sqlDisplay(sqlSelect, dataGridView1);
            }
            // textBox1.Text = sqlSelect;
        
            // SQL tìm kiếm theo ca sản xuất
            if (rdb_SortbyShift.Checked == true) // Chọn tìm kiếm theo ca SX
            {
                var dt1 = dtpk_ShiftDate.Value.AddDays(1); //Ngày mai của dtpicker
                string dt = dtpk_ShiftDate.Value.ToString("yyyy-MM-dd");
                string tomorrow = dt1.ToString("yyyy-MM-dd");
                string tablename = "Mix_System_Data"; // Bảng cần truy vấn
                string datetime_collum_name = "Datetime"; // Cột thời gian
                string Shift_collum_name = "Shift"; // Cột ca sản xuất
                string Shiftname = cb_ShiftSelect.Text; // Tên ca đã lựa chọn
                string search_end_time;
                // Xác định thời điểm kết thúc tìm kiếm
                if (cb_ShiftSelect.Text == "C")
                {
                    search_end_time = tomorrow + " 13:00:00'";
                }
                else // Nếu là ca A hoặc B
                {
                    search_end_time = tomorrow + " 00:00:00'";
                }
                // Câu lệnh tìm kiếm
                string sqlSelect = "SELECT *FROM "
                   + tablename
                   + " where " + Shift_collum_name + " = '" + Shiftname + "' AND "
                   + datetime_collum_name + " between '" + dt + "' and '"
                   + search_end_time
                   + " ORDER BY " + datetime_collum_name + ";";
                // Hàm tìm kiếm dữ liệu
                class_Database.sqlDisplay(sqlSelect, dataGridView1);
                dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
                dataGridView1.Columns[1].HeaderText = "Ca sản xuất";
                dataGridView1.Columns[2].HeaderText = "Mã đơn";
                dataGridView1.Columns[3].HeaderText = "Liệu 1 cài đặt[kg]";
                dataGridView1.Columns[4].HeaderText = "Liệu 1 thực tế[kg]";
                dataGridView1.Columns[5].HeaderText = "Liệu 2 cài đặt[kg]";
                dataGridView1.Columns[6].HeaderText = "Liệu 1 thực tế[kg]";
                dataGridView1.Columns[7].HeaderText = "Thời gian trộn[s]";
            }
        } 
        private void btt_Showdata_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM Mix_System_Data;";
            class_Database.sqlDisplay(sqlSelect, dataGridView1);
            // Đặt tên cho các cột datagridview
            dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
            dataGridView1.Columns[1].HeaderText = "Ca sản xuất";
            dataGridView1.Columns[2].HeaderText = "Mã đơn";
            dataGridView1.Columns[3].HeaderText = "Liệu 1 cài đặt[kg]";
            dataGridView1.Columns[4].HeaderText = "Liệu 1 thực tế[kg]";
            dataGridView1.Columns[5].HeaderText = "Liệu 2 cài đặt[kg]";
            dataGridView1.Columns[6].HeaderText = "Liệu 1 thực tế[kg]";
            dataGridView1.Columns[7].HeaderText = "Thời gian trộn[s]";
        }

        private void btt_Report_Click(object sender, EventArgs e)
        {
            // Tạo các biến string từ date time piker
            string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");
            string ShiftDate = dtpk_ShiftDate.Value.ToString("yyyy-MM-dd");
            string tomorrow = dtpk_ShiftDate.Value.AddDays(1).ToString("yyyy-MM-dd");
            string ShiftID = cb_ShiftSelect.Text;
            string SearchBy = rdb_SortbyTime.Checked.ToString();
            // Mở form xuất báo cáo (form_Report)
            frm_Report frm = new frm_Report();
            // Truyền dữ liệu qua form report
            frm.rpDatetime_Start = Date_Start + ' ' + Time_Start;
            frm.rpDatetime_End = Date_End + ' ' + Time_End;
            frm.rpShift_Search_Start = ShiftDate + " 00:00:00";
            frm.rpShift_Search_End = ShiftDate + " 23:59:59";
            frm.rptomorrow = tomorrow + " 23:59:59";
            frm.rpShiftID = ShiftID;
            frm.rpSearchBy = SearchBy;
            frm.Show();
        }

        private void btt_Excel_Report_Click(object sender, EventArgs e)
        {
            // Gọi hàm chương trình con xuất Excel
            fn_Excel.Execute(dtpk_DateStart,
                             dtpk_TimeStart,
                             dtpk_DateEnd,
                             dtpk_TimeEnd,
                             dtpk_ShiftDate,
                             rdb_SortbyTime,
                             cb_ShiftSelect
                );
        }

        private void Clear_data_Click(object sender, EventArgs e)
        {
            string sqltable_name = "Mix_System_Data";
            class_Database.cmd_DeleteAllData(sqltable_name);
            MessageBox.Show("ĐÃ XÓA TOÀN BỘ DỮ LIỆU");
            string sqlSelect = "SELECT * FROM Mix_System_Data;";
            class_Database.sqlDisplay(sqlSelect, dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
            dataGridView1.Columns[1].HeaderText = "Ca sản xuất";
            dataGridView1.Columns[2].HeaderText = "Mã đơn";
            dataGridView1.Columns[3].HeaderText = "Liệu 1 cài đặt[kg]";
            dataGridView1.Columns[4].HeaderText = "Liệu 1 thực tế[kg]";
            dataGridView1.Columns[5].HeaderText = "Liệu 2 cài đặt[kg]";
            dataGridView1.Columns[6].HeaderText = "Liệu 1 thực tế[kg]";
            dataGridView1.Columns[7].HeaderText = "Thời gian trộn[s]";
        }
    }
}
