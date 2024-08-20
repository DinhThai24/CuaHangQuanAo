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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        bool kt = false;

        string taoMaauto()
        {
            DBConnect connect = new DBConnect();
            string Ma = "PN";
            string chuoiTV = "select top 1 * from PhieuNhap where MaPN like '" + Ma + "%' order by MaPN desc";
            DataTable dt = connect.getTable(chuoiTV);
            if (dt.Rows.Count == 0)
            {
                Ma = Ma + "001";
            }
            else
            {
                string sttmax = dt.Rows[0]["MaPN"].ToString();
                int stt = int.Parse(sttmax.Substring(2, 3)) + 1;
                if (stt < 10)
                {
                    Ma = Ma + "00" + stt;
                }
                else if (stt < 100)
                {
                    Ma = Ma + "0" + stt;
                }
                else
                    Ma = Ma + stt;
            }
            return Ma;
        }
        void load_cboNV()
        {
            string sql = "Select * from NhanVien";
            DataTable dt = db.getTable(sql);
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";
        }
        void load_cboSP()
        {
            string sql = "Select * from SanPham";
            DataTable dt = db.getTable(sql);
            cboTenSP.DataSource = dt;
            cboTenSP.DisplayMember = "TenQA";
            cboTenSP.ValueMember = "MaQA";
        }
        void load_gird()
        {
            DataTable dtgr = new DataTable();
            dtgr.Columns.Add("MaPN");
            dtgr.Columns.Add("MaQA");
            dtgr.Columns.Add("SoLuong");
            dtgr.Columns.Add("GiaNhap");
            dataGridView1.DataSource = dtgr;
        }
        void load_cboPN()
        {
            string sql = "Select * from PhieuNhap";
            DataTable dt = db.getTable(sql);
            cboMaPN.DataSource = dt;
            cboMaPN.DisplayMember = "MaPN";
            cboMaPN.ValueMember = "MaPN";
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            load_cboNV();
            load_cboSP();
            load_cboPN();
            kt = true;
            load_gird();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
          
                string maPN = cboMaPN.SelectedValue.ToString();
                string maQA = cboTenSP.SelectedValue.ToString(); // Giả sử dữ liệu đã được điền vào ComboBox
                string soLuong = txtSoLuong.Text;
                string giaBan = txtGiaNhap.Text;

                // Thêm dữ liệu vào DataTable
                DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();
                newRow["MaPN"] = maPN;
                newRow["MaQA"] = maQA;
                newRow["SoLuong"] = soLuong;
                newRow["GiaNhap"] = giaBan;

                ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);
                string chuoitv = "INSERT INTO ChiTietPN values ('" + cboMaPN.SelectedValue + "','" + cboTenSP.SelectedValue + "','" + txtSoLuong.Text + "','" + txtGiaNhap.Text + "')";
                int kq = db.getNonQuery(chuoitv);
                if (kq != 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
                txtTongTien.Text = CalculateTotalPrice().ToString();
           

        }
        float CalculateTotalPrice()
        {
            float total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {

                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    float giaBan = float.Parse(row.Cells["GiaNhap"].Value.ToString());

                    float tongTien = soLuong * giaBan;
                    total += tongTien;
                }
            }

            return total;
        }

        private void btnTaoMaPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = taoMaauto();
            string chuoiTV = "INSERT INTO PhieuNhap (MaPN) values ('" + txtMaPN.Text + "')";
            db.getNonQuery(chuoiTV);
            load_cboPN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy index của dòng được chọn
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Xóa dòng tương ứng trong DataTable
                ((DataTable)dataGridView1.DataSource).Rows.RemoveAt(rowIndex);
            }
            string chuoitv = "DELETE FROM ChiTietPN WHERE MaPN = '" + cboMaPN.SelectedValue + "' AND MaQA = '" + cboTenSP.SelectedValue + "'";
            int kq = db.getNonQuery(chuoitv);
            if (kq != 1)
                MessageBox.Show("Không xóa được");
            else
                MessageBox.Show("Đã xóa");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy index của dòng được chọn
                int rowIndex = e.RowIndex;

                // Chọn dòng trong DataGridView
                dataGridView1.Rows[rowIndex].Selected = true;

                cboTenSP.SelectedValue = dataGridView1.Rows[rowIndex].Cells["MaQA"].Value.ToString();
                txtSoLuong.Text = dataGridView1.Rows[rowIndex].Cells["SoLuong"].Value.ToString();
                txtGiaNhap.Text = dataGridView1.Rows[rowIndex].Cells["GiaNhap"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy index của dòng được chọn
                int rowIndex = dataGridView1.SelectedRows[0].Index;


                // Thay thế giá trị SoLuong trong cột của dòng được chọn
                dataGridView1.Rows[rowIndex].Cells["SoLuong"].Value = txtSoLuong.Text;
                dataGridView1.Rows[rowIndex].Cells["GiaNhap"].Value = txtGiaNhap.Text;
            }
            string chuoitv = "Update chitietPN set soluong = '" + txtSoLuong.Text + "', GiaNhap = '"+txtGiaNhap.Text+"' where maQA ='" + cboTenSP.SelectedValue + "'";
            int kq = db.getNonQuery(chuoitv);
            txtTongTien.Text = CalculateTotalPrice().ToString();
            if (kq != 1)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ngNhap = string.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value);
            string chuoiTV2 = "update PhieuNhap set MaNV ='" + cboMaNV.SelectedValue + "', NgayNhap = '" + ngNhap + "' where MaPN ='" + txtMaPN.Text + "'";
            int kq = db.getNonQuery(chuoiTV2);
            if (kq == 1)
                MessageBox.Show("Đã Thêm");
            else
                MessageBox.Show("Chưa Thêm");
            string chuoiTV3 = "update PhieuNhap set TongTien ='" + txtTongTien.Text + "' where MaPN ='" + txtMaPN.Text + "'";
            db.getNonQuery(chuoiTV3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chuoitv1 = "DELETE FROM ChiTietPN WHERE MaPN = '" + txtMaPN.Text + "'";
            int kq1 = db.getNonQuery(chuoitv1);
            if (kq1 != 1)
                MessageBox.Show("Không xóa được");
            string chuoitv2 = "DELETE FROM PhieuNhap WHERE MaPN = '" + txtMaPN.Text + "'";
            int kq2 = db.getNonQuery(chuoitv2);
            if (kq2 != 1)
                MessageBox.Show("Không xóa được");
            txtMaPN.Text = null;
            load_gird();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoiTV = "update PhieuNhap set MaNV = '" + cboMaNV.SelectedValue + "' where MaPN ='" + txtGiaNhap.Text + "'";
            int kq = db.getNonQuery(chuoiTV);
            if (kq == 1)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Chưa sửa");
        }
    }
}
