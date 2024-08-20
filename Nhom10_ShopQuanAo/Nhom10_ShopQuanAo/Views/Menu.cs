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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        static string GetTimeNow()
        {
            DateTime date = DateTime.Now; // Lấy thời điểm hiện tại

            string dayOfWeek = date.ToString("dddd"); // Lấy thứ trong tuần
            string dayOfMonth = date.Day.ToString(); // Lấy ngày trong tháng
            string month = date.Month.ToString(); // Lấy tên của tháng
            string year = date.Year.ToString(); // Lấy năm

            return "'" + dayOfWeek + "', ngày " + dayOfMonth + " / " + month + " / " + year + "'";

        }
        private Form formNow;
        private void LoadForm(Form formnew)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = formnew;
            formnew.TopLevel = false;
            formnew.FormBorderStyle = FormBorderStyle.None; //loại bỏ phần viền
            formnew.Dock = DockStyle.Fill;// đổ đầy kích thước của form với panel
            panel_Body.Controls.Add(formnew);
            panel_Body.Tag = formnew;
            formnew.BringToFront();
            formnew.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Height = 700;
            this.Width = 1000;
            lbTime.Text = GetTimeNow();
            lbPQ.Text = Login.GetDataUser.phanquyen;
            lbTen.Text = Login.GetDataUser.tennhanvien;
            if(lbPQ.Text=="Nhân Viên")
            {
                btnFrmNV.Visible = false;
                btnThongKe.Visible = false;
            }    
            if(lbPQ.Text == "Khách hàng")
            {

            }

        }

        private Button ButtonNow;
        private void ActiveColor(Button ButtonNew)
        {
            if (ButtonNow != null)
            {
                ButtonNow.ForeColor = Color.White;
                ButtonNow = ButtonNew;
                ButtonNew.ForeColor = Color.Red;

            }
        }
        private void btnFrmNV_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien();
            LoadForm(a);
            ActiveColor(btnFrmNV);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang a = new KhachHang();
            LoadForm(a);
            ActiveColor(btnKhachHang);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham a = new SanPham();
            LoadForm(a);
            ActiveColor(btnSanPham);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon a = new frmHoaDon();
            LoadForm(a);
            ActiveColor(btnHoaDon);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuNhap a = new PhieuNhap();
            LoadForm(a);
            ActiveColor(btnPhieuNhap);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panel_Body.Controls.Clear();

            ActiveColor(btnTrangChu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản không  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login a = new Login();
                a.ShowDialog();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe a = new ThongKe();
            LoadForm(a);
            ActiveColor(btnThongKe);
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
