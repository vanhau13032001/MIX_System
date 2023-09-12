
namespace Mix_System
{
    partial class frm_Production_Data
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
            this.btt_Report = new System.Windows.Forms.Button();
            this.btt_Search = new System.Windows.Forms.Button();
            this.grb_SortbyTime = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpk_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpk_TimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_SortbyShift = new System.Windows.Forms.RadioButton();
            this.rdb_SortbyTime = new System.Windows.Forms.RadioButton();
            this.grb_SortbyShift = new System.Windows.Forms.GroupBox();
            this.cb_ShiftSelect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpk_ShiftDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btt_Excel_Report = new System.Windows.Forms.Button();
            this.btt_Showdata = new System.Windows.Forms.Button();
            this.Clear_data = new System.Windows.Forms.Button();
            this.grb_SortbyTime.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grb_SortbyShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_Report
            // 
            this.btt_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Report.Location = new System.Drawing.Point(184, 112);
            this.btt_Report.Name = "btt_Report";
            this.btt_Report.Size = new System.Drawing.Size(115, 39);
            this.btt_Report.TabIndex = 30;
            this.btt_Report.Text = "Báo Cáo PDF";
            this.btt_Report.UseVisualStyleBackColor = true;
            this.btt_Report.Click += new System.EventHandler(this.btt_Report_Click);
            // 
            // btt_Search
            // 
            this.btt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Search.Location = new System.Drawing.Point(26, 112);
            this.btt_Search.Name = "btt_Search";
            this.btt_Search.Size = new System.Drawing.Size(96, 39);
            this.btt_Search.TabIndex = 29;
            this.btt_Search.Text = "Tìm Kiếm";
            this.btt_Search.UseVisualStyleBackColor = true;
            this.btt_Search.Click += new System.EventHandler(this.btt_Search_Click);
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
            this.grb_SortbyTime.Location = new System.Drawing.Point(184, 12);
            this.grb_SortbyTime.Name = "grb_SortbyTime";
            this.grb_SortbyTime.Size = new System.Drawing.Size(366, 94);
            this.grb_SortbyTime.TabIndex = 27;
            this.grb_SortbyTime.TabStop = false;
            this.grb_SortbyTime.Text = "Tìm kiếm theo thời gian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Kết thúc:";
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
            this.dtpk_DateEnd.CustomFormat = "yyyy-MM-dd";
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
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bắt đầu:";
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
            this.dtpk_DateStart.CustomFormat = "yyyy-MM-dd";
            this.dtpk_DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateStart.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpk_DateStart.Location = new System.Drawing.Point(80, 25);
            this.dtpk_DateStart.Name = "dtpk_DateStart";
            this.dtpk_DateStart.Size = new System.Drawing.Size(108, 23);
            this.dtpk_DateStart.TabIndex = 0;
            this.dtpk_DateStart.Value = new System.DateTime(2021, 9, 14, 14, 29, 43, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_SortbyShift);
            this.groupBox5.Controls.Add(this.rdb_SortbyTime);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 94);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lựa chọn tìm kiếm";
            // 
            // rdb_SortbyShift
            // 
            this.rdb_SortbyShift.AutoSize = true;
            this.rdb_SortbyShift.Location = new System.Drawing.Point(7, 52);
            this.rdb_SortbyShift.Name = "rdb_SortbyShift";
            this.rdb_SortbyShift.Size = new System.Drawing.Size(100, 21);
            this.rdb_SortbyShift.TabIndex = 0;
            this.rdb_SortbyShift.Text = "Theo ca SX";
            this.rdb_SortbyShift.UseVisualStyleBackColor = true;
            this.rdb_SortbyShift.CheckedChanged += new System.EventHandler(this.rdb_SortbyShift_CheckedChanged);
            // 
            // rdb_SortbyTime
            // 
            this.rdb_SortbyTime.AutoSize = true;
            this.rdb_SortbyTime.Checked = true;
            this.rdb_SortbyTime.Location = new System.Drawing.Point(7, 25);
            this.rdb_SortbyTime.Name = "rdb_SortbyTime";
            this.rdb_SortbyTime.Size = new System.Drawing.Size(117, 21);
            this.rdb_SortbyTime.TabIndex = 0;
            this.rdb_SortbyTime.TabStop = true;
            this.rdb_SortbyTime.Text = "Theo thời gian";
            this.rdb_SortbyTime.UseVisualStyleBackColor = true;
            this.rdb_SortbyTime.CheckedChanged += new System.EventHandler(this.rdb_SortbyTime_CheckedChanged);
            // 
            // grb_SortbyShift
            // 
            this.grb_SortbyShift.Controls.Add(this.cb_ShiftSelect);
            this.grb_SortbyShift.Controls.Add(this.label11);
            this.grb_SortbyShift.Controls.Add(this.label12);
            this.grb_SortbyShift.Controls.Add(this.dtpk_ShiftDate);
            this.grb_SortbyShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grb_SortbyShift.Location = new System.Drawing.Point(556, 12);
            this.grb_SortbyShift.Name = "grb_SortbyShift";
            this.grb_SortbyShift.Size = new System.Drawing.Size(212, 94);
            this.grb_SortbyShift.TabIndex = 31;
            this.grb_SortbyShift.TabStop = false;
            this.grb_SortbyShift.Text = "Tìm kiếm theo ca";
            // 
            // cb_ShiftSelect
            // 
            this.cb_ShiftSelect.FormattingEnabled = true;
            this.cb_ShiftSelect.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cb_ShiftSelect.Location = new System.Drawing.Point(91, 57);
            this.cb_ShiftSelect.Name = "cb_ShiftSelect";
            this.cb_ShiftSelect.Size = new System.Drawing.Size(108, 24);
            this.cb_ShiftSelect.TabIndex = 14;
            this.cb_ShiftSelect.Text = "--Ca SX--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Chọn ca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Chọn ngày";
            // 
            // dtpk_ShiftDate
            // 
            this.dtpk_ShiftDate.AllowDrop = true;
            this.dtpk_ShiftDate.Checked = false;
            this.dtpk_ShiftDate.CustomFormat = "yyyy-mm-dd";
            this.dtpk_ShiftDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_ShiftDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpk_ShiftDate.Location = new System.Drawing.Point(91, 25);
            this.dtpk_ShiftDate.Name = "dtpk_ShiftDate";
            this.dtpk_ShiftDate.Size = new System.Drawing.Size(108, 23);
            this.dtpk_ShiftDate.TabIndex = 0;
            this.dtpk_ShiftDate.Value = new System.DateTime(2021, 9, 14, 14, 29, 43, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(923, 300);
            this.dataGridView1.TabIndex = 32;
            // 
            // btt_Excel_Report
            // 
            this.btt_Excel_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Excel_Report.Location = new System.Drawing.Point(184, 157);
            this.btt_Excel_Report.Name = "btt_Excel_Report";
            this.btt_Excel_Report.Size = new System.Drawing.Size(115, 39);
            this.btt_Excel_Report.TabIndex = 30;
            this.btt_Excel_Report.Text = "Báo Cáo Excel";
            this.btt_Excel_Report.UseVisualStyleBackColor = true;
            this.btt_Excel_Report.Click += new System.EventHandler(this.btt_Excel_Report_Click);
            // 
            // btt_Showdata
            // 
            this.btt_Showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Showdata.Location = new System.Drawing.Point(26, 157);
            this.btt_Showdata.Name = "btt_Showdata";
            this.btt_Showdata.Size = new System.Drawing.Size(96, 39);
            this.btt_Showdata.TabIndex = 29;
            this.btt_Showdata.Text = "Show Data";
            this.btt_Showdata.UseVisualStyleBackColor = true;
            this.btt_Showdata.Click += new System.EventHandler(this.btt_Showdata_Click);
            // 
            // Clear_data
            // 
            this.Clear_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear_data.Location = new System.Drawing.Point(305, 157);
            this.Clear_data.Name = "Clear_data";
            this.Clear_data.Size = new System.Drawing.Size(115, 39);
            this.Clear_data.TabIndex = 30;
            this.Clear_data.Text = "Xóa Dữ Liệu";
            this.Clear_data.UseVisualStyleBackColor = true;
            this.Clear_data.Click += new System.EventHandler(this.Clear_data_Click);
            // 
            // frm_Production_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grb_SortbyShift);
            this.Controls.Add(this.Clear_data);
            this.Controls.Add(this.btt_Excel_Report);
            this.Controls.Add(this.btt_Report);
            this.Controls.Add(this.btt_Showdata);
            this.Controls.Add(this.btt_Search);
            this.Controls.Add(this.grb_SortbyTime);
            this.Controls.Add(this.groupBox5);
            this.Name = "frm_Production_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Production_Data";
            this.Load += new System.EventHandler(this.frm_Production_Data_Load);
            this.grb_SortbyTime.ResumeLayout(false);
            this.grb_SortbyTime.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grb_SortbyShift.ResumeLayout(false);
            this.grb_SortbyShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Report;
        private System.Windows.Forms.Button btt_Search;
        private System.Windows.Forms.GroupBox grb_SortbyTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpk_TimeEnd;
        private System.Windows.Forms.DateTimePicker dtpk_DateEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpk_TimeStart;
        private System.Windows.Forms.DateTimePicker dtpk_DateStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox grb_SortbyShift;
        private System.Windows.Forms.ComboBox cb_ShiftSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpk_ShiftDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btt_Excel_Report;
        private System.Windows.Forms.Button btt_Showdata;
        private System.Windows.Forms.RadioButton rdb_SortbyShift;
        private System.Windows.Forms.RadioButton rdb_SortbyTime;
        private System.Windows.Forms.Button Clear_data;
    }
}