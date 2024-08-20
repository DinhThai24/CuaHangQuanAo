using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10_ShopQuanAo.Views
{
    public partial class SanPhamKH : Form
    {
        public SanPhamKH()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        void loadgridSP()
        {
            string chuoitv = "select MaQA, TenQA, Size, GiaBan from SanPham";
            DataTable dt = db.getTable(chuoitv);
            dataGridView1.DataSource = dt;
        }

        DataTable dtSelectedProducts = new DataTable();
        private void loadGridSPDaChon()
        {
            DataTable dtgr = new DataTable();
            dtgr.Columns.Add("TenQA");
            dtgr.Columns.Add("Size");
            dtgr.Columns.Add("GiaBan");
            dataGridView2.DataSource = dtgr;
            dtSelectedProducts = dtgr.Clone();
        }  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maQA = dataGridView1.CurrentRow.Cells["MaQA"].Value.ToString();
            string tenQA = dataGridView1.CurrentRow.Cells["TenQA"].Value.ToString();
            string size = dataGridView1.CurrentRow.Cells["Size"].Value.ToString();
            string giaBan = dataGridView1.CurrentRow.Cells["GiaBan"].Value.ToString();

            // Thêm thông tin sản phẩm vào DataTable dtSelectedProducts
            dtSelectedProducts.Rows.Add(tenQA, size, giaBan);
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dtSelectedProducts;

        }
        private void SanPhamKH_Load(object sender, EventArgs e)
        {
            loadgridSP();
            loadGridSPDaChon();
        }
    }
}
