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
    public partial class AddStudentToClass : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public string mahs;
        public AddStudentToClass()
        {
            InitializeComponent();
        }

        private void AddStudentToClass_Load(object sender, EventArgs e)
        {
            var list = (from student in db.HocSinhs
                        join school in db.TruongHocs on student.MaTruong equals school.MaTruong
                        select new { student.SoCMND, student.TenHS, student.NgaySinh, student.SDT}).ToList();
            StudentListDgv.DataSource = list;
        }
        private void StudentListDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow current_row = StudentListDgv.CurrentRow;
            mahs = current_row.Cells["SoCMND"].Value.ToString();
        }
        private void StudentListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
