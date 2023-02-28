using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Nhom10_NguyenMinhQuang.Models;

namespace Nhom10_NguyenMinhQuang
{
    public partial class LoginForm : Form
    {
        private static LoginForm loginForm = new LoginForm();
        public static string displayName;
        private TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            using (var db = new TrungTamThayThanhContext())
            {
                var loginName = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == UsernameTxb.Text);
                if (loginName == null)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (loginName.MatKhau!= Encryption(PasswordTxb.Text))
                    {
                        MessageBox.Show("Không đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        displayName = loginName.TenHienThi;
                        UsernameTxb.Text = "";
                        PasswordTxb.Text = "";
                        UsernameTxb.Select();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        private string Encryption(string pw)
        {

            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pw);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X"));
            }

            return sb.ToString();
        }

    }
}
