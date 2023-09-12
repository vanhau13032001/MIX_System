
namespace Mix_System
{
    partial class frm_Popup_Valve
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
            this.bttValveClose = new System.Windows.Forms.Button();
            this.bttValveOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttValveClose
            // 
            this.bttValveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttValveClose.Location = new System.Drawing.Point(36, 112);
            this.bttValveClose.Name = "bttValveClose";
            this.bttValveClose.Size = new System.Drawing.Size(116, 35);
            this.bttValveClose.TabIndex = 12;
            this.bttValveClose.Text = "ĐÓNG";
            this.bttValveClose.UseVisualStyleBackColor = true;
            this.bttValveClose.Click += new System.EventHandler(this.bttValveClose_Click);
            // 
            // bttValveOpen
            // 
            this.bttValveOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttValveOpen.Location = new System.Drawing.Point(36, 71);
            this.bttValveOpen.Name = "bttValveOpen";
            this.bttValveOpen.Size = new System.Drawing.Size(116, 35);
            this.bttValveOpen.TabIndex = 11;
            this.bttValveOpen.Text = "MỞ";
            this.bttValveOpen.UseVisualStyleBackColor = true;
            this.bttValveOpen.Click += new System.EventHandler(this.bttValveOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Điều khiển van";
            // 
            // frm_Popup_Valve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 189);
            this.Controls.Add(this.bttValveClose);
            this.Controls.Add(this.bttValveOpen);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Popup_Valve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Popup_Valve";
            this.Load += new System.EventHandler(this.frm_Popup_Valve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttValveClose;
        private System.Windows.Forms.Button bttValveOpen;
        private System.Windows.Forms.Label label1;
    }
}