using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OPCAutomation;//thêm thư viện OPC 
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient; // Thư viện SQL
namespace Mix_System
{
    public partial class frm_Main : Form
    {
        internal static frm_Main formMain;// formain có thể truy cập bất kì trong cùng namespace
        public frm_Main()
        {
            InitializeComponent();
            formMain = this;
        }
        // Khởi tạo SQL
        public void sqlInnit()
        {
            SqlConnection sql_conn;
            string DB_Name = Properties.Settings.Default.SQL_DBName;//tên cơ sở dữ liệu muốn kết nối 
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
        }
        // hàm gọi popup hiển thị
        // Gửi dữ liệu đồ thị qua form "frm_Trend.cs"
        static string data_Nguyen_Lieu1;
        static string data_Nguyen_Lieu2;
        // Nguyên liệu 1
        public static string trend_data_NL1()
        {
            return data_Nguyen_Lieu1;
        }
        // Nguyên liệu 2
        public static string trend_data_NL2()
        {
            return data_Nguyen_Lieu2;
        }
        string Watchdog_value = "0";
        private void Timer_Watchdog_Tick(object sender, EventArgs e)
        {
            class_Watchdog.WatchdogStatus(toolStripStatusLabel1, Watchdog_value);
        }

        class_Login fn_login = new class_Login();
        class_Status_Display statusDisplay = new class_Status_Display();
   
        private void frm_Main_Load(object sender, EventArgs e)
        {
            sqlInnit();
            KEPServerEX_Connect();
            fn_login.Not_Login();
            combobox_dataload();
        }
        private void sm_Login_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            loginForm.Show();
        }

        private void sm_Logout_Click(object sender, EventArgs e)
        {
               fn_login.Not_Login();
        }

