namespace ATM
{
    partial class Nap_Tien_Tai_Khoan
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
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nạp Tiền Tài Khoản";
            // 
            // btn_50
            // 
            this.btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.Location = new System.Drawing.Point(52, 94);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(124, 51);
            this.btn_50.TabIndex = 1;
            this.btn_50.Text = "50.000";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_500
            // 
            this.btn_500.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_500.Location = new System.Drawing.Point(300, 202);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(124, 51);
            this.btn_500.TabIndex = 2;
            this.btn_500.Text = "500.000";
            this.btn_500.UseVisualStyleBackColor = true;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_200
            // 
            this.btn_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_200.Location = new System.Drawing.Point(52, 202);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(124, 51);
            this.btn_200.TabIndex = 3;
            this.btn_200.Text = "200.000";
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_100
            // 
            this.btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.Location = new System.Drawing.Point(300, 94);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(124, 51);
            this.btn_100.TabIndex = 4;
            this.btn_100.Text = "100.000";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Blue;
            this.btn_Back.Location = new System.Drawing.Point(185, 306);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(124, 51);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Nap_Tien_Tai_Khoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 388);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_200);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.label1);
            this.Name = "Nap_Tien_Tai_Khoan";
            this.Text = "Nap_Tien_Tai_Khoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_200;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_Back;
    }
}