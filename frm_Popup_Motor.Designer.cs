
namespace Mix_System
{
    partial class frm_Popup_Motor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttMotorStop = new System.Windows.Forms.Button();
            this.bttMotorRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttMotorStop
            // 
            this.bttMotorStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttMotorStop.Location = new System.Drawing.Point(33, 107);
            this.bttMotorStop.Name = "bttMotorStop";
            this.bttMotorStop.Size = new System.Drawing.Size(116, 35);
            this.bttMotorStop.TabIndex = 9;
            this.bttMotorStop.Text = "DỪNG";
            this.bttMotorStop.UseVisualStyleBackColor = true;
            this.bttMotorStop.Click += new System.EventHandler(this.bttMotorStop_Click);
            // 
            // bttMotorRun
            // 
            this.bttMotorRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttMotorRun.Location = new System.Drawing.Point(33, 66);
            this.bttMotorRun.Name = "bttMotorRun";
            this.bttMotorRun.Size = new System.Drawing.Size(116, 35);
            this.bttMotorRun.TabIndex = 8;
            this.bttMotorRun.Text = "CHẠY";
            this.bttMotorRun.UseVisualStyleBackColor = true;
            this.bttMotorRun.Click += new System.EventHandler(this.bttMotorRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Điều khiển động cơ";
            // 
            // frm_Popup_Motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 178);
            this.Controls.Add(this.bttMotorStop);
            this.Controls.Add(this.bttMotorRun);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Popup_Motor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Popup_Motor";
            this.Load += new System.EventHandler(this.frm_Popup_Motor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttMotorStop;
        private System.Windows.Forms.Button bttMotorRun;
        private System.Windows.Forms.Label label1;
    }
}