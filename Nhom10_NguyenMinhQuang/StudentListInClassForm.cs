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
    public partial class StudentListInClassForm : Form
    {
        private TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public StudentListInClassForm()
        {
            InitializeComponent();
        }
        private void StudentListInClassForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void LoadForm()
        {
            db.LopHocs.Load();
            ClassCbx.DataSource = db.LopHocs.Local;
            ClassCbx.DisplayMember = "TenLop";
            ClassCbx.ValueMember = "MaLop";
        }

        private void StudentListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var malop = ClassCbx.SelectedValue.ToString();
            string mahocsinh = String.Empty;
            Hide();
            MessageBox.Show("Vui lòng chọn học sinh trong danh sách học sinh đăng ký tại trung tâm rồi kích nút 'Thêm học sinh'. Nếu đây là học sinh mới, vui lòng quay lại menu quản trị và chọn quản lý danh sách tất cả học sinh để thêm mới em!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddStudentToClass f = new AddStudentToClass();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                mahocsinh = f.mahs;
                f.Close();
            }
            Show();

            
            var thamgia = new ThamGiaHoc
            {
                MaLop = malop,
                MaHS=mahocsinh,
                SoBuoiHoc=1
            };
            db.ThamGiaHocs.Add(thamgia);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được học sinh!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayData();
            MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentListDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow current_row = StudentListDgv.CurrentRow;
            IDNumberTxb.Text = current_row.Cells["MaHS"].Value.ToString();
            TakePartInDayCount.Text = current_row.Cells["SoBuoiHoc"].Value.ToString();
        }

        private void DisplayData()
        {
            var malop = ClassCbx.SelectedValue.ToString();

            ClassID_lbl.Text = malop;
            ClassName_lbl.Text = ClassCbx.Text;

            var ds = (from lop in db.LopHocs
                      join thamgia in db.ThamGiaHocs on lop.MaLop equals thamgia.MaLop
                      join hs in db.HocSinhs on thamgia.MaHS equals hs.SoCMND
                      where lop.MaLop == malop
                      select new { thamgia.MaHS, hs.TenHS, hs.SDT, thamgia.SoBuoiHoc, thamgia.TongHocPhi }).ToList();
            StudentListDgv.DataSource = ds;
        }

        private void ClassCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var thamgia = db.ThamGiaHocs.Find(ClassCbx.SelectedValue.ToString(), IDNumberTxb.Text);
            if (thamgia != null)
            {
                thamgia.SoBuoiHoc = Convert.ToInt32(TakePartInDayCount.Value);
            }
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không sửa được học sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            MessageBox.Show("Thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = StudentListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var malop = ClassCbx.SelectedValue.ToString();
                    var mahs = row.Cells["MaHS"].Value.ToString();
                    var thamgia = db.ThamGiaHocs.Find(malop, mahs);

                    if (thamgia != null)
                        db.ThamGiaHocs.Remove(thamgia);
                }
                db.SaveChanges();
                DisplayData();
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = String.Empty;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var malop = ClassCbx.SelectedValue.ToString();
            var text = SearchBox.Text.ToLower();
            var ds = (from lop in db.LopHocs
                      join thamgia in db.ThamGiaHocs on lop.MaLop equals thamgia.MaLop
                      join hs in db.HocSinhs on thamgia.MaHS equals hs.SoCMND
                      where lop.MaLop == malop && hs.TenHS.ToLower().Contains(text)
                      select new { thamgia.MaHS, hs.TenHS, hs.SDT, thamgia.SoBuoiHoc, thamgia.TongHocPhi }).ToList();
            StudentListDgv.DataSource = ds;
        }
    }
}
