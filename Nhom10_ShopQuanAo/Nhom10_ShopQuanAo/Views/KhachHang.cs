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
    public partial class KhachHang : Form
    {
        DBConnect db = new DBConnect();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            load_GridViewKH();
        }


        void load_GridViewKH()
        {
            string chuoitruyvan = "select * from KhachHang ";
            DataTable dt = db.getTable(chuoitruyvan);

            dataGridView1.DataSource = dt;
        }

        bool ktTrungMKH(string ma)
        {
            DBConnect connect = new DBConnect();

            string chuoiTV = "select count(*) from KhachHang where MaKH = '" + ma + "'";

            int kq = (int)connect.getScalar(chuoiTV);
            if (kq != 0)
                return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktTrungMKH(txtMaKH.Text))
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "Insert into KhachHang values ('" + txtMaKH.Text + "', N'" + txtTenKH.Text + "','" + txtSDT.Text + "','" + txtDiaChi.Text + "','" + txtEmail.Text + "')";

                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã thêm", "Thông báo");
                else
                    MessageBox.Show("Chưa thêm", "Thông báo");
                load_GridViewKH();
            }
            else
                MessageBox.Show("Trùng mã khách hàng!!!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ktTrungMKH(txtMaKH.Text) == false)
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "delete KhachHang where MaKH = '" + txtMaKH.Text + "'";

                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã Xóa", "Thông báo");
                else
                    MessageBox.Show("Chưa Xóa", "Thông báo");
                load_GridViewKH();
            }
            else
                MessageBox.Show("Không có sản phẩm có mã khách hàng này!!!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ktTrungMKH(txtMaKH.Text) == false)
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "update KhachHang set TenKH = N'" + txtTenKH.Text + "', SDT = '" + txtSDT.Text + "', DiaChi = '" + txtDiaChi.Text + "',Email ='" + txtEmail.Text + "' where MaKH = '" + txtMaKH.Text + "'";
                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã Sửa", "Thông báo");
                else
                    MessageBox.Show("Chưa Sửa", "Thông báo");
                load_GridViewKH();
            }
            else
                MessageBox.Show("Không có khách hàng có mã khách hàng này!!!", "Thông báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaKH.Text = GetValueFromCell(row, 0);
                txtTenKH.Text = GetValueFromCell(row, 1);
                txtSDT.Text = GetValueFromCell(row, 2);
                txtDiaChi.Text = GetValueFromCell(row, 3);
                txtEmail.Text = GetValueFromCell(row, 4);
            }
        }

        private string GetValueFromCell(DataGridViewRow row, int cellIndex)
        {
            if (row.Cells[cellIndex].Value != null && row.Cells[cellIndex].Value != DBNull.Value)
            {
                string value = row.Cells[cellIndex].Value.ToString().Trim(); // Loại bỏ khoảng trắng đầu cuối
                if (!string.IsNullOrWhiteSpace(value)) // Kiểm tra giá trị không phải là khoảng trắng hoặc giá trị không mong muốn khác
                {
                    return value;
                }
            }
            return string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chuoiTim = "select * from KhachHang where MaKH = '"+txtTimKiem.Text+"' ";
            DataTable dt = db.getTable(chuoiTim);

            dataGridView1.DataSource = dt;

        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            load_GridViewKH();
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";
        }
    }
}
