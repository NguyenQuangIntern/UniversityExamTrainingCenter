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
    public partial class EmptyClassForm : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public EmptyClassForm()
        {
            InitializeComponent();
        }
        private void EmptyClassList_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            db.GiaoViens.Load();
            TeacherListCbx.DataSource = db.GiaoViens.Local;
            TeacherListCbx.DisplayMember = "TenGV";
            TeacherListCbx.ValueMember = "SoCMND";
            var thamgia = (from tg in db.ThamGiaHocs select tg.MaLop).ToList();
            var ds = (from lop in db.LopHocs join gv in db.GiaoViens on lop.MaGV equals gv.SoCMND  where !thamgia.Contains(lop.MaLop) select new { lop.MaLop, lop.TenLop, lop.NgayKhaiGiang, lop.ThoiGianHoc, lop.SoBuoiHoc, lop.TongSoGioHoc, SiSo=0, gv.TenGV }).ToList();
            ClassListDgv.DataSource = ds;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassIDTxb.Text == String.Empty)
            {
                MessageBox.Show("Mã lớp không được để trống! Không thêm mới được lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ClassNameTxb.Text == String.Empty)
            {
                MessageBox.Show("Tên lớp không được để trống! Không thêm mới được lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LearningTimeTxb.Text == String.Empty)
            {
                MessageBox.Show("Thời gian học không được để trống! Không thêm mới được lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lop = db.LopHocs.FirstOrDefault(lh => lh.MaLop == ClassIDTxb.Text);
            if (lop != null)
            {
                MessageBox.Show("Đã tồn tại mã lớp này rồi! Không thể thêm mới lớp học! Nếu bạn muốn cập nhật thông tin lớp, vui lòng kích nút 'Sửa'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lop = new LopHoc
            {
                MaLop = ClassIDTxb.Text,
                TenLop = ClassNameTxb.Text,
                NgayKhaiGiang = BeginningDateDtp.Value,
                ThoiGianHoc=LearningTimeTxb.Text,
                SoBuoiHoc=Convert.ToInt32(LearningDayCountNud.Value),
                MaGV=TeacherListCbx.SelectedValue.ToString()
            };
            db.LopHocs.Add(lop);

            try
            {
                db.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thêm được lớp học!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }

            LoadForm();
            MessageBox.Show("Thêm lớp học mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClassListDgv_SelectionChanged(object sender, EventArgs e)
        {
            var current_row = ClassListDgv.CurrentRow;
            ClassIDTxb.Text = current_row.Cells["MaLop"].Value.ToString();
            ClassNameTxb.Text = current_row.Cells["TenLop"].Value.ToString();
            BeginningDateDtp.Text = current_row.Cells["NgayKhaiGiang"].Value.ToString();
            LearningDayCountNud.Value = Convert.ToInt32(current_row.Cells["SoBuoiHoc"].Value);
            LearningTimeTxb.Text = current_row.Cells["ThoiGianHoc"].Value.ToString();
            TeacherListCbx.Text = current_row.Cells["TenGV"].Value.ToString();
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
                    
                    var thamgia = (from lop in db.ThamGiaHocs where lop.MaLop==ma select lop).ToList();
                    if(thamgia!=null)
                        foreach(ThamGiaHoc item in thamgia)
                        {
                            db.ThamGiaHocs.Remove(item);
                        }

                    var dslop = db.LopHocs.FirstOrDefault(lop => lop.MaLop== ma);
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
        private void Clear()
        {
            ClassIDTxb.Text = String.Empty;
            ClassNameTxb.Text = String.Empty;
            LearningTimeTxb.Text = String.Empty;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var lophoc = db.LopHocs.FirstOrDefault(lh => lh.MaLop == ClassIDTxb.Text);
            lophoc.TenLop = ClassNameTxb.Text;
            lophoc.NgayKhaiGiang = BeginningDateDtp.Value;
            lophoc.ThoiGianHoc = LearningTimeTxb.Text;
            lophoc.SoBuoiHoc = Convert.ToInt32(LearningDayCountNud.Value);
            lophoc.MaGV = TeacherListCbx.SelectedValue.ToString();

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Không thể sửa thông tin lớp học", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadForm();
            MessageBox.Show("Thông tin lớp học  đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var text = SearchBox.Text.ToLower();
            var thamgia = (from tg in db.ThamGiaHocs select tg.MaLop).ToList();
            var ds = (from lop in db.LopHocs join gv in db.GiaoViens on lop.MaGV equals gv.SoCMND where !thamgia.Contains(lop.MaLop) && lop.TenLop.ToLower().Contains(text) select new { lop.MaLop, lop.TenLop, lop.NgayKhaiGiang, lop.ThoiGianHoc, lop.SoBuoiHoc, lop.TongSoGioHoc, SiSo = 0, gv.TenGV }).ToList();
            ClassListDgv.DataSource = ds;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = String.Empty;
        }

        private void ClassListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
