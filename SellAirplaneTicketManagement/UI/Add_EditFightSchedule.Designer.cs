namespace SellAirplaneTicketManagement.UI
{
    partial class Add_EditFightSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.dpkStart = new System.Windows.Forms.DateTimePicker();
            this.dpkEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbFight = new System.Windows.Forms.ComboBox();
            this.grvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian khởi hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình trạng";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(113, 494);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(118, 58);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(396, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 58);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Chưa cất cánh",
            "Đã hạ cánh",
            "Đã dời lịch",
            "Đã hủy"});
            this.cmbState.Location = new System.Drawing.Point(239, 242);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(291, 30);
            this.cmbState.TabIndex = 13;
            // 
            // dpkDate
            // 
            this.dpkDate.Location = new System.Drawing.Point(239, 89);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(291, 30);
            this.dpkDate.TabIndex = 14;
            // 
            // dpkStart
            // 
            this.dpkStart.Location = new System.Drawing.Point(239, 136);
            this.dpkStart.Name = "dpkStart";
            this.dpkStart.Size = new System.Drawing.Size(291, 30);
            this.dpkStart.TabIndex = 15;
            // 
            // dpkEnd
            // 
            this.dpkEnd.Location = new System.Drawing.Point(239, 189);
            this.dpkEnd.Name = "dpkEnd";
            this.dpkEnd.Size = new System.Drawing.Size(291, 30);
            this.dpkEnd.TabIndex = 16;
            // 
            // cmbFight
            // 
            this.cmbFight.FormattingEnabled = true;
            this.cmbFight.Location = new System.Drawing.Point(239, 47);
            this.cmbFight.Name = "cmbFight";
            this.cmbFight.Size = new System.Drawing.Size(291, 30);
            this.cmbFight.TabIndex = 17;
            // 
            // grvData
            // 
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Location = new System.Drawing.Point(23, 278);
            this.grvData.Name = "grvData";
            this.grvData.RowTemplate.Height = 24;
            this.grvData.Size = new System.Drawing.Size(634, 192);
            this.grvData.TabIndex = 31;
            // 
            // Add_EditFightSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 564);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.cmbFight);
            this.Controls.Add(this.dpkEnd);
            this.Controls.Add(this.dpkStart);
            this.Controls.Add(this.dpkDate);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_EditFightSchedule";
            this.Text = "Add_EditFightSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private System.Windows.Forms.DateTimePicker dpkStart;
        private System.Windows.Forms.DateTimePicker dpkEnd;
        private System.Windows.Forms.ComboBox cmbFight;
        private System.Windows.Forms.DataGridView grvData;
    }
}