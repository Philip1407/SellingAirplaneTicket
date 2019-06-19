namespace SellAirplaneTicketManagement.UI
{
    partial class Add_EditFightInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHangHangKhong = new System.Windows.Forms.TextBox();
            this.txtDiemKhoiHanh = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.txtSoLuongKhach = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng hàng không";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm khởi hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng khách tối đa";
            // 
            // txtHangHangKhong
            // 
            this.txtHangHangKhong.Location = new System.Drawing.Point(234, 12);
            this.txtHangHangKhong.Name = "txtHangHangKhong";
            this.txtHangHangKhong.Size = new System.Drawing.Size(375, 30);
            this.txtHangHangKhong.TabIndex = 4;
            // 
            // txtDiemKhoiHanh
            // 
            this.txtDiemKhoiHanh.Location = new System.Drawing.Point(234, 62);
            this.txtDiemKhoiHanh.Name = "txtDiemKhoiHanh";
            this.txtDiemKhoiHanh.Size = new System.Drawing.Size(375, 30);
            this.txtDiemKhoiHanh.TabIndex = 5;
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Location = new System.Drawing.Point(234, 120);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(375, 30);
            this.txtDiemDen.TabIndex = 6;
            // 
            // txtSoLuongKhach
            // 
            this.txtSoLuongKhach.Location = new System.Drawing.Point(234, 177);
            this.txtSoLuongKhach.Name = "txtSoLuongKhach";
            this.txtSoLuongKhach.Size = new System.Drawing.Size(375, 30);
            this.txtSoLuongKhach.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(117, 243);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 47);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 47);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Add_EditFightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 323);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtSoLuongKhach);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemKhoiHanh);
            this.Controls.Add(this.txtHangHangKhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_EditFightInfo";
            this.Text = "Thêm thông tin chuyến bay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHangHangKhong;
        private System.Windows.Forms.TextBox txtDiemKhoiHanh;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtSoLuongKhach;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}