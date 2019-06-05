namespace SellAirplaneTicketManagement
{
    partial class Customer
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
            this.tb3 = new System.Windows.Forms.TabPage();
            this.checkTransaction1 = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.ucUserInfo1 = new SellAirplaneTicketManagement.ucUserInfo();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.checkTransaction2 = new SellAirplaneTicketManagement.User_Control.CheckTransaction();
            this.tbMenu.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb3.SuspendLayout();
            this.tb4.SuspendLayout();
            this.tb2.SuspendLayout();
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
            this.tbMenu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbMenu.ItemSize = new System.Drawing.Size(75, 200);
            this.tbMenu.Location = new System.Drawing.Point(0, 1);
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
            this.tb1.Controls.Add(this.bookTicket1);
            this.tb1.Location = new System.Drawing.Point(204, 4);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(1173, 644);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Đặt vé chuyến bay";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // bookTicket1
            // 
            this.bookTicket1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicket1.Location = new System.Drawing.Point(0, 0);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(1253, 495);
            this.bookTicket1.TabIndex = 0;
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.checkTransaction1);
            this.tb3.Location = new System.Drawing.Point(204, 4);
            this.tb3.Name = "tb3";
            this.tb3.Padding = new System.Windows.Forms.Padding(3);
            this.tb3.Size = new System.Drawing.Size(1173, 644);
            this.tb3.TabIndex = 1;
            this.tb3.Text = "Xem lịch sử giao dịch";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // checkTransaction1
            // 
            this.checkTransaction1.AddEnable = true;
            this.checkTransaction1.DeleteEnable = true;
            this.checkTransaction1.EditEnable = true;
            this.checkTransaction1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTransaction1.Location = new System.Drawing.Point(0, 4);
            this.checkTransaction1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkTransaction1.Name = "checkTransaction1";
            this.checkTransaction1.Size = new System.Drawing.Size(1110, 559);
            this.checkTransaction1.TabIndex = 0;
            this.checkTransaction1.Title = "TRA CỨU THÔNG TIN GIAO DỊCH";
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.ucUserInfo1);
            this.tb4.Location = new System.Drawing.Point(204, 4);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(1173, 644);
            this.tb4.TabIndex = 2;
            this.tb4.Text = "Thông tin tài khoản";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.BackColor = System.Drawing.SystemColors.Window;
            this.ucUserInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUserInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUserInfo1.Location = new System.Drawing.Point(136, 53);
            this.ucUserInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(608, 536);
            this.ucUserInfo1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.checkTransaction2);
            this.tb2.Location = new System.Drawing.Point(204, 4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(1173, 644);
            this.tb2.TabIndex = 3;
            this.tb2.Text = "DANH SÁCH VÉ ";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // checkTransaction2
            // 
            this.checkTransaction2.AddEnable = false;
            this.checkTransaction2.DeleteEnable = false;
            this.checkTransaction2.EditEnable = false;
            this.checkTransaction2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTransaction2.Location = new System.Drawing.Point(0, 0);
            this.checkTransaction2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkTransaction2.Name = "checkTransaction2";
            this.checkTransaction2.Size = new System.Drawing.Size(1110, 559);
            this.checkTransaction2.TabIndex = 0;
            this.checkTransaction2.Title = "DANH SÁCH VÉ ";
            // 
            // Customer
            // 
            this.ClientSize = new System.Drawing.Size(1370, 654);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Customer";
            this.tbMenu.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb3.ResumeLayout(false);
            this.tb4.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb3;
        private User_Control.BookTicket bookTicket1;
        private User_Control.CheckTransaction checkTransaction1;
        private System.Windows.Forms.TabPage tb4;
        private ucUserInfo ucUserInfo1;
        private System.Windows.Forms.TabPage tb2;
        private User_Control.CheckTransaction checkTransaction2;
    }
}