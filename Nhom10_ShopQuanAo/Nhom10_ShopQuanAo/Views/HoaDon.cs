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
    public partial class frmHoaDon : Form
    {
        bool kt = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        private void btnThem_Click(object sender, EventArgs e)
        {

            string maHD = txtMaHD.Text;
            string maQA = cboTenSP.SelectedValue.ToString(); // Giả sử dữ liệu đã được điền vào ComboBox
            string soLuong = txtSoLuong.Text;
            string giaBan = txtDonGia.Text;

            // Thêm dữ liệu vào DataTable
            DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();
            newRow["MaHD"] = maHD;
            newRow["MaQA"] = maQA;
            newRow["SoLuong"] = soLuong;
            newRow["GiaBan"] = giaBan;

            ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);
            string chuoitv = "INSERT INTO ChiTietHD values ('" + txtMaHD.Text + "','" + cboTenSP.SelectedValue + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
            int kq = db.getNonQuery(chuoitv);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thành công");
            txtTongTien.Text = CalculateTotalPrice().ToString();

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
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            load_cboNV();
            load_cboSP();
            kt = true;
            load_gird();
        }

        void load_gird()
        {
            DataTable dtgr = new DataTable();
            dtgr.Columns.Add("MaHD");
            dtgr.Columns.Add("MaQA");
            dtgr.Columns.Add("SoLuong");
            dtgr.Columns.Add("GiaBan");
            dataGridView1.DataSource = dtgr;
        }
        string taoMaauto()
        {
            DBConnect connect = new DBConnect();
            string Ma = "HD";
            string chuoiTV = "select top 1 * from ChiTietHD where MAHD like '" + Ma + "%' order by MAHD desc";
            DataTable dt = connect.getTable(chuoiTV);
            if (dt.Rows.Count == 0)
            {
                Ma = Ma + "001";
            }
            else
            {
                string sttmax = dt.Rows[0]["MAHD"].ToString();
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
        string taoMaautoKH()
        {
            DBConnect connect = new DBConnect();
            string Ma = "KH";
            string chuoiTV = "select top 1 * from KhachHang where MaKH like'" + Ma + "%' order by MaKH desc";
            DataTable dt = connect.getTable(chuoiTV);
            if (dt.Rows.Count == 0)
            {
                Ma = Ma + "001";
            }
            else
            {
                string sttmax = dt.Rows[0]["MaKH"].ToString();

                int stt = int.Parse(sttmax.Substring(2, 3));
                stt = stt + 1;
                MessageBox.Show("", stt.ToString());
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
        string GetMaKHByTenKH()
        {
            string query = "SELECT MaKH FROM KhachHang WHERE TenKH = '" + txtTenKH.Text + "'";
            object kq = db.getScalar(query);

            if (kq != null)
                return kq.ToString().Trim();
            else
                return null;
        }
        string GetOrCreateMaKH()
        {
            string maKH = GetMaKHByTenKH();

            if (maKH == null)
            {
                // Tạo mã khách hàng mới
                maKH = taoMaautoKH();
                string chuoiTV = "insert into KhachHang (MaKH, TenKH) values ('" + maKH + "','" + txtTenKH.Text + "')";
                db.getNonQuery(chuoiTV);
                return maKH;
            }
            return maKH;
        }
        private void btnTaoMaHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = taoMaauto();
            string chuoiTV = "INSERT INTO HoaDon (MaHD) values ('" + txtMaHD.Text + "')";
            db.getNonQuery(chuoiTV);
        }

        void LuuChiTietHD()
        {
            string maHD = txtMaHD.Text;  // Lấy mã hóa đơn từ TextBox txtMaHD

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)  // Bỏ qua hàng mới được tạo tự động
                {
                    string maQA = row.Cells["MaQA"].Value.ToString();
                    string soLuong = row.Cells["SoLuong"].Value.ToString();
                    string giaBan = row.Cells["GiaBan"].Value.ToString();

                    string query = "INSERT INTO ChiTietHD (MaHD, MaQA, SoLuong, GiaBan) VALUES  (@maHD, @MaQA, @SoLuong, @GiaBan)";

                    int kq = db.getNonQuery(query);

                    if (kq != 1)
                    {
                        MessageBox.Show("Lưu chi tiết hóa đơn thất bại cho sản phẩm {maQA}", "Thông báo");
                        return;  // Nếu có lỗi, dừng lại và không lưu các chi tiết hóa đơn tiếp theo
                    }
                }
            }

        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            string ngLap = string.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value);
            string maKH = GetOrCreateMaKH();
            string chuoiTV2 = "update HoaDon set MaNV ='" + cboMaNV.SelectedValue + "', MAKH ='" + maKH + "', NgayLap = '" + ngLap + "' where MaHD ='" + txtMaHD.Text + "'";
            int kq = db.getNonQuery(chuoiTV2);
            if (kq == 1)
                MessageBox.Show("Đã in");
            else
                MessageBox.Show("Chưa in");
            string chuoiTV3 = "update HoaDon set TongTien ='" + txtTongTien.Text + "' where MaHD ='" + txtMaHD.Text + "'";
            db.getNonQuery(chuoiTV3);
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kt == true)
            {
                string chuoiTV = "select GiaBan from SanPham where MaQA ='" + cboTenSP.SelectedValue + "'";
                object kq = db.getScalar(chuoiTV);
                txtDonGia.Text = kq.ToString();
            }

        }
        float CalculateTotalPrice()
        {
            float total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {

                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    float giaBan = float.Parse(row.Cells["GiaBan"].Value.ToString());

                    float tongTien = soLuong * giaBan;
                    total += tongTien;
                }
            }

            return total;
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
            string chuoitv = "DELETE FROM ChiTietHD WHERE MaHD = '" + txtMaHD.Text + "' AND MaQA = '" + cboTenSP.SelectedValue + "'";
            int kq = db.getNonQuery(chuoitv);
            if (kq != 1)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Không xóa được");

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string chuoitv1 = "DELETE FROM ChiTietHD WHERE MaHD = '" + txtMaHD.Text + "'";
            int kq1 = db.getNonQuery(chuoitv1);
            if (kq1 != 1)
                MessageBox.Show("Đã Xóa");
            string chuoitv2 = "DELETE FROM HoaDon WHERE MaHD = '" + txtMaHD.Text + "'";
            int kq2 = db.getNonQuery(chuoitv2);
            if (kq2 != 1)
                MessageBox.Show("Đã Xóa");
            txtMaHD.Text = null;
            load_gird();
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
                txtDonGia.Text = dataGridView1.Rows[rowIndex].Cells["GiaBan"].Value.ToString();
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

            }
            string chuoitv = "Update chitietHD set soluong = '" + txtSoLuong.Text + "' where maQA ='" + cboTenSP.SelectedValue + "'";
            int kq = db.getNonQuery(chuoitv);
            txtTongTien.Text = CalculateTotalPrice().ToString();
            if (kq != 1)
                MessageBox.Show("Sửa thất bại");
            else
                MessageBox.Show("Đã sửa");

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            string maKH = GetOrCreateMaKH();
            string chuoiTV = "update HoaDon set MaKH = '"+maKH+"' where MaHD ='"+txtMaHD.Text+"'";
            int kq = db.getNonQuery(chuoiTV);
            if (kq == 1)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Chưa sửa");
        }
    }
}
