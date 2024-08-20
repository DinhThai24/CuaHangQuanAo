namespace Nhom10_ShopQuanAo.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chboHienMK = new System.Windows.Forms.CheckBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-5, -112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 568);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Controls.Add(this.chboHienMK);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Controls.Add(this.txtTK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(422, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 462);
            this.panel2.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(104, 365);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(148, 36);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chboHienMK
            // 
            this.chboHienMK.AutoSize = true;
            this.chboHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboHienMK.Location = new System.Drawing.Point(25, 309);
            this.chboHienMK.Name = "chboHienMK";
            this.chboHienMK.Size = new System.Drawing.Size(162, 24);
            this.chboHienMK.TabIndex = 2;
            this.chboHienMK.Text = "Hiện thị mật khẩu";
            this.chboHienMK.UseVisualStyleBackColor = true;
            this.chboHienMK.CheckedChanged += new System.EventHandler(this.chboHienMK_CheckedChanged);
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(130, 259);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(190, 26);
            this.txtMK.TabIndex = 1;
            this.txtMK.Leave += new System.EventHandler(this.txtMK_Leave);
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(130, 204);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(190, 26);
            this.txtTK.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chboHienMK;
    }
}