namespace ATM
{
    partial class QLChuyenTien
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KhoiTao = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_TimeChuyen = new System.Windows.Forms.DateTimePicker();
            this.txt_TKChuyen = new System.Windows.Forms.TextBox();
            this.txt_TKNhan = new System.Windows.Forms.TextBox();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(46, 329);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(204, 329);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KhoiTao
            // 
            this.btn_KhoiTao.Location = new System.Drawing.Point(566, 329);
            this.btn_KhoiTao.Name = "btn_KhoiTao";
            this.btn_KhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btn_KhoiTao.TabIndex = 2;
            this.btn_KhoiTao.Text = "Khởi tạo";
            this.btn_KhoiTao.UseVisualStyleBackColor = true;
            this.btn_KhoiTao.Click += new System.EventHandler(this.btn_KhoiTao_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(360, 329);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lí Chuyển tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian chuyển tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tài khoản chuyển tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tài khoản nhận tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền chuyển";
            // 
            // date_TimeChuyen
            // 
            this.date_TimeChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TimeChuyen.Location = new System.Drawing.Point(141, 95);
            this.date_TimeChuyen.Name = "date_TimeChuyen";
            this.date_TimeChuyen.Size = new System.Drawing.Size(138, 20);
            this.date_TimeChuyen.TabIndex = 9;
            // 
            // txt_TKChuyen
            // 
            this.txt_TKChuyen.Location = new System.Drawing.Point(141, 149);
            this.txt_TKChuyen.Name = "txt_TKChuyen";
            this.txt_TKChuyen.Size = new System.Drawing.Size(138, 20);
            this.txt_TKChuyen.TabIndex = 10;
            // 
            // txt_TKNhan
            // 
            this.txt_TKNhan.Location = new System.Drawing.Point(141, 197);
            this.txt_TKNhan.Name = "txt_TKNhan";
            this.txt_TKNhan.Size = new System.Drawing.Size(138, 20);
            this.txt_TKNhan.TabIndex = 11;
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(141, 251);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(138, 20);
            this.txt_SoTien.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 176);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QLChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.txt_TKNhan);
            this.Controls.Add(this.txt_TKChuyen);
            this.Controls.Add(this.date_TimeChuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_KhoiTao);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Name = "QLChuyenTien";
            this.Text = "QLChuyenTien";
            this.Load += new System.EventHandler(this.QLChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KhoiTao;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_TimeChuyen;
        private System.Windows.Forms.TextBox txt_TKChuyen;
        private System.Windows.Forms.TextBox txt_TKNhan;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}