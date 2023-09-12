
namespace Mix_System
{
    partial class frm_Order
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
            this.dtg_Order = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Weight_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Weight_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Order_ID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btt_Update = new System.Windows.Forms.Button();
            this.btt_Delete = new System.Windows.Forms.Button();
            this.btt_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Order
            // 
            this.dtg_Order.AllowUserToAddRows = false;
            this.dtg_Order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Order.Location = new System.Drawing.Point(284, 20);
            this.dtg_Order.Name = "dtg_Order";
            this.dtg_Order.ReadOnly = true;
            this.dtg_Order.RowHeadersVisible = false;
            this.dtg_Order.Size = new System.Drawing.Size(504, 247);
            this.dtg_Order.TabIndex = 16;
            this.dtg_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Order_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Weight_2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_Weight_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_Order_ID);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.btt_Update);
            this.groupBox1.Controls.Add(this.btt_Delete);
            this.groupBox1.Controls.Add(this.btt_Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 255);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // tbx_Weight_2
            // 
            this.tbx_Weight_2.Location = new System.Drawing.Point(24, 162);
            this.tbx_Weight_2.Name = "tbx_Weight_2";
            this.tbx_Weight_2.Size = new System.Drawing.Size(175, 20);
            this.tbx_Weight_2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trọng lượng liệu 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(205, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "[kg]";
            // 
            // tbx_Weight_1
            // 
            this.tbx_Weight_1.Location = new System.Drawing.Point(24, 103);
            this.tbx_Weight_1.Name = "tbx_Weight_1";
            this.tbx_Weight_1.Size = new System.Drawing.Size(175, 20);
            this.tbx_Weight_1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trọng lượng liệu 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(205, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "[kg]";
            // 
            // tbx_Order_ID
            // 
            this.tbx_Order_ID.Location = new System.Drawing.Point(24, 51);
            this.tbx_Order_ID.Name = "tbx_Order_ID";
            this.tbx_Order_ID.Size = new System.Drawing.Size(175, 20);
            this.tbx_Order_ID.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.Location = new System.Drawing.Point(21, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 17);
            this.label27.TabIndex = 12;
            this.label27.Text = "Mã đơn hàng:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label29.Location = new System.Drawing.Point(205, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 17);
            this.label29.TabIndex = 13;
            this.label29.Text = "[Giây]";
            // 
            // btt_Update
            // 
            this.btt_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Update.Location = new System.Drawing.Point(88, 210);
            this.btt_Update.Name = "btt_Update";
            this.btt_Update.Size = new System.Drawing.Size(87, 32);
            this.btt_Update.TabIndex = 0;
            this.btt_Update.Text = "Cập nhật";
            this.btt_Update.UseVisualStyleBackColor = true;
            this.btt_Update.Click += new System.EventHandler(this.btt_Update_Click);
            // 
            // btt_Delete
            // 
            this.btt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Delete.Location = new System.Drawing.Point(181, 210);
            this.btt_Delete.Name = "btt_Delete";
            this.btt_Delete.Size = new System.Drawing.Size(60, 32);
            this.btt_Delete.TabIndex = 0;
            this.btt_Delete.Text = "Xóa";
            this.btt_Delete.UseVisualStyleBackColor = true;
            this.btt_Delete.Click += new System.EventHandler(this.btt_Delete_Click);
            // 
            // btt_Add
            // 
            this.btt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btt_Add.Location = new System.Drawing.Point(6, 210);
            this.btt_Add.Name = "btt_Add";
            this.btt_Add.Size = new System.Drawing.Size(76, 32);
            this.btt_Add.TabIndex = 0;
            this.btt_Add.Text = "Thêm";
            this.btt_Add.UseVisualStyleBackColor = true;
            this.btt_Add.Click += new System.EventHandler(this.btt_Add_Click);
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.dtg_Order);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Order";
            this.Load += new System.EventHandler(this.frm_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Order;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbx_Weight_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbx_Weight_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbx_Order_ID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.Button btt_Update;
        public System.Windows.Forms.Button btt_Delete;
        public System.Windows.Forms.Button btt_Add;
    }
}