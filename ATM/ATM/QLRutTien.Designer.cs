namespace ATM
{
    partial class QLRutTien
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KhoiTao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_RutTien = new System.Windows.Forms.DateTimePicker();
            this.txt_TKRut = new System.Windows.Forms.TextBox();
            this.txt_SoTienRut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rút Tiền";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(29, 247);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(165, 247);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(27, 299);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KhoiTao
            // 
            this.btn_KhoiTao.Location = new System.Drawing.Point(165, 299);
            this.btn_KhoiTao.Name = "btn_KhoiTao";
            this.btn_KhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btn_KhoiTao.TabIndex = 4;
            this.btn_KhoiTao.Text = "Khởi tạo";
            this.btn_KhoiTao.UseVisualStyleBackColor = true;
            this.btn_KhoiTao.Click += new System.EventHandler(this.btn_KhoiTao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 256);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thời gian rút tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tài khoản rút :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền rút :";
            // 
            // date_RutTien
            // 
            this.date_RutTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_RutTien.Location = new System.Drawing.Point(121, 80);
            this.date_RutTien.Name = "date_RutTien";
            this.date_RutTien.Size = new System.Drawing.Size(145, 20);
            this.date_RutTien.TabIndex = 9;
            // 
            // txt_TKRut
            // 
            this.txt_TKRut.Location = new System.Drawing.Point(121, 136);
            this.txt_TKRut.Name = "txt_TKRut";
            this.txt_TKRut.Size = new System.Drawing.Size(145, 20);
            this.txt_TKRut.TabIndex = 10;
            // 
            // txt_SoTienRut
            // 
            this.txt_SoTienRut.Location = new System.Drawing.Point(121, 198);
            this.txt_SoTienRut.Name = "txt_SoTienRut";
            this.txt_SoTienRut.Size = new System.Drawing.Size(145, 20);
            this.txt_SoTienRut.TabIndex = 11;
            // 
            // QLRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 378);
            this.Controls.Add(this.txt_SoTienRut);
            this.Controls.Add(this.txt_TKRut);
            this.Controls.Add(this.date_RutTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_KhoiTao);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Name = "QLRutTien";
            this.Text = "QLRutTien";
            this.Load += new System.EventHandler(this.QLRutTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KhoiTao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_RutTien;
        private System.Windows.Forms.TextBox txt_TKRut;
        private System.Windows.Forms.TextBox txt_SoTienRut;
    }
}