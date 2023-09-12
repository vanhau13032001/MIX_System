using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mix_System
{
    class class_Login
    {
        // Disable toàn bộ khi chưa đăng nhập/ hoặc nhấn đăng xuất
        public void Not_Login()
        {
            frm_Main frm = (frm_Main)Application.OpenForms["frm_Main"];//Tham chiếu các đối tượng trong frm_Main
            // Các object cần Enable/Disable
            // chuyển các mức độ truy cập  modifier của đối tượng sang chế độ puclic để truy cập tại form login
            frm.btt_Auto.Enabled = false;
            frm.btt_Manu.Enabled = false;
            frm.btt_Confirm.Enabled = false;
            frm.cbx_Order.Enabled = false;
            frm.tbx_Set_Time.Enabled = false;
            frm.sym_Valve1.Enabled = false;
            frm.sym_Valve2.Enabled = false;
            frm.sym_Valve3.Enabled = false;
            frm.sym_Motor.Enabled = false;
            frm.sm_Setting.Enabled = false;
            frm.sm_Data.Enabled = false;
            frm.sm_Order.Enabled = false;
            frm.sm_Trend.Enabled = false;
            frm.sm_Alarm.Enabled = false;
            frm.sm_Home.Enabled = false;
            frm.tbx_Order_Liquid1.Enabled = false;
            frm.tbx_Order_Liquid2.Enabled = false;
        }
        // Đăng nhập bằng quyền Admin
        public void admin_Control_Elements()
        {
            frm_Main frm = (frm_Main)Application.OpenForms["frm_Main"];
            // Các object cần Enable/Disable
            frm.btt_Auto.Enabled = true;
            frm.btt_Manu.Enabled = true;
            frm.btt_Confirm.Enabled = true;
            frm.cbx_Order.Enabled = true;
            frm.tbx_Set_Time.Enabled = true;
            frm.sym_Valve1.Enabled = true;
            frm.sym_Valve2.Enabled = true;
            frm.sym_Valve3.Enabled = true;
            frm.sym_Motor.Enabled = true;
            frm.sm_Setting.Enabled = true;
            frm.sm_Data.Enabled = true;
            frm.sm_Order.Enabled = true;
            frm.sm_Trend.Enabled = true;
            frm.sm_Alarm.Enabled = true;
            frm.sm_Home.Enabled = true;
            frm.tbx_Order_Liquid1.Enabled = true;
            frm.tbx_Order_Liquid2.Enabled = true;
        }

        // Đăng nhập bằng quyền người dùng Operator
        public void Operator_Control_Elements()
        {
            frm_Main frm = (frm_Main)Application.OpenForms["frm_Main"];
            // Các object cần Enable/Disable
            frm.btt_Auto.Enabled = true;
            frm.btt_Manu.Enabled = true;
            frm.btt_Confirm.Enabled = true;
            frm.cbx_Order.Enabled = true;
            frm.tbx_Set_Time.Enabled = true;
            frm.sym_Valve1.Enabled = true;
            frm.sym_Valve2.Enabled = true;
            frm.sym_Valve3.Enabled = true;
            frm.sym_Motor.Enabled = true;
            frm.sm_Setting.Enabled = false;
            frm.sm_Data.Enabled = false;
            frm.sm_Order.Enabled = false;
            frm.sm_Trend.Enabled = false;
            frm.sm_Alarm.Enabled = false;
            frm.sm_Home.Enabled = false;
            frm.tbx_Order_Liquid1.Enabled = false;
            frm.tbx_Order_Liquid2.Enabled = false;
        }
    }
}
