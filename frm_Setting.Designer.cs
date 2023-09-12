
namespace Mix_System
{
    partial class frm_Setting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btt_SQLSave = new System.Windows.Forms.Button();
            this.tbx_DBName = new System.Windows.Forms.TextBox();
            this.btt_SQLEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btt_Shift_Save = new System.Windows.Forms.Button();
            this.dtpk_C = new System.Windows.Forms.DateTimePicker();
            this.btt_Shift_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpk_B = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpk_A = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btt_SQLSave);
            this.groupBox2.Controls.Add(this.tbx_DBName);
            this.groupBox2.Controls.Add(this.btt_SQLEdit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(228, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 136);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt SQL Server";
            // 
            // btt_SQLSave
            // 
            this.btt_SQLSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btt_SQLSave.Location = new System.Drawing.Point(103, 88);
            this.btt_SQLSave.Name = "btt_SQLSave";
            this.btt_SQLSave.Size = new System.Drawing.Size(72, 34);
            this.btt_SQLSave.TabIndex = 5;
            this.btt_SQLSave.Text = "Save";
            this.btt_SQLSave.UseVisualStyleBackColor = true;
            this.btt_SQLSave.Click += new System.EventHandler(this.btt_SQLSave_Click);
            // 
            // tbx_DBName
            // 
            this.tbx_DBName.Enabled = false;
            this.tbx_DBName.Location = new System.Drawing.Point(14, 56);
            this.tbx_DBName.Name = "tbx_DBName";
            this.tbx_DBName.Size = new System.Drawing.Size(161, 23);
            this.tbx_DBName.TabIndex = 0;
            // 
            // btt_SQLEdit
            // 
            this.btt_SQLEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btt_SQLEdit.Location = new System.Drawing.Point(15, 88);
            this.btt_SQLEdit.Name = "btt_SQLEdit";
            this.btt_SQLEdit.Size = new System.Drawing.Size(71, 34);
            this.btt_SQLEdit.TabIndex = 4;
            this.btt_SQLEdit.Text = "Edit";
            this.btt_SQLEdit.UseVisualStyleBackColor = true;
            this.btt_SQLEdit.Click += new System.EventHandler(this.btt_SQLEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Cơ Sở Dữ Liệu:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btt_Shift_Save);
            this.groupBox4.Controls.Add(this.dtpk_C);
            this.groupBox4.Controls.Add(this.btt_Shift_Edit);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtpk_B);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtpk_A);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(42, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 307);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cài đặt ca sản xuất";
            // 
            // btt_Shift_Save
            // 
            this.btt_Shift_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btt_Shift_Save.Location = new System.Drawing.Point(97, 250);
            this.btt_Shift_Save.Name = "btt_Shift_Save";
            this.btt_Shift_Save.Size = new System.Drawing.Size(77, 34);
            this.btt_Shift_Save.TabIndex = 7;
            this.btt_Shift_Save.Text = "Save";
            this.btt_Shift_Save.UseVisualStyleBackColor = true;
            this.btt_Shift_Save.Click += new System.EventHandler(this.btt_Shift_Save_Click);
            // 
            // dtpk_C
            // 
            this.dtpk_C.Enabled = false;
            this.dtpk_C.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_C.Location = new System.Drawing.Point(14, 208);
            this.dtpk_C.Name = "dtpk_C";
            this.dtpk_C.ShowUpDown = true;
            this.dtpk_C.Size = new System.Drawing.Size(119, 23);
            this.dtpk_C.TabIndex = 4;
            this.dtpk_C.Value = new System.DateTime(2021, 9, 13, 16, 0, 0, 0);
            // 
            // btt_Shift_Edit
            // 
            this.btt_Shift_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btt_Shift_Edit.Location = new System.Drawing.Point(6, 250);
            this.btt_Shift_Edit.Name = "btt_Shift_Edit";
            this.btt_Shift_Edit.Size = new System.Drawing.Size(77, 34);
            this.btt_Shift_Edit.TabIndex = 6;
            this.btt_Shift_Edit.Text = "Edit";
            this.btt_Shift_Edit.UseVisualStyleBackColor = true;
            this.btt_Shift_Edit.Click += new System.EventHandler(this.btt_Shift_Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(11, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thời gian lên ca C";
            // 
            // dtpk_B
            // 
            this.dtpk_B.Enabled = false;
            this.dtpk_B.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_B.Location = new System.Drawing.Point(14, 136);
            this.dtpk_B.Name = "dtpk_B";
            this.dtpk_B.ShowUpDown = true;
            this.dtpk_B.Size = new System.Drawing.Size(119, 23);
            this.dtpk_B.TabIndex = 4;
            this.dtpk_B.Value = new System.DateTime(2021, 9, 13, 8, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời gian lên ca B";
            // 
            // dtpk_A
            // 
            this.dtpk_A.CustomFormat = "HH:mm";
            this.dtpk_A.Enabled = false;
            this.dtpk_A.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_A.Location = new System.Drawing.Point(14, 67);
            this.dtpk_A.Name = "dtpk_A";
            this.dtpk_A.ShowUpDown = true;
            this.dtpk_A.Size = new System.Drawing.Size(119, 23);
            this.dtpk_A.TabIndex = 2;
            this.dtpk_A.Value = new System.DateTime(2021, 9, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian lên ca A";
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "frm_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Setting";
            this.Load += new System.EventHandler(this.frm_Setting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btt_SQLSave;
        private System.Windows.Forms.TextBox tbx_DBName;
        public System.Windows.Forms.Button btt_SQLEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button btt_Shift_Save;
        private System.Windows.Forms.DateTimePicker dtpk_C;
        public System.Windows.Forms.Button btt_Shift_Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpk_B;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpk_A;
        private System.Windows.Forms.Label label4;
    }
}