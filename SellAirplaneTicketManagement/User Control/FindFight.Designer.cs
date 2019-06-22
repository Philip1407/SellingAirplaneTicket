namespace SellAirplaneTicketManagement.User_Control
{
    partial class FindFight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbArrive = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(487, 125);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 34);
            this.btnFind.TabIndex = 26;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmbArrive
            // 
            this.cmbArrive.FormattingEnabled = true;
            this.cmbArrive.Items.AddRange(new object[] {
            "VietNamAirline",
            "VietJet"});
            this.cmbArrive.Location = new System.Drawing.Point(570, 179);
            this.cmbArrive.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArrive.Name = "cmbArrive";
            this.cmbArrive.Size = new System.Drawing.Size(290, 30);
            this.cmbArrive.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(483, 182);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 31;
            this.label18.Text = "Điểm đến";
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            "VietNamAirline",
            "VietJet"});
            this.cmbDepart.Location = new System.Drawing.Point(178, 179);
            this.cmbDepart.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(290, 30);
            this.cmbDepart.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 182);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 25);
            this.label19.TabIndex = 32;
            this.label19.Text = "Điểm khởi hành";
            // 
            // dpkDate
            // 
            this.dpkDate.Location = new System.Drawing.Point(178, 127);
            this.dpkDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(290, 30);
            this.dpkDate.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ngày khởi hành";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(273, 41);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(347, 38);
            this.label20.TabIndex = 24;
            this.label20.Text = "TRA CỨU LỊCH BAY";
            // 
            // grvData
            // 
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Location = new System.Drawing.Point(31, 225);
            this.grvData.Name = "grvData";
            this.grvData.Size = new System.Drawing.Size(1067, 372);
            this.grvData.TabIndex = 34;
            // 
            // FindFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbArrive);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dpkDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label20);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindFight";
            this.Size = new System.Drawing.Size(1101, 600);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cmbArrive;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView grvData;
    }
}
