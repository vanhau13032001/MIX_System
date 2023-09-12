using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymbolFactoryDotNet; // Thư viện symbol factory
using System.Drawing;
using System.Windows.Forms;

namespace Mix_System
{
    class class_Status_Display
    {

        // Hiển thị nhóm 3 trạng thái động cơ/bơm;/băng tải
        public void stt_Motor(StandardControl st, string value)
        {
            if (value == "1")
            {
                st.DiscreteValue1 = true;
                st.DiscreteValue2 = false;
            }
            if (value == "2")
            {
                st.DiscreteValue1 = false;
                st.DiscreteValue2 = true;
            }
            if (value != "1" & value != "2")
            {
                st.DiscreteValue1 = false;
                st.DiscreteValue2 = false;
            }
        }
        // Hiển thị nhóm 3 trạng thái - Van
        public void stt_Valve(StandardControl st, string value)
        {
            if (value == "1")
            {
                st.DiscreteValue1 = true;
                st.DiscreteValue2 = false;
            }
            if (value == "2")
            {
                st.DiscreteValue1 = false;
                st.DiscreteValue2 = true;
            }
            if (value != "1" & value != "2")
            {
                st.DiscreteValue1 = false;
                st.DiscreteValue2 = false;
            }
        }
        // Hiển thị nhóm 2 trạng thái - Cảm biến
        public void stt_Sensor(StandardControl st, string value)
        {
            if (value == "True")
            {
                st.DiscreteValue1 = true;
            }
            else
            {
                st.DiscreteValue1 = false;
            }
        }
        // Hiển thị nhóm 2 trạng thái - Đèn báo
        public void stt_Lamp(StandardControl st, string value)
        {
            if (value == "True")
            {
                st.DiscreteValue1 = true;
            }
            else
            {
                st.DiscreteValue1 = false;
            }
        }
        public void stt_Button(Button btt, string value,
                       string backcolor, string forecolor)
        {
            if (value == "True")
            {
                btt.BackColor = ColorTranslator.FromHtml(backcolor);
                btt.ForeColor = ColorTranslator.FromHtml(forecolor);
            }
            else
            {
                btt.BackColor = default(Color);
                btt.ForeColor = default(Color);
            }
        }
    }
}
