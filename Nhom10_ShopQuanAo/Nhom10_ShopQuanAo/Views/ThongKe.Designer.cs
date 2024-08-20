namespace Nhom10_ShopQuanAo.Views
{
    partial class ThongKe
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.TimeThang = new System.Windows.Forms.DateTimePicker();
            this.TimeNam = new System.Windows.Forms.DateTimePicker();
            this.TimeNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(12, 12);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(861, 339);
            this.dgvThongKe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeThang);
            this.groupBox1.Controls.Add(this.lbThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThang);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo Tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeNam);
            this.groupBox2.Controls.Add(this.lbNam);
            this.groupBox2.Controls.Add(this.btnNam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo Năm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TimeNgay);
            this.groupBox3.Controls.Add(this.lbNgay);
            this.groupBox3.Controls.Add(this.btnNgay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(14, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 58);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê theo Ngày";
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(20, 21);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(100, 31);
            this.btnThang.TabIndex = 0;
            this.btnThang.Text = "Thống kê";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(20, 21);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(100, 31);
            this.btnNam.TabIndex = 0;
            this.btnNam.Text = "Thống kê";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(18, 21);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(100, 31);
            this.btnNgay.TabIndex = 0;
            this.btnNgay.Text = "Thống kê";
            this.btnNgay.UseVisualStyleBackColor = true;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(412, 27);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(14, 16);
            this.lbThang.TabIndex = 2;
            this.lbThang.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền:";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(412, 21);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(14, 16);
            this.lbNam.TabIndex = 2;
            this.lbNam.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền:";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(410, 18);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(14, 16);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "0";
            // 
            // TimeThang
            // 
            this.TimeThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeThang.Location = new System.Drawing.Point(143, 23);
            this.TimeThang.Name = "TimeThang";
            this.TimeThang.Size = new System.Drawing.Size(178, 22);
            this.TimeThang.TabIndex = 3;
            // 
            // TimeNam
            // 
            this.TimeNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeNam.Location = new System.Drawing.Point(143, 23);
            this.TimeNam.Name = "TimeNam";
            this.TimeNam.Size = new System.Drawing.Size(178, 22);
            this.TimeNam.TabIndex = 3;
            // 
            // TimeNgay
            // 
            this.TimeNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeNgay.Location = new System.Drawing.Point(141, 21);
            this.TimeNgay.Name = "TimeNgay";
            this.TimeNgay.Size = new System.Drawing.Size(178, 22);
            this.TimeNgay.TabIndex = 3;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimeThang;
        private System.Windows.Forms.DateTimePicker TimeNam;
        private System.Windows.Forms.DateTimePicker TimeNgay;
    }
}