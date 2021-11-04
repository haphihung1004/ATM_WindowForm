namespace ATM
{
    partial class QLNhanTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_NhanTien = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_KhoiTao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TKNhan = new System.Windows.Forms.TextBox();
            this.txt_TKChuyen = new System.Windows.Forms.TextBox();
            this.txt_SoTienNhan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian nhận tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "tài khoản nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản chuyển :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền nhận :";
            // 
            // date_NhanTien
            // 
            this.date_NhanTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NhanTien.Location = new System.Drawing.Point(130, 90);
            this.date_NhanTien.Name = "date_NhanTien";
            this.date_NhanTien.Size = new System.Drawing.Size(160, 20);
            this.date_NhanTien.TabIndex = 5;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(30, 305);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(215, 305);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(411, 305);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_KhoiTao
            // 
            this.btn_KhoiTao.Location = new System.Drawing.Point(620, 305);
            this.btn_KhoiTao.Name = "btn_KhoiTao";
            this.btn_KhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btn_KhoiTao.TabIndex = 9;
            this.btn_KhoiTao.Text = "Khởi Tạo";
            this.btn_KhoiTao.UseVisualStyleBackColor = true;
            this.btn_KhoiTao.Click += new System.EventHandler(this.btn_KhoiTao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 178);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_TKNhan
            // 
            this.txt_TKNhan.Location = new System.Drawing.Point(130, 144);
            this.txt_TKNhan.Name = "txt_TKNhan";
            this.txt_TKNhan.Size = new System.Drawing.Size(160, 20);
            this.txt_TKNhan.TabIndex = 11;
            // 
            // txt_TKChuyen
            // 
            this.txt_TKChuyen.Location = new System.Drawing.Point(130, 192);
            this.txt_TKChuyen.Name = "txt_TKChuyen";
            this.txt_TKChuyen.Size = new System.Drawing.Size(160, 20);
            this.txt_TKChuyen.TabIndex = 12;
            // 
            // txt_SoTienNhan
            // 
            this.txt_SoTienNhan.Location = new System.Drawing.Point(130, 240);
            this.txt_SoTienNhan.Name = "txt_SoTienNhan";
            this.txt_SoTienNhan.Size = new System.Drawing.Size(160, 20);
            this.txt_SoTienNhan.TabIndex = 13;
            // 
            // QLNhanTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 362);
            this.Controls.Add(this.txt_SoTienNhan);
            this.Controls.Add(this.txt_TKChuyen);
            this.Controls.Add(this.txt_TKNhan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_KhoiTao);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.date_NhanTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLNhanTien";
            this.Text = "QLNhanTien";
            this.Load += new System.EventHandler(this.QLNhanTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_NhanTien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_KhoiTao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_TKNhan;
        private System.Windows.Forms.TextBox txt_TKChuyen;
        private System.Windows.Forms.TextBox txt_SoTienNhan;
    }
}