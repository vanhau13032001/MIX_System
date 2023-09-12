using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện SQL
namespace Mix_System
{
    public partial class frm_Order : Form
    {
        public frm_Order()
        {
            InitializeComponent();
        }
        // Chương trình con hiển thị dữ liệu
        public void Order_Display()
        {
            string sqlSelect = "SELECT * FROM data_Order;";
            // class SQL 
            class_Order_SQL.sqlDisplay(sqlSelect, dtg_Order);
            // Đặt tên cho các cột datagridview
            dtg_Order.Columns[0].HeaderText = "Mã đơn hàng";
            dtg_Order.Columns[1].HeaderText = "Trọng lượng liệu 1";
            dtg_Order.Columns[2].HeaderText = "Trọng lượng liệu 2";
        }
        private void frm_Order_Load(object sender, EventArgs e)
        {
            Order_Display();
        }

        private void dtg_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_Order.Rows[e.RowIndex];
                tbx_Order_ID.Text = row.Cells[0].Value.ToString();
                tbx_Weight_1.Text = row.Cells[1].Value.ToString();
                tbx_Weight_2.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btt_Add_Click(object sender, EventArgs e)
        {

            // Kiểm tra mã đơn hàng đã tồn tại không
            Boolean Order_Exist = false;
            foreach (DataGridViewRow row in dtg_Order.Rows)
            {
                if (tbx_Order_ID.Text == row.Cells["Order_ID"].Value.ToString())
                {
                    Order_Exist = true;
                    // Cảnh báo đơn hàng đẫ tồn tại
                    MessageBox.Show("Đơn hàng đã tồn tại!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            // Nếu đơn hàng không bị trùng thì thêm mới đơn hàng
            if (!Order_Exist)
            {
                // Khai báo giá trị
                string sqltable_name = "data_Order";
                string collum1 = "Order_ID";
                string collum2 = "Weight_1";
                string collum3 = "Weight_2";
                string data1 = tbx_Order_ID.Text.ToString();
                string data2 = tbx_Weight_1.Text.ToString();
                string data3 = tbx_Weight_2.Text.ToString();
                // Hàm Ghi dữ liệu
                class_Order_SQL.cmd_SQLWrite(sqltable_name,
                        collum1, data1,
                        collum2, data2,
                        collum3, data3);
                MessageBox.Show("Đơn hàng đã được thêm!");
                Order_Display();
                frm_Main.formMain.combobox_dataload();
            }
        }

        private void btt_Update_Click(object sender, EventArgs e)
        {
            // Khai báo giá trị
            string sqltable_name = "data_Order";
            string collum1 = "Order_ID";
            string collum2 = "Weight_1";
            string collum3 = "Weight_2";
            string data1 = tbx_Order_ID.Text.ToString();
            string data2 = tbx_Weight_1.Text.ToString();
            string data3 = tbx_Weight_2.Text.ToString();
            // Hàm Ghi dữ liệu
            class_Order_SQL.cmd_SQLUpdate(sqltable_name,
                    collum1, data1,
                    collum2, data2,
                    collum3, data3);
            MessageBox.Show("Đơn hàng đã được cập nhật!");
            Order_Display();
            frm_Main.formMain.combobox_dataload();

        }

        private void btt_Delete_Click(object sender, EventArgs e)
        {

            // Khai báo giá trị
            string sqltable_name = "data_Order";
            string collum1 = "Order_ID";
            string data1 = tbx_Order_ID.Text.ToString();
            // Hàm Ghi dữ liệu
            class_Order_SQL.cmd_SQLDelete(sqltable_name,
                collum1,data1);
            MessageBox.Show("Đã xóa dữ liệu!");
            Order_Display();
            frm_Main.formMain.combobox_dataload();
        }
    }
}
