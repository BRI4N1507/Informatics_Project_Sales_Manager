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
    public partial class Register : Form
    {
        Dangky CheckRegister = new Dangky();
        public Register()
        {
            InitializeComponent();
        }
        public static List<string> adminManager = new List<string>();
        //admincode
        private void BttnDangKy_Click(object sender, EventArgs e)
        {
            string user = txtAccRegis.Text;
            string pass = txbPassRegis.Text;
            string confirm = txbConfirmRegis.Text;
            string admincode = txtCode.Text;

            string[] lines = File.ReadAllLines("admincode.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] sUser = lines[i].Split('|');
                string Code = sUser[0];
                adminManager.Add(Code);
                if (confirm == pass)
                {
                    if (admincode == Code)
                    {
                        string result = CheckRegister.Register(user, confirm, admincode);
                        displayResultRegis(result);
                    }
                    else { MessageBox.Show("Mã quản lý không đúng vui lòng nhập lại !.", "Thông báo"); }
                }
                else
                {
                    MessageBox.Show("Mật khẩu và mật khẩu xác nhận không trùng khớp.", "Thông báo");
                }
            }
            
            
        }
        public void displayResultRegis(string result)
        {
            try
            {
                switch (result)
                {
                    case "error_empty":
                        MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "error_whiteSpace":
                        MessageBox.Show("Tên tài khoản và mật khẩu không được chứa khoảng trắng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "error_SpecialChar":
                        MessageBox.Show("Tên tài khoản không được chứa ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "error_fail":
                        MessageBox.Show("tài khoản này đã tồn tại. Vui lòng kiểm tra lại!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "success":
                        string user = txtAccRegis.Text;
                        string pass = txbConfirmRegis.Text;
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string taikhoan = "\n" + user + "|" + pass;
                        File.AppendAllText("account.txt", taikhoan);
                        //read account vua đăng kí 
                        ChucNangLogin a = new ChucNangLogin();
                        a.ReadFileUser();
                        //success
                        txtAccRegis.Text = "";
                        txbPassRegis.Text = "";
                        txbConfirmRegis.Text = "";
                        txtCode.Text = "";
                        //login
                        formlogin f = new formlogin();
                        f.ShowDialog();
                        this.Hide();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng ký.Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void link_formLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn muốn đăng nhập ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (q == DialogResult.OK)
            {
                formlogin f = new formlogin();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void bttnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}