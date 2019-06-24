namespace SellAirplaneTicketManagement
{
    partial class Form3
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
            this.bookTicket1 = new SellAirplaneTicketManagement.User_Control.BookTicket();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.findFight1 = new SellAirplaneTicketManagement.User_Control.FindFight();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.checkTransaction1 = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.ucEmployeeInfo1 = new SellAirplaneTicketManagement.ucEmployeeInfo();
            this.tbMenu.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.tb3.SuspendLayout();
            this.tb4.SuspendLayout();
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
            this.tbMenu.Size = new System.Drawing.Size(1364, 974);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbMenu_DrawItem);
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.bookTicket1);
            this.tb1.Location = new System.Drawing.Point(204, 4);
            this.tb1.Margin = new System.Windows.Forms.Padding(5);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(5);
            this.tb1.Size = new System.Drawing.Size(1156, 966);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Đặt vé chuyến bay";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // bookTicket1
            // 
            this.bookTicket1.Amount = 0;
            this.bookTicket1.AutoSize = true;
            this.bookTicket1.Class = "Thương gia";
            this.bookTicket1.CustomerName = "";
            this.bookTicket1.FlightID = "Thương gia";
            this.bookTicket1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicket1.IDNumber = "";
            this.bookTicket1.Location = new System.Drawing.Point(21, 21);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(1131, 476);
            this.bookTicket1.TabIndex = 0;
            this.bookTicket1.Total = "0 VND";
            this.bookTicket1.BookClick += new System.EventHandler(this.bookTicket1_BookClick);
            this.bookTicket1.AddCustomerClick += new System.EventHandler(this.bookTicket1_AddCustomerClick);
            this.bookTicket1.onAmountChange += new System.EventHandler(this.bookTicket1_onAmountChange);
            this.bookTicket1.onClassChange += new System.EventHandler(this.bookTicket1_onClassChange);
            this.bookTicket1.onFlightIDChange += new System.EventHandler(this.bookTicket1_onFlightIDChange);
            this.bookTicket1.onChangeCustomerIDNumber += new System.EventHandler(this.bookTicket1_onChangeCustomerIDNumber);
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.findFight1);
            this.tb2.Location = new System.Drawing.Point(204, 4);
            this.tb2.Margin = new System.Windows.Forms.Padding(5);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(5);
            this.tb2.Size = new System.Drawing.Size(1156, 966);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Tra cứu chuyến bay";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // findFight1
            // 
            this.findFight1.Arrive = "VietNamAirline";
            this.findFight1.Data = null;
            this.findFight1.Date = "6/24/2019";
            this.findFight1.Depart = "VietNamAirline";
            this.findFight1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFight1.Location = new System.Drawing.Point(4, 9);
            this.findFight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findFight1.Name = "findFight1";
            this.findFight1.Size = new System.Drawing.Size(1146, 606);
            this.findFight1.TabIndex = 0;
            this.findFight1.FindClick += new System.EventHandler(this.findFight1_FindClick);
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.checkTransaction1);
            this.tb3.Location = new System.Drawing.Point(204, 4);
            this.tb3.Margin = new System.Windows.Forms.Padding(5);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(1156, 966);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Lịch sử giao dịch";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // checkTransaction1
            // 
            this.checkTransaction1.AddEnable = false;
            this.checkTransaction1.Data = null;
            this.checkTransaction1.DeleteEnable = false;
            this.checkTransaction1.DetailEnable = true;
            this.checkTransaction1.EditEnable = false;
            this.checkTransaction1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTransaction1.Location = new System.Drawing.Point(37, 15);
            this.checkTransaction1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkTransaction1.Name = "checkTransaction1";
            this.checkTransaction1.Size = new System.Drawing.Size(1110, 559);
            this.checkTransaction1.TabIndex = 0;
            this.checkTransaction1.Title = "TRA CỨU THÔNG TIN GIAO DỊCH";
            this.checkTransaction1.DetailClick += new System.EventHandler(this.checkTransaction1_DetailClick);
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.ucEmployeeInfo1);
            this.tb4.Location = new System.Drawing.Point(204, 4);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(1156, 966);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Thông tin tài khoản";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // ucEmployeeInfo1
            // 
            this.ucEmployeeInfo1.Address = "";
            this.ucEmployeeInfo1.BackColor = System.Drawing.SystemColors.Window;
            this.ucEmployeeInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeInfo1.DOB = "6/22/2019";
            this.ucEmployeeInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmployeeInfo1.FullName = "";
            this.ucEmployeeInfo1.Gender = "Nam";
            this.ucEmployeeInfo1.Location = new System.Drawing.Point(257, 68);
            this.ucEmployeeInfo1.Manager = "Người quản lý";
            this.ucEmployeeInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucEmployeeInfo1.Name = "ucEmployeeInfo1";
            this.ucEmployeeInfo1.Phone = "";
            this.ucEmployeeInfo1.Size = new System.Drawing.Size(608, 536);
            this.ucEmployeeInfo1.State = "";
            this.ucEmployeeInfo1.TabIndex = 0;
            this.ucEmployeeInfo1.ExitClick += new System.EventHandler(this.ucEmployeeInfo1_ExitClick);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 654);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên bán vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.tbMenu.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            this.tb2.ResumeLayout(false);
            this.tb3.ResumeLayout(false);
            this.tb4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.TabPage tb1;
        private User_Control.BookTicket bookTicket1;
        private User_Control.FindFight findFight1;
        private User_Control.CheckTransaction checkTransaction1;
        private System.Windows.Forms.TabPage tb4;
        private ucEmployeeInfo ucEmployeeInfo1;
    }
}