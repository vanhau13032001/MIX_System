
namespace Mix_System
{
    partial class frm_Alarm
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
            this.grb_SortbyTime = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpk_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpk_TimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btt_ActiveAlarm = new System.Windows.Forms.Button();
            this.btt_SearchAlarm = new System.Windows.Forms.Button();
            this.grb_SortbyTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_SortbyTime
            // 
            this.grb_SortbyTime.Controls.Add(this.label10);
            this.grb_SortbyTime.Controls.Add(this.dtpk_TimeEnd);
            this.grb_SortbyTime.Controls.Add(this.dtpk_DateEnd);
            this.grb_SortbyTime.Controls.Add(this.label9);
            this.grb_SortbyTime.Controls.Add(this.dtpk_TimeStart);
            this.grb_SortbyTime.Controls.Add(this.dtpk_DateStart);
            this.grb_SortbyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grb_SortbyTime.Location = new System.Drawing.Point(23, 31);
            this.grb_SortbyTime.Name = "grb_SortbyTime";
            this.grb_SortbyTime.Size = new System.Drawing.Size(323, 88);
            this.grb_SortbyTime.TabIndex = 20;
            this.grb_SortbyTime.TabStop = false;
            this.grb_SortbyTime.Text = "Tìm kiếm theo thời gian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đến:";
            // 
            // dtpk_TimeEnd
            // 
            this.dtpk_TimeEnd.CustomFormat = "HH:mm:ss";
            this.dtpk_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_TimeEnd.Location = new System.Drawing.Point(194, 54);
            this.dtpk_TimeEnd.Name = "dtpk_TimeEnd";
            this.dtpk_TimeEnd.ShowUpDown = true;
            this.dtpk_TimeEnd.Size = new System.Drawing.Size(116, 23);
            this.dtpk_TimeEnd.TabIndex = 4;
            // 
            // dtpk_DateEnd
            // 
            this.dtpk_DateEnd.AllowDrop = true;
            this.dtpk_DateEnd.Checked = false;
            this.dtpk_DateEnd.CustomFormat = "yyyy-mm-dd";
            this.dtpk_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateEnd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpk_DateEnd.Location = new System.Drawing.Point(80, 54);
            this.dtpk_DateEnd.Name = "dtpk_DateEnd";
            this.dtpk_DateEnd.Size = new System.Drawing.Size(108, 23);
            this.dtpk_DateEnd.TabIndex = 3;
            this.dtpk_DateEnd.Value = new System.DateTime(2023, 9, 14, 14, 29, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Từ:";
            // 
            // dtpk_TimeStart
            // 
            this.dtpk_TimeStart.CustomFormat = "HH:mm:ss";
            this.dtpk_TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_TimeStart.Location = new System.Drawing.Point(194, 25);
            this.dtpk_TimeStart.Name = "dtpk_TimeStart";
            this.dtpk_TimeStart.ShowUpDown = true;
            this.dtpk_TimeStart.Size = new System.Drawing.Size(116, 23);
            this.dtpk_TimeStart.TabIndex = 1;
            // 
            // dtpk_DateStart
            // 
            this.dtpk_DateStart.AllowDrop = true;
            this.dtpk_DateStart.Checked = false;
            this.dtpk_DateStart.CustomFormat = "yyyy-mm-dd";
            this.dtpk_DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateStart.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpk_DateStart.Location = new System.Drawing.Point(80, 25);
            this.dtpk_DateStart.Name = "dtpk_DateStart";
            this.dtpk_DateStart.Size = new System.Drawing.Size(108, 23);
            this.dtpk_DateStart.TabIndex = 0;
            this.dtpk_DateStart.Value = new System.DateTime(2023, 9, 14, 14, 29, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(617, 290);
            this.dataGridView1.TabIndex = 19;
            // 
            // btt_ActiveAlarm
            // 
            this.btt_ActiveAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_ActiveAlarm.Location = new System.Drawing.Point(352, 82);
            this.btt_ActiveAlarm.Name = "btt_ActiveAlarm";
            this.btt_ActiveAlarm.Size = new System.Drawing.Size(116, 35);
            this.btt_ActiveAlarm.TabIndex = 18;
            this.btt_ActiveAlarm.Text = "Active Alarm";
            this.btt_ActiveAlarm.UseVisualStyleBackColor = true;
            this.btt_ActiveAlarm.Click += new System.EventHandler(this.btt_ActiveAlarm_Click);
            // 
            // btt_SearchAlarm
            // 
            this.btt_SearchAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_SearchAlarm.Location = new System.Drawing.Point(352, 39);
            this.btt_SearchAlarm.Name = "btt_SearchAlarm";
            this.btt_SearchAlarm.Size = new System.Drawing.Size(116, 35);
            this.btt_SearchAlarm.TabIndex = 21;
            this.btt_SearchAlarm.Text = "Search Alarm";
            this.btt_SearchAlarm.UseVisualStyleBackColor = true;
            this.btt_SearchAlarm.Click += new System.EventHandler(this.btt_SearchAlarm_Click);
            // 
            // frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 439);
            this.Controls.Add(this.grb_SortbyTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btt_ActiveAlarm);
            this.Controls.Add(this.btt_SearchAlarm);
            this.Name = "frm_Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Alarm";
            this.Load += new System.EventHandler(this.frm_Alarm_Load);
            this.grb_SortbyTime.ResumeLayout(false);
            this.grb_SortbyTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_SortbyTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpk_TimeEnd;
        private System.Windows.Forms.DateTimePicker dtpk_DateEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpk_TimeStart;
        private System.Windows.Forms.DateTimePicker dtpk_DateStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btt_ActiveAlarm;
        private System.Windows.Forms.Button btt_SearchAlarm;
    }
}