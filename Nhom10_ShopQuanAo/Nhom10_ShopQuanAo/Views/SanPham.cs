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
    public partial class SanPham : Form
    {
        DBConnect db = new DBConnect();
        public SanPham()
        {
            InitializeComponent();
        }
        void load_grid()
        {
            string chuoitruyvan = "select * from SanPham ";
            DataTable dt = db.getTable(chuoitruyvan);

            dgvSP.DataSource = dt;
        }

        void load_Loai()
        {
            string sql = "Select * from Loai";
            DataTable dt = db.getTable(sql);

            cboLoai.DataSource = dt;
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            load_grid();
            load_Loai();
        }
        bool ktTrungMQA(string ma)
        {
            DBConnect connect = new DBConnect();

            string chuoiTV = "select count(*) from SanPham where MaQA = '" + ma + "'";

            int kq = (int)connect.getScalar(chuoiTV);
            if (kq != 0)
                return false;
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktTrungMQA(txtMaSP.Text))
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "Insert into SanPham values ('" + txtMaSP.Text + "', N'" + txtTenSP.Text + "','" + txtSize.Text + "','" + txtGiaBan.Text + "','" + cboLoai.SelectedValue + "','"+txtSoLuong.Text+"')";

                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã thêm", "Thông báo");
                else
                    MessageBox.Show("Chưa thêm", "Thông báo");
                load_grid();
            }
            else
                MessageBox.Show("Trùng mã sản phẩm!!!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ktTrungMQA(txtMaSP.Text) == false)
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "delete SanPham where MaQA = '" + txtMaSP.Text + "'";

                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã Xóa", "Thông báo");
                else
                    MessageBox.Show("Chưa Xóa", "Thông báo");
                load_grid();
            }
            else
                MessageBox.Show("Không có sản phẩm có mã sản phẩm này!!!", "Thông báo");
        }

        //Chưa xong

        string auto_TaoMa()
        {

            DBConnect connect = new DBConnect();
            string Ma = "SP";
            string chuoiTV = "select top 1 * from SanPham where MaSP like '" + Ma + "%' order by MaKH desc";
            DataTable dt = connect.getTable(chuoiTV);

            if (dt.Rows.Count == 0)
            {
                Ma = Ma + "001";
            }
            else
            {
                string sttmax = dt.Rows[0]["MaKH"].ToString();
                int stt = int.Parse(sttmax.Substring(10, 1) + 1);
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

        private void btnTaoMa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ktTrungMQA(txtMaSP.Text) == false)
            {
                DBConnect connect = new DBConnect();
                string chuoiTV = "update SanPham set TenQA = N'" + txtTenSP.Text + "', Size = '" + txtSize.Text + "', GiaBan = '" + txtGiaBan.Text + "', MaLoai = '" + cboLoai.SelectedValue + "', SoLuong ='"+txtSoLuong.Text+"' where MaQA = '"+ txtMaSP.Text +"'";
                int kq = connect.getNonQuery(chuoiTV);

                if (kq == 1)
                    MessageBox.Show("Đã Sửa", "Thông báo");
                else
                    MessageBox.Show("Chưa Sửa", "Thông báo");
                load_grid();
            }
            else
                MessageBox.Show("Không có sản phẩm có mã sản phẩm này!!!", "Thông báo");
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không phải là hàng tiêu đề
            if (e.RowIndex >= 0 && e.RowIndex < dgvSP.Rows.Count)
            {
                DataGridViewRow row = dgvSP.Rows[e.RowIndex];

                txtMaSP.Text = GetValueFromCell(row, 0);
                txtTenSP.Text = GetValueFromCell(row, 1);
                txtSize.Text = GetValueFromCell(row, 2);
                txtGiaBan.Text = GetValueFromCell(row, 3);
                cboLoai.SelectedValue = GetValueFromCell(row, 4);
                txtSoLuong.Text = GetValueFromCell(row, 5);
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
            string chuoiTim = "select * from SanPham where MaQA = '" + txtTimKiem.Text + "' ";
            DataTable dt = db.getTable(chuoiTim);

            dgvSP.DataSource = dt;

        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            load_grid();
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSize.Text = "";
            txtSoLuong.Text = "";
            cboLoai.Text = "";
            txtTimKiem.Text = "";
        }
    }
}
