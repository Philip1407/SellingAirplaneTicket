namespace SellAirplaneTicketManagement
{
    partial class Admin
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
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.bookTicket1 = new SellAirplaneTicketManagement.User_Control.BookTicket();
            this.findFight1 = new SellAirplaneTicketManagement.User_Control.FindFight();
            this.pnFlightPolicy = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.tbMenu.SuspendLayout();
            this.pnFlightPolicy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbMenu.Controls.Add(this.tb1);
            this.tbMenu.Controls.Add(this.tb2);
            this.tbMenu.Controls.Add(this.tb3);
            this.tbMenu.Controls.Add(this.tb4);
            this.tbMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbMenu.ItemSize = new System.Drawing.Size(75, 200);
            this.tbMenu.Location = new System.Drawing.Point(3, 5);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(5);
            this.tbMenu.Multiline = true;
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(1381, 974);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbMenu_DrawItem);
            // 
            // bookTicket1
            // 
            this.bookTicket1.AutoSize = true;
            this.bookTicket1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicket1.Location = new System.Drawing.Point(21, 21);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(1131, 416);
            this.bookTicket1.TabIndex = 0;
            // 
            // findFight1
            // 
            this.findFight1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFight1.Location = new System.Drawing.Point(4, 9);
            this.findFight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findFight1.Name = "findFight1";
            this.findFight1.Size = new System.Drawing.Size(851, 362);
            this.findFight1.TabIndex = 0;
            // 
            // pnFlightPolicy
            // 
            this.pnFlightPolicy.Controls.Add(this.label37);
            this.pnFlightPolicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFlightPolicy.Location = new System.Drawing.Point(0, 0);
            this.pnFlightPolicy.Name = "pnFlightPolicy";
            this.pnFlightPolicy.Size = new System.Drawing.Size(1192, 966);
            this.pnFlightPolicy.TabIndex = 9;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(352, 33);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(358, 38);
            this.label37.TabIndex = 0;
            this.label37.Text = "Điều khoản chuyến bay";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(430, 237);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(124, 38);
            this.label39.TabIndex = 1;
            this.label39.Text = "Cài đặt";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 966);
            this.panel1.TabIndex = 9;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(204, 4);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(1173, 966);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Quản lý thông tin chuyến bay";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(204, 4);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(1173, 966);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Quản lý lịch chuyến bay";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(204, 4);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(1173, 966);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Báo cáo doanh thu";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(204, 4);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(1173, 966);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Quy đinh chuyến bay";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 654);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.tbMenu.ResumeLayout(false);
            this.pnFlightPolicy.ResumeLayout(false);
            this.pnFlightPolicy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel pnFlightPolicy;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel1;
        private User_Control.BookTicket bookTicket1;
        private User_Control.FindFight findFight1;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.TabPage tb4;
    }
}