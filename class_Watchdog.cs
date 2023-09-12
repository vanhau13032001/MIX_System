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
    class class_Watchdog
    {
        static string valold = "";
        // Chương trình con Watch dog
        public static void WatchdogStatus(ToolStripStatusLabel lb, string valnow)
        {
            if (valnow != valold)
            {
                lb.BackColor = Color.Green;
                lb.ForeColor = Color.White;
            }
            else
            {
                lb.BackColor = Color.Red;
                lb.ForeColor = Color.White;
            }
            valold = valnow;
        }
    }
}
