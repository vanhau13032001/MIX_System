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
    public partial class frm_Popup_Motor : Form
    {
        internal static frm_Popup_Motor frm_Motor;
        public frm_Popup_Motor()
        {
            InitializeComponent();
            frm_Motor = this;
        }

        private void frm_Popup_Motor_Load(object sender, EventArgs e)
        {

        }
        public void setTitle(string title)
        {
            this.Text = title;
        }
        // Tạo 2 biến tag ID cho 2 nút nhấn on/off
        public int tag_ONID;
        public int tag_OFFID;
        // Nút nhấn chạy động cơ
        private void bttMotorRun_Click(object sender, EventArgs e)
        {
            frm_Main.formMain.popup_button_Clicked(tag_ONID);
        }
        // Nút nhấn dừng động cơ
        private void bttMotorStop_Click(object sender, EventArgs e)
        {
            frm_Main.formMain.popup_button_Clicked(tag_OFFID);
        }
    }
}