        static int tagNumber = 32;      // Cài đặt số lượng tag của project
        static int PLCscantime = 1000;  // Cài đặt thời gian quét PLC
        // Gọi các kết nối OPC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;
        static int arrlength = tagNumber + 1;
        Array OPtags = class_KEPServerEX.tagread(arrlength);
        Array tagID = class_KEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);
        // Chương trình con kết nối (Connect);
        private void KEPServerEX_Connect()
        {
            string IOServer = "Kepware.KEPServerEX.V6";
            string IOGroup = "OPCGroup1";
            OPCServer = new OPCAutomation.OPCServer();
            OPCServer.Connect(IOServer, "");
            PLC = OPCServer.OPCGroups.Add(IOGroup);
            PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(dataScan);
            PLC.UpdateRate = PLCscantime;
            PLC.IsSubscribed = PLC.IsActive;
            PLC.OPCItems.DefaultIsActive = true;
            PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                out tagHandles, out OPCError, dataType, AccessPaths);
        }

        // Khai báo biến tạm lưu dữ liệu sản xuất
        string sql_OrderID;
        string sql_Weight1_Setting;
        string sql_Weight2_Setting;
        string sql_Weight1_Actual;
        string sql_Weight2_Actual;
        string sql_Time_Tron;
        //==========================ĐỌC DỮ LIỆU TAG=====================
        private void dataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                Console.WriteLine(tagID.Length);

                // Watchdog
                if (getTagID == 1)
                {
                    Watchdog_value = tagValue;
                }

                if (getTagID == 17)
                {
                    statusDisplay.stt_Valve(sym_Valve1, tagValue);
                }
                // Van 2
                if (getTagID == 18)
                {
                    statusDisplay.stt_Valve(sym_Valve2, tagValue);
                }
                // Van 3

                if (getTagID == 19)
                {
                    statusDisplay.stt_Valve(sym_Valve3, tagValue);
                }
                // Động cơ khuấy
                if (getTagID == 20)
                {
                    statusDisplay.stt_Motor(sym_Motor, tagValue);
                }
                // Cảm biến cạn
                if (getTagID == 13)
                {
                    statusDisplay.stt_Sensor(sym_Sensor, tagValue);
                }
                // Cài đặt nguyên liệu 1
                if (getTagID == 23)
                {
                    tbx_Set_Liquid1.Text = tagValue;
                    tbx_Order_Liquid1.Text = tagValue;
                }
                // Cài đặt nguyên liệu 2
                if (getTagID == 24)
                {
                    tbx_Set_Liquid2.Text = tagValue;
                    tbx_Order_Liquid2.Text = tagValue;
                }
                // Cài đặt thời gian
                if (getTagID == 21)
                {
                    tbx_Set_Time.Text = tagValue;
                    tbx_Set_Time1.Text = tagValue;
                }
                // Giá trị thực tế nguyên liệu 1
                if (getTagID == 25)
                {
                    tbx_Act_Liquid1.Text = tagValue;
                }
                // Giá trị thực tế nguyên liệu 2
                if (getTagID == 26)
                {
                    tbx_Act_Liquid2.Text = tagValue;
                }

                // Giá trị thực tế thời gian
                if (getTagID == 22)
                {
                    tbx_Act_Time.Text = tagValue;
                }

                // Trạng thái nút nhấn auto
                if (getTagID == 14)
                {
                    statusDisplay.stt_Lamp(Lamp_Auto, tagValue);
                    statusDisplay.stt_Button(btt_Auto, tagValue, "#48f542", "#003366");
                }
                // Trạng thái nút nhấn Manu
                if (getTagID == 15)
                {
                    statusDisplay.stt_Lamp(Lamp_Manu, tagValue);
                    statusDisplay.stt_Button(btt_Manu, tagValue, "#f5ec42", "#003366");
                }

                //++++DỮ LIỆU SẢN XUẤT +++
                // Mã đơn hàng (Order ID)
                if (getTagID == 27)
                {
                    sql_OrderID = tagValue;
                }
                // Trọng lượng cài đặt liệu 1 lưu vào SQL
                if (getTagID == 28)
                {
                    sql_Weight1_Setting = tagValue;
                }
                // Trọng lượng cài đặt liệu 2 lưu vào SQL
                if (getTagID == 29)
                {
                    sql_Weight2_Setting = tagValue;
                }
                // Trọng lượng thực tế liệu 1 lưu vào SQL
                if (getTagID == 30)
                {
                    sql_Weight1_Actual = tagValue;
                }
                // Trọng lượng thực tế liệu 2 lưu vào SQL
                if (getTagID == 31)
                {
                    sql_Weight2_Actual = tagValue;
                }
                // Thực tế thời gian trộn lưu vào SQL
                if (getTagID == 32)
                {
                    sql_Time_Tron = tagValue;
                }
                
                // Bit trigger lưu dữ liệu
                if (getTagID == 16)
                {
                    if (tagValue == "True")
                    {
                        // Khai báo giá trị
                        string sqltable_name = "Mix_System_Data";
                        string collum1 = "Datetime";
                        string collum2 = "Shift";
                        string collum3 = "Order_ID";
                        string collum4 = "Setting_Weight1";
                        string collum5 = "Actual_Weight1";
                        string collum6 = "Setting_Weight2";
                        string collum7 = "Actual_Weight2";
                        string collum8 = "Actual_Time_Tron";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = class_Shift.shift_Now();
                        string data3 = sql_OrderID;
                        string data4 = sql_Weight1_Setting;
                        string data5 = sql_Weight1_Actual;
                        string data6 = sql_Weight2_Setting;
                        string data7 = sql_Weight2_Actual;
                        string data8 = sql_Time_Tron;
                        // Hàm Ghi dữ liệu
                        class_Database.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2,
                            collum3, data3,
                            collum4, data4,
                            collum5, data5,
                            collum6, data6,
                            collum7, data7,
                            collum8, data8);
                    }
                }
                //++++ĐỒ THỊ - TREND +++
                // Nguyên liệu 1
                if (getTagID == 25)
                {
                    data_Nguyen_Lieu1 = tagValue;
                }
                // Nguyên liệu 2
                if (getTagID == 26)
                {
                    data_Nguyen_Lieu2 = tagValue;
                }
                //++++CẢNH BÁO - ALARM +++
                // Alarm Động cơ trộn
                if (getTagID == 20)
                {
                    if (tagValue == "2") { class_Alarm.cmd_NewAlarm(1); }
                    else { class_Alarm.cmd_AckAlarm(1); }
                }
                // Alarm van 1
                if (getTagID == 17)
                {
                    if (tagValue == "2") { class_Alarm.cmd_NewAlarm(2); }
                    else { class_Alarm.cmd_AckAlarm(2); }
                }
                // Alarm van 2
                if (getTagID == 18)
                {
                    if (tagValue == "2") { class_Alarm.cmd_NewAlarm(3); }
                    else { class_Alarm.cmd_AckAlarm(3); }
                }
                // Alarm van 3
                if (getTagID == 19)
                {
                    if (tagValue == "2") { class_Alarm.cmd_NewAlarm(4); }
                    else { class_Alarm.cmd_AckAlarm(4); }
                }
            }
        }

        private void sm_Admin_Click(object sender, EventArgs e)
        {
           // frm_Setting sfrm_Setting = new frm_Setting();
            //sfrm_Setting.Show();
        }

        private void sm_Order_Click(object sender, EventArgs e)
        {
            frm_Order sfrm_Order = new frm_Order();
            sfrm_Order.Show();
        }
        private void sm_Data_Click(object sender, EventArgs e)
        {
            frm_Production_Data sfrm_Production_Data = new frm_Production_Data();
            sfrm_Production_Data.Show();
            

        }

        private void sm_Alarm_Click(object sender, EventArgs e)
        {
            frm_Alarm alarmForm = new frm_Alarm();
            alarmForm.Show();
        }
        private void sm_Trend_Click(object sender, EventArgs e)
        {
            frm_Trend trendForm = new frm_Trend();
            trendForm.Show();
        }

        private void sm_Setting_Click(object sender, EventArgs e)
        {
            frm_Setting sfrm_Setting = new frm_Setting();
            sfrm_Setting.Show();
        }

        private void btt_Auto_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 2);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 2);
        }

        private void btt_Manu_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 3);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 3);
        }
        private void btt_Confirm_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(tbx_Order_Liquid1.Text, 23);
            WriteItems.SetValue(tbx_Order_Liquid2.Text, 24);
            WriteItems.SetValue(tbx_Set_Time.Text, 21);
            WriteItems.SetValue(cbx_Order.SelectedValue, 27);
            WriteItems.SetValue(1, 4);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 4);
        }
     
        private void sym_Valve1_Click(object sender, EventArgs e)
        {
            frm_Popup_Valve frm_Valve = new frm_Popup_Valve();
            frm_Valve.tag_ONID = 5;   // ID tag Chạy V1
            frm_Valve.tag_OFFID = 6;  // ID tag Dừng V1
            frm_Valve.Show();
            frm_Popup_Valve.frm_Valve.setTitle("V1 Control");
        }

        private void sym_Valve2_Click(object sender, EventArgs e)
        {
            frm_Popup_Valve frm_Valve = new frm_Popup_Valve();
            frm_Valve.tag_ONID = 7;   // ID tag Chạy V2
            frm_Valve.tag_OFFID = 8;  // ID tag Dừng V2
            frm_Valve.Show();
            frm_Popup_Valve.frm_Valve.setTitle("V2 Control");
        }

        private void sym_Valve3_Click(object sender, EventArgs e)
        {
            frm_Popup_Valve frm_Valve = new frm_Popup_Valve();
            frm_Valve.tag_ONID = 9;   // ID tag Chạy V3
            frm_Valve.tag_OFFID = 10;  // ID tag Dừng V3
            frm_Valve.Show();
            frm_Popup_Valve.frm_Valve.setTitle("V3 Control");
        }

        private void sym_Motor_Click(object sender, EventArgs e)
        {
            frm_Popup_Motor frm_Motor = new frm_Popup_Motor();
            frm_Motor.tag_ONID = 11;   // ID tag Chạy V3
            frm_Motor.tag_OFFID = 12;  // ID tag Dừng V3
            frm_Motor.Show();
            frm_Popup_Motor.frm_Motor.setTitle("Motor Control");
        }
        public void popup_button_Clicked(int tagID)
        {
            WriteItems.SetValue(1, tagID);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, tagID);
        }
        // Load dữ liệu cho combobox đơn hàng
        public void combobox_dataload()
        {
            string sqlSelect = "SELECT * FROM data_Order;";
            string collum = "Order_ID";
            class_Order_SQL.FillComboBox(cbx_Order, sqlSelect, collum);
        }
        // khi thay đổi đơn hàng 
        private void cbx_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM data_Order;";
            string column1 = "Weight_1";
            string column2 = "Weight_2";
            class_Order_SQL.getcomboboxindex(cbx_Order, tbx_Order_Liquid1, tbx_Order_Liquid2,
                                             sqlSelect, column1, column2);

        }
    }
}
