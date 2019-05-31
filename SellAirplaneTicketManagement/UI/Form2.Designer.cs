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
            this.forgetPassword1 = new SellAirplaneTicketManagement.ForgetPassword();
            this.signUp1 = new SellAirplaneTicketManagement.SignUp();
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
            this.logIn1.Size = new System.Drawing.Size(494, 447);
            this.logIn1.TabIndex = 3;
            this.logIn1.LoginClick += new System.EventHandler(this.logIn1_LoginClick);
            this.logIn1.ForgotPasswordClick += new System.EventHandler(this.logIn1_ForgotPasswordClick);
            this.logIn1.SignUpClick += new System.EventHandler(this.logIn1_SignUpClick);
            // 
            // forgetPassword1
            // 
            this.forgetPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgetPassword1.BackColor = System.Drawing.SystemColors.Window;
            this.forgetPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.forgetPassword1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassword1.Location = new System.Drawing.Point(352, 134);
            this.forgetPassword1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.forgetPassword1.Name = "forgetPassword1";
            this.forgetPassword1.Size = new System.Drawing.Size(502, 340);
            this.forgetPassword1.TabIndex = 2;
            this.forgetPassword1.BackClick += new System.EventHandler(this.forgetPassword1_BackClick);
            // 
            // signUp1
            // 
            this.signUp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUp1.BackColor = System.Drawing.SystemColors.Window;
            this.signUp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUp1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp1.Location = new System.Drawing.Point(278, 68);
            this.signUp1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(588, 545);
            this.signUp1.TabIndex = 0;
            this.signUp1.BackClick += new System.EventHandler(this.signUp1_BackClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SellAirplaneTicketManagement.Properties.Resources.Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 639);
            this.Controls.Add(this.logIn1);
            this.Controls.Add(this.forgetPassword1);
            this.Controls.Add(this.signUp1);
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

        private SignUp signUp1;
        private ForgetPassword forgetPassword1;
        private LogIn logIn1;
    }
}