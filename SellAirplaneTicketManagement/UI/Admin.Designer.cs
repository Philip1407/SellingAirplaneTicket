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
            this.tb1 = new System.Windows.Forms.TabPage();
            this.ucFightInfo = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.ucFightSchedule = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.renevueReport1 = new SellAirplaneTicketManagement.User_Control.RenevueReport();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.EmployeeInfo = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb5 = new System.Windows.Forms.TabPage();
            this.ucEmployeeSchedule = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb6 = new System.Windows.Forms.TabPage();
            this.checkTransaction1 = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb7 = new System.Windows.Forms.TabPage();
            this.ucAdminInfo1 = new SellAirplaneTicketManagement.ucAdminInfo();
            this.pnFlightPolicy = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookTicket1 = new SellAirplaneTicketManagement.User_Control.BookTicket();
            this.findFight1 = new SellAirplaneTicketManagement.User_Control.FindFight();
            this.tb8 = new System.Windows.Forms.TabPage();
            this.CheckCustomerInfo = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tbMenu.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.tb3.SuspendLayout();
            this.tb4.SuspendLayout();
            this.tb5.SuspendLayout();
            this.tb6.SuspendLayout();
            this.tb7.SuspendLayout();
            this.pnFlightPolicy.SuspendLayout();
            this.tb8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbMenu.Controls.Add(this.tb1);
            this.tbMenu.Controls.Add(this.tb2);
            this.tbMenu.Controls.Add(this.tb3);
            this.tbMenu.Controls.Add(this.tb4);
            this.tbMenu.Controls.Add(this.tb5);
            this.tbMenu.Controls.Add(this.tb6);
            this.tbMenu.Controls.Add(this.tb7);
            this.tbMenu.Controls.Add(this.tb8);
            this.tbMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbMenu.ItemSize = new System.Drawing.Size(75, 200);
            this.tbMenu.Location = new System.Drawing.Point(3, 5);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(5);
            this.tbMenu.Multiline = true;
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(1381, 652);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbMenu_DrawItem);
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.ucFightInfo);
            this.tb1.Location = new System.Drawing.Point(204, 4);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(1173, 644);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Quản lý thông tin chuyến bay";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // ucFightInfo
            // 
            this.ucFightInfo.AddEnable = true;
            this.ucFightInfo.DeleteEnable = true;
            this.ucFightInfo.EditEnable = true;
            this.ucFightInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFightInfo.Location = new System.Drawing.Point(0, 0);
            this.ucFightInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucFightInfo.Name = "ucFightInfo";
            this.ucFightInfo.Size = new System.Drawing.Size(1173, 640);
            this.ucFightInfo.TabIndex = 0;
            this.ucFightInfo.Title = "THÔNG TIN CÁC CHUYẾN BAY";
            this.ucFightInfo.AddClick += new System.EventHandler(this.ucFightInfo_AddClick);
            this.ucFightInfo.EditClick += new System.EventHandler(this.ucFightInfo_EditClick);
            this.ucFightInfo.DeleteClick += new System.EventHandler(this.ucFightInfo_DeleteClick);
            this.ucFightInfo.DetailClick += new System.EventHandler(this.ucFightInfo_DetailClick);
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.ucFightSchedule);
            this.tb2.Location = new System.Drawing.Point(204, 4);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(1173, 644);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Quản lý lịch chuyến bay";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // ucFightSchedule
            // 
            this.ucFightSchedule.AddEnable = true;
            this.ucFightSchedule.DeleteEnable = true;
            this.ucFightSchedule.EditEnable = true;
            this.ucFightSchedule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFightSchedule.Location = new System.Drawing.Point(5, 0);
            this.ucFightSchedule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucFightSchedule.Name = "ucFightSchedule";
            this.ucFightSchedule.Size = new System.Drawing.Size(1168, 648);
            this.ucFightSchedule.TabIndex = 0;
            this.ucFightSchedule.Title = "LỊCH CHUYẾN BAY";
            this.ucFightSchedule.AddClick += new System.EventHandler(this.ucFightSchedule_AddClick);
            this.ucFightSchedule.EditClick += new System.EventHandler(this.ucFightSchedule_EditClick);
            this.ucFightSchedule.DeleteClick += new System.EventHandler(this.ucFightSchedule_DeleteClick);
            this.ucFightSchedule.DetailClick += new System.EventHandler(this.ucFightSchedule_DetailClick);
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.renevueReport1);
            this.tb3.Location = new System.Drawing.Point(204, 4);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(1173, 644);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Báo cáo doanh thu";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // renevueReport1
            // 
            this.renevueReport1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renevueReport1.Location = new System.Drawing.Point(4, 4);
            this.renevueReport1.Margin = new System.Windows.Forms.Padding(4);
            this.renevueReport1.Name = "renevueReport1";
            this.renevueReport1.Size = new System.Drawing.Size(1165, 636);
            this.renevueReport1.TabIndex = 0;
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.EmployeeInfo);
            this.tb4.Location = new System.Drawing.Point(204, 4);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(1173, 644);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Quản lý nhân viên";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.AddEnable = true;
            this.EmployeeInfo.DeleteEnable = true;
            this.EmployeeInfo.EditEnable = false;
            this.EmployeeInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInfo.Location = new System.Drawing.Point(5, 4);
            this.EmployeeInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(1168, 636);
            this.EmployeeInfo.TabIndex = 0;
            this.EmployeeInfo.Title = "THÔNG TIN NHÂN VIÊN";
            this.EmployeeInfo.AddClick += new System.EventHandler(this.EmployeeInfo_AddClick);
            this.EmployeeInfo.EditClick += new System.EventHandler(this.EmployeeInfo_EditClick);
            this.EmployeeInfo.DeleteClick += new System.EventHandler(this.EmployeeInfo_DeleteClick);
            this.EmployeeInfo.DetailClick += new System.EventHandler(this.EmployeeInfo_DetailClick);
            // 
            // tb5
            // 
            this.tb5.Controls.Add(this.ucEmployeeSchedule);
            this.tb5.Location = new System.Drawing.Point(204, 4);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(1173, 644);
            this.tb5.TabIndex = 4;
            this.tb5.Text = "Quản lý lịch làm việc";
            this.tb5.UseVisualStyleBackColor = true;
            // 
            // ucEmployeeSchedule
            // 
            this.ucEmployeeSchedule.AddEnable = true;
            this.ucEmployeeSchedule.DeleteEnable = true;
            this.ucEmployeeSchedule.EditEnable = true;
            this.ucEmployeeSchedule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmployeeSchedule.Location = new System.Drawing.Point(2, 4);
            this.ucEmployeeSchedule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucEmployeeSchedule.Name = "ucEmployeeSchedule";
            this.ucEmployeeSchedule.Size = new System.Drawing.Size(1168, 636);
            this.ucEmployeeSchedule.TabIndex = 1;
            this.ucEmployeeSchedule.Title = "LỊCH LÀM VIỆC NHÂN VIÊN";
            this.ucEmployeeSchedule.AddClick += new System.EventHandler(this.ucEmployeeSchedule_AddClick);
            this.ucEmployeeSchedule.EditClick += new System.EventHandler(this.ucEmployeeSchedule_EditClick);
            this.ucEmployeeSchedule.DeleteClick += new System.EventHandler(this.ucEmployeeSchedule_DeleteClick);
            this.ucEmployeeSchedule.DetailClick += new System.EventHandler(this.ucEmployeeSchedule_DetailClick);
            // 
            // tb6
            // 
            this.tb6.Controls.Add(this.checkTransaction1);
            this.tb6.Location = new System.Drawing.Point(204, 4);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(1173, 644);
            this.tb6.TabIndex = 5;
            this.tb6.Text = "Tra cứu thông tin giao dịch";
            this.tb6.UseVisualStyleBackColor = true;
            // 
            // checkTransaction1
            // 
            this.checkTransaction1.AddEnable = false;
            this.checkTransaction1.DeleteEnable = false;
            this.checkTransaction1.EditEnable = false;
            this.checkTransaction1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTransaction1.Location = new System.Drawing.Point(14, 4);
            this.checkTransaction1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkTransaction1.Name = "checkTransaction1";
            this.checkTransaction1.Size = new System.Drawing.Size(1159, 636);
            this.checkTransaction1.TabIndex = 1;
            this.checkTransaction1.Title = "TRA CỨU THÔNG TIN GIAO DỊCH";
            this.checkTransaction1.DetailClick += new System.EventHandler(this.checkTransaction1_DetailClick);
            // 
            // tb7
            // 
            this.tb7.Controls.Add(this.ucAdminInfo1);
            this.tb7.Location = new System.Drawing.Point(204, 4);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(1173, 644);
            this.tb7.TabIndex = 6;
            this.tb7.Text = "Thông tin tài khoản";
            this.tb7.UseVisualStyleBackColor = true;
            // 
            // ucAdminInfo1
            // 
            this.ucAdminInfo1.BackColor = System.Drawing.SystemColors.Window;
            this.ucAdminInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAdminInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdminInfo1.Location = new System.Drawing.Point(272, 57);
            this.ucAdminInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucAdminInfo1.Name = "ucAdminInfo1";
            this.ucAdminInfo1.Size = new System.Drawing.Size(592, 541);
            this.ucAdminInfo1.TabIndex = 0;
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
            // bookTicket1
            // 
            this.bookTicket1.AddCustomer = true;
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
            // tb8
            // 
            this.tb8.Controls.Add(this.CheckCustomerInfo);
            this.tb8.Location = new System.Drawing.Point(204, 4);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(1173, 644);
            this.tb8.TabIndex = 7;
            this.tb8.Text = "Xem danh sách khách hàng";
            this.tb8.UseVisualStyleBackColor = true;
            // 
            // CheckCustomerInfo
            // 
            this.CheckCustomerInfo.AddEnable = false;
            this.CheckCustomerInfo.DeleteEnable = false;
            this.CheckCustomerInfo.EditEnable = false;
            this.CheckCustomerInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCustomerInfo.Location = new System.Drawing.Point(5, 4);
            this.CheckCustomerInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CheckCustomerInfo.Name = "CheckCustomerInfo";
            this.CheckCustomerInfo.Size = new System.Drawing.Size(1163, 640);
            this.CheckCustomerInfo.TabIndex = 0;
            this.CheckCustomerInfo.Title = "XEM THÔNG TIN KHÁCH HÀNG";
            this.CheckCustomerInfo.DetailClick += new System.EventHandler(this.CheckCustomerInfo_DetailClick);
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 654);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.tbMenu.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.tb3.ResumeLayout(false);
            this.tb4.ResumeLayout(false);
            this.tb5.ResumeLayout(false);
            this.tb6.ResumeLayout(false);
            this.tb7.ResumeLayout(false);
            this.pnFlightPolicy.ResumeLayout(false);
            this.pnFlightPolicy.PerformLayout();
            this.tb8.ResumeLayout(false);
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
        private User_Control.RenevueReport renevueReport1;
        private User_Control.CheckTransaction ucFightInfo;
        private System.Windows.Forms.TabPage tb4;
        private User_Control.CheckTransaction EmployeeInfo;
        private System.Windows.Forms.TabPage tb5;
        private User_Control.CheckTransaction ucEmployeeSchedule;
        private User_Control.CheckTransaction ucFightSchedule;
        private System.Windows.Forms.TabPage tb6;
        private User_Control.CheckTransaction checkTransaction1;
        private System.Windows.Forms.TabPage tb7;
        private ucAdminInfo ucAdminInfo1;
        private System.Windows.Forms.TabPage tb8;
        private User_Control.CheckTransaction CheckCustomerInfo;
    }
}