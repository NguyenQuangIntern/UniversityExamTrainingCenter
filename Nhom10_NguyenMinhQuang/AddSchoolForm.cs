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
using System.Data.Entity;

namespace Nhom10_NguyenMinhQuang
{
    public partial class AddSchoolForm : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public AddSchoolForm()
        {
            InitializeComponent();
        }
        private void AddSchoolForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            db.KhuVucs.Load();
            Zone.DataSource = db.KhuVucs.Local;
            Zone.DisplayMember ="MaKhuVuc";
            Zone.ValueMember = "MaKhuVuc";

            var truong = from th in db.TruongHocs select th;
            SchooListDgv.DataSource = truong.ToList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SchooID.Text == String.Empty || SchooID.Text.Length>3)
            {
                MessageBox.Show("Mã trường phổ thông trên Hà Nội phải có đúng 3 ký tự và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SchooName.Text == String.Empty)
            {
                MessageBox.Show("Tên trường học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var truong = db.TruongHocs.FirstOrDefault(th => th.MaTruong == SchooID.Text);
            if (truong != null)
            {
                MessageBox.Show("Mã trường học này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            truong = new TruongHoc
            {
                MaTruong = SchooID.Text,
                TenTruong = SchooName.Text,
                DiaChi = Address.Text, 
                MaKhuVuc=Zone.SelectedValue.ToString()
            };
            db.TruongHocs.Add(truong);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể thêm được trường học!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
