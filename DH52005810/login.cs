using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DH52005810
{
    public partial class formlogin : Form
    {
        ChucNangLogin checklogin = new ChucNangLogin();

        public formlogin()
        {
            InitializeComponent();
        }

        private void bttnthoat_Click(object sender, EventArgs e) // set thoát
        {

            Application.Exit();

        } 

        private void BttnDangnhap_Click(object sender, EventArgs e)// set đăng nhập 
        {
            string user = txbAccount.Text;
            string pass = txbPassword.Text;
            string result = checklogin.Login(user, pass);
            DisplayResultLogin(result);
        }

        public void DisplayResultLogin(string result)
        {
            try
            {
                switch (result)
                {
                    case "error_empty":
                        MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                 
                    case "error_whiteSpace":
                        MessageBox.Show("Tên tài khoản và mật khẩu không được chứa khoảng trắng.",
                            "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "error_SpecialChar":
                        MessageBox.Show("Tên tài khoản không được chứa ký tự đặc biệt.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "error_fail":
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không tồn tại. Vui lòng kiểm tra lại!", "ERROR!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "success":
                        MessageBox.Show("Đăng nhập thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMain f = new FrmMain();
                        this.Hide();
                        f.ShowDialog();
                        //sau khi đăng xuất reset mk về rỗng.
                        txbPassword.ResetText();
                        this.Show();
                        txbPassword.Focus();

                        break;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập.Vui lòng thử lại.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        } 


        private void formlogin_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void link_formLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn muốn đăng ký tài khoản mới ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (q == DialogResult.OK)
            {
                Register f = new Register();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
