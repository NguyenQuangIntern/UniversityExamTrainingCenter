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
    public partial class PendingContractForm : Form
    {
        TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public PendingContractForm()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (SalaryTxb.Text == String.Empty)
            {
                MessageBox.Show("Tiền lương không được để trống!.", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int luong = Convert.ToInt32(SalaryTxb.Text);
            }
            catch
            {
                MessageBox.Show("Tiền lương nhập vào phải là số!", "Yêu cầu nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SalaryTxb.Text = String.Empty;
                return;
            }
            var hopdong = new HopDong()
            {
                SoGiayPhepTrungTam = 3743,
                MaGV = IDNumberTxb.Text,
                NgayCap = IssuedDateDTP.Value,
                ThoiHan = Convert.ToInt32(DurationTimeNUD.Value),
                LuongTheoBuoi=Convert.ToInt32(SalaryTxb.Text)
            };
            db.HopDongs.Add(hopdong);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Phê duyệt thành công! Hợp đồng đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AcceptBtn_MouseLeave(object sender, EventArgs e)
        {
            AcceptBtn.BackColor = SystemColors.HotTrack;
            AcceptBtn.ForeColor = Color.White;
            AcceptBtn.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }

        private void AcceptBtn_MouseEnter(object sender, EventArgs e)
        {
            AcceptBtn.BackColor = Color.Red;
            AcceptBtn.ForeColor = Color.Yellow;
            AcceptBtn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }
    }
}
