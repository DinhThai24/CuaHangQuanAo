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
    public partial class ThongKe : Form
    {
        DBConnect db =  new DBConnect();
        public ThongKe()
        {
            InitializeComponent();
        }
        void load_HD()
        {
            string chuoitruyvan = "select * from HoaDon ";
            DataTable dt = db.getTable(chuoitruyvan);

            dgvThongKe.DataSource = dt;

        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            load_HD();
            TimeThang.Format = DateTimePickerFormat.Custom;
            TimeThang.CustomFormat = "MM-yyyy";

            TimeNam.Format = DateTimePickerFormat.Custom;
            TimeNam.CustomFormat = "yyyy";
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ DateTimePicker
            string thangNam = TimeThang.Value.ToString("MM-yyyy");

            // Sử dụng tháng và năm để truy vấn tổng doanh thu
            string chuoiThang = "SELECT SUM(TongTien) AS TongDoanhThu FROM HoaDon WHERE FORMAT(NgayLap, 'MM-yyyy') = '" + thangNam + "'";
            object kqThang = db.getScalar(chuoiThang);
            lbThang.Text = kqThang != null ? kqThang.ToString() : "0"; // Đảm bảo hiển thị kết quả hoặc mặc định là 0 nếu không có dữ liệu
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            // Lấy năm từ DateTimePicker
            string nam = TimeNam.Value.ToString("yyyy");

            // Sử dụng năm để truy vấn tổng doanh thu
            string chuoiNam = "SELECT SUM(TongTien) AS TongDoanhThu FROM HoaDon WHERE YEAR(NgayLap) = '" + nam + "'";
            object kqNam = db.getScalar(chuoiNam);
            lbNam.Text = kqNam != null ? kqNam.ToString() : "0"; // Hiển thị kết quả hoặc mặc định là 0 nếu không có dữ liệu
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            // Lấy ngày/tháng/năm từ DateTimePicker
            string dmy = TimeNgay.Value.ToString("dd-MM-yyyy");

            // Sử dụng ngày/tháng/năm để truy vấn tổng doanh thu
            string chuoiDMY = "SELECT SUM(TongTien) AS TongDoanhThu FROM HoaDon WHERE CONVERT(VARCHAR, NgayLap, 105) = '" + dmy + "'";
            object kqDMY = db.getScalar(chuoiDMY);
            lbNgay.Text = kqDMY != null ? kqDMY.ToString() : "0"; // Hiển thị kết quả hoặc mặc định là 0 nếu không có dữ liệu
        }
    }
}
