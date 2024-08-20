namespace Nhom10_ShopQuanAo.Views
{
    partial class PhieuNhap
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaPN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMaPN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(923, 211);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 36);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(705, 212);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(498, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 38);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 250);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(445, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(180, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(138, 85);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(169, 22);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(445, 31);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(180, 24);
            this.cboTenSP.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số Lượng";
            // 
            // cboMaPN
            // 
            this.cboMaPN.FormattingEnabled = true;
            this.cboMaPN.Location = new System.Drawing.Point(138, 34);
            this.cboMaPN.Name = "cboMaPN";
            this.cboMaPN.Size = new System.Drawing.Size(169, 24);
            this.cboMaPN.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá Nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.cboTenSP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboMaPN);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(426, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 120);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(149, 72);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(172, 24);
            this.cboMaNV.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(150, 152);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(171, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(150, 31);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(124, 22);
            this.txtMaPN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMaPN);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 234);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Nhập";
            // 
            // btnTaoMaPN
            // 
            this.btnTaoMaPN.Location = new System.Drawing.Point(294, 21);
            this.btnTaoMaPN.Name = "btnTaoMaPN";
            this.btnTaoMaPN.Size = new System.Drawing.Size(76, 38);
            this.btnTaoMaPN.TabIndex = 21;
            this.btnTaoMaPN.Text = "Tạo";
            this.btnTaoMaPN.UseVisualStyleBackColor = true;
            this.btnTaoMaPN.Click += new System.EventHandler(this.btnTaoMaPN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sửa phiếu nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Xóa phiếu nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Thêm phiếu nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMaPN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMaPN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}