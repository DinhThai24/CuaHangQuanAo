using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom10_ShopQuanAo.Views;

namespace Nhom10_ShopQuanAo.Views
{
    public partial class Login : Form
    {
        DBConnect db = new DBConnect();
        public Login()
        {
            InitializeComponent();
        }

        public class GetDataUser
        {
            static public string tennhanvien;
            static public string phanquyen;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtTK.Text;
            string matKhau = txtMK.Text;
            if (txtTK.Text == "" || txtTK.Text == "")
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không được để trống !");


            }
            else
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = '"+tenTK+"' AND MatKhau = '"+matKhau+"'";

                int count = Convert.ToInt32(db.getScalar(sql));

                if (count > 0)
                {
                    // Đăng nhập thành công, chuyển sang form MenuForm
                    
                    frmMenu menuForm = new frmMenu();
                    string sql1 = "SELECT PhanQuyen FROM TaiKhoan WHERE TenTK = '"+tenTK+"' AND MatKhau = '"+matKhau+"'";
                    object kq = db.getScalar(sql1);
                    if(kq != null)
                    {
                        GetDataUser.phanquyen = kq.ToString();
                    }
                    string sql2 = "SELECT TenNV FROM NhanVien NV JOIN TaiKhoan TK ON NV.TenTK = TK.TenTK WHERE NV.TenTK = '" + tenTK + "' AND TK.MatKhau = '"+matKhau+"'";
                    object kq1 = db.getScalar(sql2);
                    if (kq1 != null)
                    {
                        GetDataUser.tennhanvien = kq1.ToString();
                    }


                    menuForm.Show();
                    this.Hide(); // Ẩn form đăng nhập

                    //MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                }

            }
        }

        private void chboHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chboHienMK.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", thoát chương trình
                Application.Exit();
            }
            else
            {
                // Nếu người dùng chọn "No", hủy đóng form
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (!chboHienMK.Checked)
            {
                txtMK.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
    }
}
