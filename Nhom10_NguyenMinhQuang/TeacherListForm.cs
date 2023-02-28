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
    public partial class TeacherListForm : Form
    {
        static TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public TeacherListForm()
        {
            InitializeComponent();
        }
        private void DisplayList()
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens where hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }
        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            InitializeList();
        }

        private void TeacherListDgv_SelectionChanged(object sender, EventArgs e)
        {
            var current_row = TeacherListDgv.CurrentRow;
            IDNumberTxb.Text = current_row.Cells["SoCMND"].Value.ToString();
            PhoneNumberTxb.Text = current_row.Cells["SoDT"].Value.ToString();
            FullNameTxb.Text = current_row.Cells["TenGV"].Value.ToString();
            DateBirthDTP.Text = current_row.Cells["NgaySinh"].Value.ToString();
            if (current_row.Cells["GioiTinh"].Value.ToString() == "True")
            {
                GenderCbx.SelectedIndex = 0;
            }
            else
            {
                GenderCbx.SelectedIndex = 1;
            }
            ExperienceNumUD.Value = int.Parse(current_row.Cells["SoNamKinhNghiem"].Value.ToString());
            SubjectListCbx.Text = current_row.Cells["MonHoc"].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để thêm mới giáo viên dạy tại trung tâm, xin vui lòng phê duyệt hợp đồng cho giáo viên ứng tuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            AppliedTeacherForm f = new AppliedTeacherForm();
            f.ShowDialog();
            Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu các giáo viên bị xóa sẽ không thể khôi phục!?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = TeacherListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var ma = row.Cells["SoCMND"].Value.ToString();
                    var hopDong = db.HopDongs.FirstOrDefault(hd => hd.MaGV == ma);
                    var giaoVien = db.GiaoViens.FirstOrDefault(gv => gv.SoCMND == ma);
                    if (hopDong != null)
                        db.HopDongs.Remove(hopDong);
                    db.GiaoViens.Remove(giaoVien);
                }
                db.SaveChanges();
                InitializeList();
            }
        }
        private bool isExisted()
        {
            return (db.GiaoViens.FirstOrDefault(gv => gv.SoCMND == IDNumberTxb.Text) != null);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (isExisted())
            {
                var giaovien = db.GiaoViens.FirstOrDefault(gv => gv.SoCMND == IDNumberTxb.Text);
                try
                {
                    giaovien.TenGV = FullNameTxb.Text;
                    giaovien.SoDT = PhoneNumberTxb.Text;
                    giaovien.NgaySinh = DateBirthDTP.Value;
                    if (GenderCbx.SelectedIndex == 0)
                    {
                        giaovien.GioiTinh = true;
                    }
                    else
                    {
                        giaovien.GioiTinh = false;
                    }
                    giaovien.SoNamKinhNghiem = int.Parse(ExperienceNumUD.Value.ToString());
                    giaovien.MonHoc = SubjectListCbx.Text;
                    db.SaveChanges();
                    InitializeList();
                    MessageBox.Show("Thông tin giáo viên đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số Căn cước/CMND", "Không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa số CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = SearchBox.Text.ToLower();
            if (SearchBox.Text != "")
            {
                var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
                var ds = (from gv in db.GiaoViens where gv.TenGV.ToLower().Contains(searchText) && hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
                TeacherListDgv.DataSource = ds;
                AdjustDatagridHeight();
            }
            else
            {
                DisplayList();
            }
        }
        private void AdjustDatagridHeight()
        {
            var totalRowHeight = TeacherListDgv.ColumnHeadersHeight;
            if (TeacherListDgv.Height < 600)
            {
                foreach (DataGridViewRow row in TeacherListDgv.Rows)
                    totalRowHeight += row.Height;
                TeacherListDgv.Height = totalRowHeight + 10;
                panel2.Height = totalRowHeight + 10;
                this.Height = panel2.Height + 170;
                TeacherListDgv.Width = panel2.Width;
                TeacherListDgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

        }
        
        private void Option_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Option_cbx.SelectedIndex;
            switch (index)
            {
                default:
                    {
                        InitializeList();
                        break;
                    }
                case 1:
                    {
                        SortByAgeASC();
                        break;
                    }
                case 2:
                    {
                        SortByAgeDESC();
                        break;
                    }
                case 3:
                    {
                        FilterByGender(true);
                        break;
                    }
                case 4:
                    {
                        FilterByGender(false);
                        break;
                    }
                case 5:
                    {
                        ExperienceNumASC();
                        break;
                    }
                case 6:
                    {
                        ExperienceNumDESC();
                        break;
                    }
            }
        }

        private void InitializeList()
        {
            db.MonHocs.Load();
            SubjectListCbx.DataSource = db.MonHocs.Local;
            SubjectListCbx.DisplayMember = "TenMon";
            SubjectListCbx.ValueMember = "TenMon";
            Option_cbx.SelectedIndex = 0;
            DisplayList();
        }
        private void SortByAgeASC()
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens orderby gv.NgaySinh descending where hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc}).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }
        private void SortByAgeDESC()
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens orderby gv.NgaySinh ascending where hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }
        private void FilterByGender(bool gender)
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens where gv.GioiTinh == gender && hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }
        private void ExperienceNumASC()
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens orderby gv.SoNamKinhNghiem ascending where hd.Contains(gv.SoCMND) select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }
        private void ExperienceNumDESC()
        {
            var hd = (from hopdong in db.HopDongs select hopdong.MaGV).ToList();
            var ds = (from gv in db.GiaoViens orderby gv.SoNamKinhNghiem descending where hd.Contains(gv.SoCMND)  select new { gv.SoCMND, gv.TenGV, gv.NgaySinh, gv.SoDT, gv.GioiTinh, gv.SoNamKinhNghiem, gv.MonHoc }).ToList();
            TeacherListDgv.DataSource = ds;
            AdjustDatagridHeight();
        }

        private void AddBtn_MouseEnter(object sender, EventArgs e)
        {
            AddBtn.BackColor = Color.Red;
            AddBtn.ForeColor = Color.Yellow;
            AddBtn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }

        private void AddBtn_MouseLeave(object sender, EventArgs e)
        {
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.ForeColor = Color.White;
            AddBtn.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        private void EditBtn_MouseEnter(object sender, EventArgs e)
        {
            EditBtn.BackColor = Color.Red;
            EditBtn.ForeColor = Color.Yellow;
            EditBtn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }

        private void EditBtn_MouseLeave(object sender, EventArgs e)
        {
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.ForeColor = Color.White;
            EditBtn.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        private void DeleteBtn_MouseEnter(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.Yellow;
            DeleteBtn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = SystemColors.HotTrack;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        private void BackBtn_MouseEnter(object sender, EventArgs e)
        {
            BackBtn.BackColor = Color.Red;
            BackBtn.ForeColor = Color.Yellow;
            BackBtn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.BackColor = SystemColors.HotTrack;
            BackBtn.ForeColor = Color.White;
            BackBtn.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
