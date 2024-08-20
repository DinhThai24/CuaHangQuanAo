namespace Nhom10_ShopQuanAo.Views
{
    partial class frmHoaDon
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTaoMaHD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(445, 27);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(171, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(150, 113);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(171, 22);
            this.txtTenKH.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 154);
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
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(150, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 22);
            this.txtMaHD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Hóa Đơn";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(497, 520);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(97, 38);
            this.btnXoaHD.TabIndex = 24;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(322, 520);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(97, 38);
            this.btnInHD.TabIndex = 23;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(922, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 36);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(704, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(497, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 38);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 250);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.cboTenSP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(425, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 120);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(445, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(180, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(138, 85);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(169, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(138, 30);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(180, 24);
            this.cboTenSP.TabIndex = 2;
            this.cboTenSP.SelectedIndexChanged += new System.EventHandler(this.cboTenSP_SelectedIndexChanged);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền";
            // 
            // btnTaoMaHD
            // 
            this.btnTaoMaHD.Location = new System.Drawing.Point(277, 25);
            this.btnTaoMaHD.Name = "btnTaoMaHD";
            this.btnTaoMaHD.Size = new System.Drawing.Size(76, 38);
            this.btnTaoMaHD.TabIndex = 13;
            this.btnTaoMaHD.Text = "Tạo";
            this.btnTaoMaHD.UseVisualStyleBackColor = true;
            this.btnTaoMaHD.Click += new System.EventHandler(this.btnTaoMaHD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMaHD);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 234);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(674, 520);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(97, 38);
            this.btnSuaHD.TabIndex = 25;
            this.btnSuaHD.Text = "Sửa hóa đơn";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 583);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTaoMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaHD;
    }
}