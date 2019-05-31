namespace SellAirplaneTicketManagement
{
    partial class Form1
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
            this.tb2 = new System.Windows.Forms.TabPage();
            this.tbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbMenu.Controls.Add(this.tb1);
            this.tbMenu.Controls.Add(this.tb2);
            this.tbMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbMenu.ItemSize = new System.Drawing.Size(75, 200);
            this.tbMenu.Location = new System.Drawing.Point(3, 2);
            this.tbMenu.Multiline = true;
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(1519, 794);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbMenu_DrawItem);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(204, 4);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(1311, 786);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Đặt vé chuyến bay";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(204, 4);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(1311, 786);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Lịch sử giao dịch";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 654);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
    }
}

