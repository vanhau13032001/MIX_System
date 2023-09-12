using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
namespace Mix_System
{
    class class_Database
    {
        public static void cmd_SQLWrite(string sqltable_name,
                                        string collum1, string data1,
                                        string collum2, string data2,
                                        string collum3, string data3,
                                        string collum4, string data4,
                                        string collum5, string data5,
                                        string collum6, string data6,
                                        string collum7, string data7,
                                        string collum8, string data8)
        {
            SqlConnection sql_conn;
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = " INSERT INTO " + sqltable_name + " ("
                + collum1 + ","
                + collum2 + ","
                + collum3 + ","
                + collum4 + ","
                + collum5 + ","
                + collum6 + ","
                + collum7 + ","
                + collum8 + ")"
                + " VALUES "
                + "("
                + "@" + collum1 + ","
                + "@" + collum2 + ","
                + "@" + collum3 + ","
                + "@" + collum4 + ","
                + "@" + collum5 + ","
                + "@" + collum6 + ","
                + "@" + collum7 + ","
                + "@" + collum8 + ")";
            using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
            {
                cmd.Parameters.AddWithValue(collum1, data1);
                cmd.Parameters.AddWithValue(collum2, data2);
                cmd.Parameters.AddWithValue(collum3, data3);
                cmd.Parameters.AddWithValue(collum4, data4);
                cmd.Parameters.AddWithValue(collum5, data5);
                cmd.Parameters.AddWithValue(collum6, data6);
                cmd.Parameters.AddWithValue(collum7, data7);
                cmd.Parameters.AddWithValue(collum8, data8);
                cmd.ExecuteNonQuery();
            }
            sql_conn.Close();
        }
        public static void cmd_DeleteAllData(string sqltable_name)
        {
            SqlConnection sql_conn;
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=" + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            string sql = $"DELETE FROM {sqltable_name}";
            using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
            {
                cmd.ExecuteNonQuery();
            }
            sql_conn.Close();
        }
        // Hiển thị lên data grid view
        public static void sqlDisplay(string sqlSelect, DataGridView dtgr)
        {
            SqlConnection sql_conn;
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                sql_conn = new SqlConnection(sqlName);
                sql_conn.Open();

                // Thực hiện câu truy vấn SQL
                SqlCommand cmd = new SqlCommand(sqlSelect, sql_conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Kiểm tra xem có dữ liệu trong SqlDataReader hay không

                if (dr.HasRows)
                {
                    // Nếu có dữ liệu, nạp dữ liệu vào DataTable và hiển thị trong DataGridView
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtgr.DataSource = dt;
                    dtgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                else
                {
                    // Nếu không có dữ liệu, bạn có thể hiển thị một thông báo hoặc thực hiện xử lý tùy ý
                    MessageBox.Show("Không có dữ liệu trả về từ câu truy vấn.");
                }

                // Đóng kết nối sau khi hoàn thành
                sql_conn.Close();
            }

            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
        }
    }
}
