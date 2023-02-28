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
    public partial class ContractForm : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public ContractForm()
        {
            InitializeComponent();
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }
        private void InitializeForm()
        {
            Option_cbx.SelectedIndex = 0;
            LicenceID.Text = (from hd in db.HopDongs select hd.SoGiayPhepTrungTam).FirstOrDefault().ToString();
            DisplayData();
            AdjustRowHeight();
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
                        IssuedDayASC();
                        break;
                    }
                case 2:
                    {
                        IssuedDayDESC();
                        break;
                    }
                case 3:
                    {
                        DurationTimeASC();
                        break;
                    }
                case 4:
                    {
                        DurationTimeDESC();
                        break;
                    }
                case 5:
                    {
                        ExpiredDateASC();
                        break;
                    }
                case 6:
                    {
                        SalaryASC();
                        break;
                    }
                case 7:
                    {
                        SalaryDESC();
                        break;
                    }
                case 8:
                    {
                        ExpiredContract();
                        break;
                    }
            }
        }
        private void DisplayData()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void IssuedDayASC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.NgayCap ascending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void IssuedDayDESC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.NgayCap descending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void DurationTimeASC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.ThoiHan ascending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void DurationTimeDESC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.ThoiHan descending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void ExpiredDateASC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.NgayHetHan ascending where hd.NgayHetHan > DateTime.Today select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void SalaryASC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.LuongTheoBuoi ascending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void SalaryDESC()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND orderby hd.LuongTheoBuoi descending select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void ExpiredContract()
        {
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND where hd.NgayHetHan < DateTime.Today select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }
        private void AdjustRowHeight()
        {
            ContractListDgv.Height = DataPanel.Height;
            ContractListDgv.Width = DataPanel.Width;
        }

        private void ContractListDgv_SelectionChanged(object sender, EventArgs e)
        {
            var current_row = ContractListDgv.CurrentRow;
            IDNumberTxb.Text = current_row.Cells["MaGV"].Value.ToString();
            DurationTimeNUD.Value = int.Parse(current_row.Cells["ThoiHan"].Value.ToString());
            IssuedDayDTP.Text = current_row.Cells["NgayCap"].Value.ToString();
            SalaryTxb.Text= current_row.Cells["LuongTheoBuoi"].Value.ToString();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IDNumberTxb.Text == String.Empty)
            {
                MessageBox.Show("Số căn cước/CMND không được để trống!", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(IDNumberTxb.Text.Length!=9 && IDNumberTxb.Text.Length != 12)
            {
                MessageBox.Show("Số căn cước/CMND phải có 9 hoặc 12 chữ số!", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var giaovien = db.GiaoViens.FirstOrDefault(gv => gv.SoCMND == IDNumberTxb.Text);
            if (giaovien == null){
                DialogResult dr = MessageBox.Show("Không thêm được hợp đồng, số CMND của giáo viên cần tồn tại trong danh sách giáo viên ứng tuyển, phê duyệt hợp đồng trong danh sách ứng tuyển?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Hide();
                    new AppliedTeacherForm().ShowDialog();
                    Show();
                    InitializeForm();
                }
                else return;
            }

            var hopdong = db.HopDongs.FirstOrDefault(hd => hd.MaGV == IDNumberTxb.Text);
            
            if (hopdong != null)
            {
                MessageBox.Show("Đã tồn tại 1 hợp đồng với giáo viên này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hopdong = new HopDong()
            {
                SoGiayPhepTrungTam = 3743,
                MaGV = IDNumberTxb.Text,
                NgayCap = IssuedDayDTP.Value,
                ThoiHan = Convert.ToInt32(DurationTimeNUD.Value),
                LuongTheoBuoi = Convert.ToInt32(SalaryTxb.Text)
            };
            db.HopDongs.Add(hopdong);
            try
            {
                db.SaveChanges();
                InitializeForm();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thêm được hợp đồng! Hãy quay lại sau!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (isExisted())
            {
                var hopdong = db.HopDongs.FirstOrDefault(hd => hd.MaGV == IDNumberTxb.Text);
                try
                {
                    hopdong.NgayCap = IssuedDayDTP.Value;
                    hopdong.ThoiHan = int.Parse(DurationTimeNUD.Value.ToString());
                    hopdong.LuongTheoBuoi = int.Parse(SalaryTxb.Text);
                    db.SaveChanges();
                    InitializeForm();
                    MessageBox.Show("Thông tin hợp đồng đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Không thể cập nhật thông tin  nhân viên", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã GV/số CMND", "Không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool isExisted()
        {
            return (db.HopDongs.FirstOrDefault(hd => hd.MaGV== IDNumberTxb.Text) != null);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = SearchBox.Text.ToLower();
            var hopdong = (from hd in db.HopDongs join gv in db.GiaoViens on hd.MaGV equals gv.SoCMND where gv.TenGV.ToLower().Contains(searchText) select new { hd.MaGV, gv.TenGV, hd.NgayCap, hd.ThoiHan, hd.NgayHetHan, hd.LuongTheoBuoi }).ToList();
            ContractListDgv.DataSource = hopdong;
        }

        private void ContractListDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu hợp đồng bị xóa sẽ không thể khôi phục!?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var selectedRows = ContractListDgv.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    var ma = row.Cells["MaGV"].Value.ToString();
                    var hopdong = db.HopDongs.FirstOrDefault(hd => hd.MaGV== ma);
                    if (hopdong != null)
                        db.HopDongs.Remove(hopdong);
                }
                db.SaveChanges();
                InitializeForm();
            }
        }
    }
}
