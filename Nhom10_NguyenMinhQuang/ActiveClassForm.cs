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
    public partial class ActiveClassForm : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public ActiveClassForm()
        {
            InitializeComponent();
        }

        private void TeacherListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void StudentClassForm_Load(object sender, EventArgs e)
        {
           LoadForm();
        }
        private void LoadForm()
        {
            db.GiaoViens.Load();
            TeacherListCbx.DataSource = db.GiaoViens.Local;
            TeacherListCbx.DisplayMember = "TenGV";
            TeacherListCbx.ValueMember = "SoCMND";
            DisplayData();
        }
        private void DisplayData()
        {
            var ds = from thamgia in db.ThamGiaHocs
                group new { thamgia.LopHoc, thamgia.LopHoc.GiaoVien, thamgia } by new
                {
                    thamgia.LopHoc.MaLop,
                    thamgia.LopHoc.TenLop,
                    thamgia.LopHoc.NgayKhaiGiang,
                    thamgia.LopHoc.SoBuoiHoc,
                    TongSoGioHoc = (int?)thamgia.LopHoc.TongSoGioHoc,
                    thamgia.LopHoc.ThoiGianHoc,
                    thamgia.LopHoc.GiaoVien.TenGV
                } into g
                select new
                {
                    g.Key.MaLop,
                    g.Key.TenLop,
                    g.Key.NgayKhaiGiang,
                    g.Key.SoBuoiHoc,
                    TongSoGioHoc = (int?)g.Key.TongSoGioHoc,
                    g.Key.ThoiGianHoc,
                    SiSo = g.Count(p => p.thamgia.MaHS != null),
                    g.Key.TenGV
                };
            ClassListDgv.DataSource = ds.ToList();
        }

        private void ClassListDgv_SelectionChanged(object sender, EventArgs e)
        {
            var current_row = ClassListDgv.CurrentRow;
            ClassIDTxb.Text = current_row.Cells[0].Value.ToString();
            ClassNameTxb.Text = current_row.Cells[1].Value.ToString();
            BeginningDateDtp.Text = current_row.Cells[2].Value.ToString();
            LearningDayCountNud.Text = current_row.Cells[3].Value.ToString();
            LearningTimeTxb.Text = current_row.Cells[5].Value.ToString();
            TeacherListCbx.Text = current_row.Cells["TenGV"].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (isExisted())
            {
                MessageBox.Show("Mã lớp này đã tồn tại! Không thêm được lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ClassIDTxb.Text == String.Empty)
            {
                MessageBox.Show("Mã lớp không được để trống!", "Không thêm được lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ClassNameTxb.Text == String.Empty)
            {
                MessageBox.Show("Tên lớp không được để trống!", "Không thêm được lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LearningTimeTxb.Text == String.Empty)
            {
                MessageBox.Show("Thời gian học không được để trống!", "Không thêm được lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var lophoc = new LopHoc
            {
                MaLop = ClassIDTxb.Text.ToUpper(),
                TenLop = ClassNameTxb.Text,
                NgayKhaiGiang = BeginningDateDtp.Value,
                SoBuoiHoc = Convert.ToInt32(LearningDayCountNud.Value),
                ThoiGianHoc=LearningTimeTxb.Text,
                MaGV=TeacherListCbx.SelectedValue.ToString()
            };
            db.LopHocs.Add(lophoc);
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thêm được lớp! Đã có lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadForm();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu các lớp học bị xóa sẽ không thể khôi phục!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = ClassListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var ma = row.Cells["MaLop"].Value.ToString();

                    var thamgia = (from lop in db.ThamGiaHocs where lop.MaLop == ma select lop).ToList();
                    if (thamgia != null)
                        foreach (ThamGiaHoc item in thamgia)
                        {
                            db.ThamGiaHocs.Remove(item);
                        }

                    var dslop = db.LopHocs.FirstOrDefault(lop => lop.MaLop == ma);
                    db.LopHocs.Remove(dslop);
                }
            }
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadForm();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.FirstOrDefault(lh => lh.MaLop== ClassIDTxb.Text);
            lop.TenLop = ClassNameTxb.Text;
            lop.NgayKhaiGiang = BeginningDateDtp.Value;
            lop.SoBuoiHoc = Convert.ToInt32(LearningDayCountNud.Value);
            lop.ThoiGianHoc = LearningTimeTxb.Text;
            lop.MaGV = TeacherListCbx.SelectedValue.ToString();
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi hệ thống", "Không sửa được thông tin lớp học!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadForm();
            MessageBox.Show("Thông tin giáo viên đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool isExisted()
        {
            return (db.LopHocs.FirstOrDefault(lop => lop.MaLop== ClassIDTxb.Text) != null);
        }

        public void StudentListBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentListInClassForm().ShowDialog();
            Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var text = SearchBox.Text.ToLower();
            var ds = from thamgia in db.ThamGiaHocs
                     group new { thamgia.LopHoc, thamgia.LopHoc.GiaoVien, thamgia } by new
                     {
                         thamgia.LopHoc.MaLop,
                         thamgia.LopHoc.TenLop,
                         thamgia.LopHoc.NgayKhaiGiang,
                         thamgia.LopHoc.SoBuoiHoc,
                         TongSoGioHoc = (int?)thamgia.LopHoc.TongSoGioHoc,
                         thamgia.LopHoc.ThoiGianHoc,
                         thamgia.LopHoc.GiaoVien.TenGV
                     } into g
                     where g.Key.TenLop.ToLower().Contains(text)
                     select new
                     {
                         g.Key.MaLop,
                         g.Key.TenLop,
                         g.Key.NgayKhaiGiang,
                         g.Key.SoBuoiHoc,
                         TongSoGioHoc = (int?)g.Key.TongSoGioHoc,
                         g.Key.ThoiGianHoc,
                         SiSo = g.Count(p => p.thamgia.MaHS != null),
                         g.Key.TenGV
                     };
            ClassListDgv.DataSource = ds.ToList();
        }
    }
}
