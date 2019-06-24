namespace SellAirplaneTicketManagement
{
    partial class Form2
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
            this.logIn1 = new SellAirplaneTicketManagement.LogIn();
            this.SuspendLayout();
            // 
            // logIn1
            // 
            this.logIn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logIn1.BackColor = System.Drawing.SystemColors.Window;
            this.logIn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logIn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn1.Location = new System.Drawing.Point(359, 104);
            this.logIn1.Margin = new System.Windows.Forms.Padding(4);
            this.logIn1.Name = "logIn1";
            this.logIn1.Pass = "";
            this.logIn1.Size = new System.Drawing.Size(494, 447);
            this.logIn1.TabIndex = 3;
            this.logIn1.UserName = "";
            this.logIn1.LoginClick += new System.EventHandler(this.logIn1_LoginClick);
            
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SellAirplaneTicketManagement.Properties.Resources.Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 639);
            this.Controls.Add(this.logIn1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 625);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private LogIn logIn1;
    }
}