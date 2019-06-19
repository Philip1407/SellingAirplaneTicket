namespace SellAirplaneTicketManagement.User_Control
{
    partial class RenevueReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbMonth1 = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtYear1 = new System.Windows.Forms.TextBox();
            this.txtYear2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYear2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(957, 58);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 53);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Xuất báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(887, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ChartData
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartData.Legends.Add(legend1);
            this.ChartData.Location = new System.Drawing.Point(81, 150);
            this.ChartData.Name = "ChartData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartData.Series.Add(series1);
            this.ChartData.Size = new System.Drawing.Size(1043, 423);
            this.ChartData.TabIndex = 10;
            this.ChartData.Text = "DataChart";
            // 
            // cmbMonth1
            // 
            this.cmbMonth1.FormattingEnabled = true;
            this.cmbMonth1.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cmbMonth1.Location = new System.Drawing.Point(117, 87);
            this.cmbMonth1.Name = "cmbMonth1";
            this.cmbMonth1.Size = new System.Drawing.Size(121, 30);
            this.cmbMonth1.TabIndex = 11;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(262, 93);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 22);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "năm";
            // 
            // txtYear1
            // 
            this.txtYear1.Location = new System.Drawing.Point(310, 87);
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.Size = new System.Drawing.Size(85, 30);
            this.txtYear1.TabIndex = 13;
            // 
            // txtYear2
            // 
            this.txtYear2.Location = new System.Drawing.Point(810, 81);
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.Size = new System.Drawing.Size(85, 30);
            this.txtYear2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "năm";
            // 
            // cmbYear2
            // 
            this.cmbYear2.FormattingEnabled = true;
            this.cmbYear2.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cmbYear2.Location = new System.Drawing.Point(617, 81);
            this.cmbYear2.Name = "cmbYear2";
            this.cmbYear2.Size = new System.Drawing.Size(121, 30);
            this.cmbYear2.TabIndex = 14;
            // 
            // RenevueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYear2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear2);
            this.Controls.Add(this.txtYear1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cmbMonth1);
            this.Controls.Add(this.ChartData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RenevueReport";
            this.Size = new System.Drawing.Size(1110, 559);
            ((System.ComponentModel.ISupportInitialize)(this.ChartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartData;
        private System.Windows.Forms.ComboBox cmbMonth1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtYear1;
        private System.Windows.Forms.TextBox txtYear2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYear2;
    }
}
