namespace ATM
{
    partial class User
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
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.btn_ThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.btn_RutTien = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btn_LichSu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaiKhoan.Location = new System.Drawing.Point(98, 22);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(0, 25);
            this.labelTaiKhoan.TabIndex = 0;
            // 
            // btn_ThongTinTaiKhoan
            // 
            this.btn_ThongTinTaiKhoan.Location = new System.Drawing.Point(46, 65);
            this.btn_ThongTinTaiKhoan.Name = "btn_ThongTinTaiKhoan";
            this.btn_ThongTinTaiKhoan.Size = new System.Drawing.Size(102, 39);
            this.btn_ThongTinTaiKhoan.TabIndex = 1;
            this.btn_ThongTinTaiKhoan.Text = "Thông Tin TK";
            this.btn_ThongTinTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_ThongTinTaiKhoan.Click += new System.EventHandler(this.btn_ThongTinTaiKhoan_Click);
            // 
            // btn_RutTien
            // 
            this.btn_RutTien.Location = new System.Drawing.Point(196, 64);
            this.btn_RutTien.Name = "btn_RutTien";
            this.btn_RutTien.Size = new System.Drawing.Size(99, 40);
            this.btn_RutTien.TabIndex = 2;
            this.btn_RutTien.Text = "Rút Tiền";
            this.btn_RutTien.UseVisualStyleBackColor = true;
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Location = new System.Drawing.Point(46, 134);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(102, 39);
            this.btnChuyenTien.TabIndex = 3;
            this.btnChuyenTien.Text = "Chuyển Tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            // 
            // btn_LichSu
            // 
            this.btn_LichSu.Location = new System.Drawing.Point(196, 133);
            this.btn_LichSu.Name = "btn_LichSu";
            this.btn_LichSu.Size = new System.Drawing.Size(99, 40);
            this.btn_LichSu.TabIndex = 4;
            this.btn_LichSu.Text = "Xem lịch sử";
            this.btn_LichSu.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(126, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 296);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_LichSu);
            this.Controls.Add(this.btnChuyenTien);
            this.Controls.Add(this.btn_RutTien);
            this.Controls.Add(this.btn_ThongTinTaiKhoan);
            this.Controls.Add(this.labelTaiKhoan);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.Button btn_ThongTinTaiKhoan;
        private System.Windows.Forms.Button btn_RutTien;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Button btn_LichSu;
        private System.Windows.Forms.Button button5;
    }
}