namespace Nhom10_ShopQuanAo.Views
{
    partial class SanPhamKH
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMua = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(368, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(139, 41);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(194, 22);
            this.txtTimKiem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(718, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(428, 347);
            this.dataGridView2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sản phẩm đã chọn";
            // 
            // btnMua
            // 
            this.btnMua.Location = new System.Drawing.Point(301, 470);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(107, 29);
            this.btnMua.TabIndex = 12;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(861, 470);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(107, 29);
            this.btnDatHang.TabIndex = 13;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            // 
            // SanPhamKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 530);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SanPhamKH";
            this.Text = "SanPhamKH";
            this.Load += new System.EventHandler(this.SanPhamKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Button btnDatHang;
    }
}