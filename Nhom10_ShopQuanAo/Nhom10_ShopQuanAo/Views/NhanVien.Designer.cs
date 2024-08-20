namespace Nhom10_ShopQuanAo.Views
{
    partial class NhanVien
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grKH = new System.Windows.Forms.GroupBox();
            this.txtMauKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.grKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(830, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 36);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(450, 149);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(217, 146);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(194, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tim kiếm";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(542, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(155, 105);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(183, 22);
            this.txtTK.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(155, 66);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(542, 35);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(183, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(830, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 38);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(37, 241);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(911, 233);
            this.dgvNV.TabIndex = 7;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(155, 32);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(183, 22);
            this.txtMaNV.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(830, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Tài Khoản";
            // 
            // grKH
            // 
            this.grKH.Controls.Add(this.btnTimKiem);
            this.grKH.Controls.Add(this.txtTimKiem);
            this.grKH.Controls.Add(this.label1);
            this.grKH.Controls.Add(this.txtEmail);
            this.grKH.Controls.Add(this.txtMauKhau);
            this.grKH.Controls.Add(this.txtTK);
            this.grKH.Controls.Add(this.txtSDT);
            this.grKH.Controls.Add(this.txtTenNV);
            this.grKH.Controls.Add(this.txtMaNV);
            this.grKH.Controls.Add(this.label2);
            this.grKH.Controls.Add(this.label9);
            this.grKH.Controls.Add(this.label8);
            this.grKH.Controls.Add(this.label7);
            this.grKH.Controls.Add(this.label6);
            this.grKH.Controls.Add(this.label5);
            this.grKH.Location = new System.Drawing.Point(37, 11);
            this.grKH.Name = "grKH";
            this.grKH.Size = new System.Drawing.Size(769, 176);
            this.grKH.TabIndex = 6;
            this.grKH.TabStop = false;
            this.grKH.Text = "Nhân Viên";
            // 
            // txtMauKhau
            // 
            this.txtMauKhau.Location = new System.Drawing.Point(542, 105);
            this.txtMauKhau.Name = "txtMauKhau";
            this.txtMauKhau.Size = new System.Drawing.Size(183, 22);
            this.txtMauKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // btnRS
            // 
            this.btnRS.Location = new System.Drawing.Point(830, 199);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(97, 36);
            this.btnRS.TabIndex = 11;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 506);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grKH);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.grKH.ResumeLayout(false);
            this.grKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grKH;
        private System.Windows.Forms.TextBox txtMauKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRS;
    }
}