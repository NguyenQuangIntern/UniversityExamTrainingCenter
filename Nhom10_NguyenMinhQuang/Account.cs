using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom10_NguyenMinhQuang.Models;
using System.Data.Common;
using System.Security.Cryptography;

namespace Nhom10_NguyenMinhQuang
{
    public partial class Account : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public Account()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            var taikhoan = (from tk in db.TaiKhoans select tk).ToList();
            AccountListDgv.DataSource = taikhoan;
        }
        private void Account_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void AccountListDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow current_row = AccountListDgv.CurrentRow;
            LoginName.Text = current_row.Cells["TenDangNhap"].Value.ToString();
            DisplayName.Text = current_row.Cells["TenHienThi"].Value.ToString();
            Password.Text = current_row.Cells["MatKhau"].Value.ToString();
        }
        private bool Condition()
        {
            if (LoginName.Text == String.Empty)
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (DisplayName.Text == String.Empty)
            {
                MessageBox.Show("Tên hiển thị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Password.Text == String.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!Condition())
            {
                return;
            }

            var taikhoan = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == LoginName.Text);
            if (taikhoan != null)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            taikhoan = new TaiKhoan
            {
                TenDangNhap = LoginName.Text,
                TenHienThi = DisplayName.Text,
                MatKhau = Encryption(Password.Text)
        };

            db.TaiKhoans.Add(taikhoan);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được tài khoản! Lưu ý: tên đăng nhập hệ thống chỉ cho phép tối đa 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;
            }
            LoadForm();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear()
        {
            LoginName.Text = String.Empty;
            DisplayName.Text = String.Empty;
            Password.Text = String.Empty;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (!Condition()) return;
            var taikhoan = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == LoginName.Text);
            
            if (taikhoan == null)
            {
                MessageBox.Show("Không thể sửa thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            taikhoan.TenHienThi = DisplayName.Text;
            taikhoan.MatKhau = Encryption(Password.Text);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể sửa thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadForm();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu các tài khoản bị xóa sẽ không thể khôi phục!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = AccountListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var ma = row.Cells["TenDangNhap"].Value.ToString();
                    var taikhoan= db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap== ma);
                    db.TaiKhoans.Remove(taikhoan);
                }
            }
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể xóa tài khoản!", "Lỗi hệ thống!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadForm();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void AccountListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
