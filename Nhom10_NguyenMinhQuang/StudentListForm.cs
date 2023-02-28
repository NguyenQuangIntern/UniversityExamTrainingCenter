using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Nhom10_NguyenMinhQuang.Models;
namespace Nhom10_NguyenMinhQuang
{
    public partial class StudentListForm : Form
    {
        private TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public StudentListForm()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            Option_cbx.SelectedIndex = 0;
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }
        private void LoadForm()
        {
            db.TruongHocs.Load();
            SchoolCbx.DataSource = db.TruongHocs.Local;
            SchoolCbx.DisplayMember = "TenTruong";
            SchoolCbx.ValueMember = "MaTruong";
            DisplayData();
        }
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void StudentListDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow current_row = StudentListDgv.CurrentRow;
            if (current_row == null) return;

            IDNumberTxb.Text = current_row.Cells["SoCMND"].Value.ToString();
            FullNameTxb.Text = current_row.Cells["TenHS"].Value.ToString();
            DateBirthDTP.Text = current_row.Cells["NgaySinh"].Value.ToString();
            PhoneNumberTxb.Text = current_row.Cells["SDT"].Value.ToString();
            SchoolCbx.Text = current_row.Cells["TenTruong"].Value.ToString();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IDNumberTxb.Text == String.Empty)
            {
                MessageBox.Show("Số căn cước/CMND không được để trống!", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IDNumberTxb.Text.Length != 9 && IDNumberTxb.Text.Length != 12)
            {
                MessageBox.Show("Số căn cước/CMND phải có 9 hoặc 12 chữ số!", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isExisted())
            {
                MessageBox.Show("Số CMND này đã tồn tại rồi! Không thể thêm mới học sinh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hocsinh = db.HocSinhs.FirstOrDefault(hs => hs.SoCMND == IDNumberTxb.Text);
            hocsinh = new HocSinh()
            {
                SoCMND = IDNumberTxb.Text,
                TenHS = FullNameTxb.Text,
                NgaySinh = DateBirthDTP.Value,
                SDT = PhoneNumberTxb.Text,
                MaTruong = SchoolCbx.SelectedValue.ToString()
            };
            db.HocSinhs.Add(hocsinh);
            try
            {
                db.SaveChanges();
                DisplayData();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thêm được học sinh! Hãy quay lại sau!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (isExisted())
            {
                var hocsinh = db.HocSinhs.FirstOrDefault(hs => hs.SoCMND == IDNumberTxb.Text);
                hocsinh.TenHS = FullNameTxb.Text;
                hocsinh.NgaySinh = DateBirthDTP.Value;
                hocsinh.SDT = PhoneNumberTxb.Text;

                hocsinh.MaTruong = SchoolCbx.SelectedValue.ToString();
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Không thể cập nhật thông tin học sinh", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số CMND này đã tồn tại trong danh sách học sinh rồi!", "Không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayData();
            MessageBox.Show("Thông tin học sinh đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu học sinh bị xóa sẽ không thể khôi phục!?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = StudentListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var ma = row.Cells["SoCMND"].Value.ToString();

                    var thamgia = (from tghoc in db.ThamGiaHocs where tghoc.MaHS == ma select tghoc).ToList();
                    if(thamgia!=null)
                        foreach(ThamGiaHoc item in thamgia)
                        {
                                db.ThamGiaHocs.Remove(item);
                        }

                    var hocsinh = db.HocSinhs.FirstOrDefault(hs => hs.SoCMND == ma);
                    if (hocsinh != null)
                        db.HocSinhs.Remove(hocsinh);
                }
                try{
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Học sinh này đang học một số lớp tại trung tâm. Vui lòng xóa em khỏi danh sách học sinh trong các lớp trước!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DisplayData();
            }
        }
        private bool isExisted()
        {
            return (db.HocSinhs.FirstOrDefault(hs => hs.SoCMND == IDNumberTxb.Text) != null);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Option_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Option_cbx.SelectedIndex;
            switch (index)
            {
                default:
                    {
                        DisplayData();
                        break;
                    }
                case 1:
                    {
                        BirthDateASC();
                        break;
                    }
                case 2:
                    {
                        BirthDateDESC();
                        break;
                    }
                case 3:
                    {
                        ListBySchool();
                        break;
                    }
                case 4:
                    {
                        SpecialSchool();
                        break;
                    }
            }
        }
       
        private void BirthDateASC()
        {
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong orderby student.NgaySinh ascending
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }
        private void ListBySchool()
        { 
            var text = SchoolCbx.Text;
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        where school.MaTruong == SchoolCbx.SelectedValue.ToString()
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }
        private void BirthDateDESC()
        {
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        orderby student.NgaySinh descending
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }
        private void SpecialSchool()
        {
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        where school.TenTruong.ToLower().Contains("chuyên")
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == String.Empty)
            {
                DisplayData();
                return;
            }

            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        where student.TenHS.ToLower().Contains(SearchBox.Text.ToLower())
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT, school.TenTruong }).ToList();
            StudentListDgv.DataSource = list;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = String.Empty;
        }

        private void SchoolCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Option_cbx.SelectedIndex;
            if (index == 3)
            {
                ListBySchool();
            }
        }

        private void StudentListDgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void AddSchoolBtn_Click(object sender, EventArgs e)
        {
            new AddSchoolForm().ShowDialog();
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
    }

}
