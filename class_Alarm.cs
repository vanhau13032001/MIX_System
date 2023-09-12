using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient; // Thư viện SQL

namespace Mix_System
{
    public static class class_Alarm
    {
        // Tên Alarm
        static string Alarm_ID1 = "Động cơ trộn lỗi";
        static string Alarm_ID2 = "Van 1 lỗi";
        static string Alarm_ID3 = "Van 2 lỗi";
        static string Alarm_ID4 = "Van 3 lỗi";
        // Alarm mới xuất hiện
        public static void cmd_NewAlarm(int ID)
        {
            string Table_Name = "Alarm";
            string collum1 = "Date_time";
            string collum2 = "ID";
            string collum3 = "Status";
            string collum4 = "AlarmName";

            string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            int data2 = ID;
            string data3 = "I";
            string data4 = "";
            if (ID == 1) { data4 = Alarm_ID1; }
            if (ID == 2) { data4 = Alarm_ID2; }
            if (ID == 3) { data4 = Alarm_ID3; }
            if (ID == 4) { data4 = Alarm_ID4; }
            SqlConnection sql_conn;
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = " INSERT INTO " + Table_Name + " ("
                + collum1 + ","
                + collum2 + ","
                + collum3 + ","
                + collum4 + ")"
                + " VALUES "
                + "("
                + "@" + collum1 + ","
                + "@" + collum2 + ","
                + "@" + collum3 + ","
                + "@" + collum4 + ")";
            using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
            {
                cmd.Parameters.AddWithValue(collum1, data1);
                cmd.Parameters.AddWithValue(collum2, data2);
                cmd.Parameters.AddWithValue(collum3, data3);
                cmd.Parameters.AddWithValue(collum4, data4);
                cmd.ExecuteNonQuery();
            }
            sql_conn.Close();
        }
        // Alarm đã hết
        public static void cmd_AckAlarm(int ID)
        {
            string Table_Name = "Alarm";
            string collum2 = "ID";
            string collum3 = "Status";

            SqlConnection sql_conn; // Khởi tạo tên kết nối SQL
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = " UPDATE " + Table_Name + " SET "
                + collum3 + "= 'IO'"
                + "WHERE "
                + collum2 + "= " + ID;
            using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
            {
                cmd.ExecuteNonQuery();
            }
            sql_conn.Close();
        }
        // Hiển thị lên data grid view
        public static void Display(string sqlSelect, DataGridView dtgr)
        {
            SqlConnection sql_conn; // Khởi tạo tên kết nối SQL
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, sql_conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgr.DataSource = dt;
            dtgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql_conn.Close();
        }
    }
}