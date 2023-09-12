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
    public partial class frm_Popup_Valve : Form
    {
        internal static frm_Popup_Valve frm_Valve;
        public frm_Popup_Valve()
        {
            InitializeComponent();
            frm_Valve = this;
        }
        private void frm_Popup_Valve_Load(object sender, EventArgs e)
        {

        }
        // Chương trình con hiển thị tittle
        public void setTitle(string title)
        {
            this.Text = title;
        }
        // Tạo 2 biến tag ID cho 2 nút nhấn on/off
        public int tag_ONID;
        public int tag_OFFID;
        // Nút nhấn mở van
        private void bttValveOpen_Click(object sender, EventArgs e)
        {
            frm_Main.formMain.popup_button_Clicked(tag_ONID);
        }
        // Nút nhấn đóng van
        private void bttValveClose_Click(object sender, EventArgs e)
        {
           frm_Main.formMain.popup_button_Clicked(tag_OFFID);
        }
    }
}
