using Nhom10_NguyenMinhQuang.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Nhom10_NguyenMinhQuang
{
    public partial class ManagementForm : Form
    {
        private TrungTamThayThanhContext db = new TrungTamThayThanhContext();
        public ManagementForm()
        {
            InitializeComponent();
        }

        private int TotalStudentSum() => (from hs in db.HocSinhs select hs).Count();

        private int TotalMaleSum()=> (from hs in db.HocSinhs where hs.GioiTinh == true select hs).Count();

        private int TotalFemaleSum()=> TotalStudentSum() - TotalMaleSum();
        private int MaleInClass()
        {
            var malop = ClassListCbx.SelectedValue.ToString();
            int count = (from lophoc in db.LopHocs
                          join danhsach in db.ThamGiaHocs on lophoc.MaLop equals danhsach.MaLop
                          join hocsinh in db.HocSinhs on danhsach.MaHS equals hocsinh.SoCMND
                          where hocsinh.GioiTinh == true && lophoc.MaLop.ToString() == malop
                          select new { lophoc, danhsach, hocsinh}).Count();
            return count;
        }
        private int FemaleInClass()
        {
            var malop = ClassListCbx.SelectedValue.ToString();
            int count = (from lophoc in db.LopHocs
                          join danhsach in db.ThamGiaHocs on lophoc.MaLop equals danhsach.MaLop
                          join hocsinh in db.HocSinhs on danhsach.MaHS equals hocsinh.SoCMND
                          where hocsinh.GioiTinh == false && lophoc.MaLop.ToString() == malop
                          select new { lophoc, danhsach, hocsinh }).Count();
            return count;
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ShowClassTree();

            TotalStudent_lbl.Text = TotalStudentSum().ToString();
            TotalMale_lbl.Text = TotalMaleSum().ToString();
            Total_Female_lbl.Text = TotalFemaleSum().ToString();
            DisplayName_lbl.Text = LoginForm.displayName;

            db.LopHocs.Load();
            ClassListCbx.DataSource = db.LopHocs.Local;
            ClassListCbx.DisplayMember = "TenLop";
            ClassListCbx.ValueMember = "MaLop";
            
        }
        private void ClassListCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            MaleInClass_lbl.Text = MaleInClass().ToString();
            FemaleInClass_lbl.Text = FemaleInClass().ToString();
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
        private void TeacherListManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherListForm teacherListForm = new TeacherListForm();
            teacherListForm.ShowDialog();
            Show();
        }

        private void AppliedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new AppliedTeacherForm().ShowDialog();
            Show();
        }

        private void ContractManagementItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ContractForm().ShowDialog();
            Show();
        }

        private void ActiveClassMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ActiveClassForm().ShowDialog();
            Show();
        }

        private void EmptyClassMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new EmptyClassForm().ShowDialog();
            Show();
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes);
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x00A1)
            {
                switch((int)message.WParam)
                {
                    case 50:
                        {
                            Application.Exit();
                            Dispose();
                            break ;
                        }
                }
            }
            base.WndProc(ref message);
        }
        private void ShowClassTree()
        {
            var lophoc = from lop in db.LopHocs
                      group lop.GiaoVien.MonHoc1 by new
                      {
                          lop.GiaoVien.MonHoc1.TenMon
                      } into g
                      select new
                      {
                          g.Key.TenMon,
                          Column1 = g.Count()
                      };
            Temp_dgv.DataSource = lophoc.ToList();

            TreeNode root = new TreeNode();
            root.Text = "Danh sách các lớp học theo môn";
            root.ImageIndex = 0;

            foreach (DataGridViewRow row in Temp_dgv.Rows)
            {
                var tenmon = row.Cells["TenMon"].Value.ToString();
                TreeNode root2 = new TreeNode();
                root2.Text = tenmon;
                root2.ImageIndex = 1;

                var ds = (from lh in db.LopHocs join gv in db.GiaoViens on lh.MaGV equals gv.SoCMND join mon in db.MonHocs on gv.MonHoc equals mon.TenMon where mon.TenMon == tenmon select lh).ToArray();
                for (int i = 0; i < ds.Length; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = ds.ElementAt(i).TenLop;
                    node.ImageIndex = 2;
                    root2.Nodes.Add(node);
                }
                root.Nodes.Add(root2);
            }
            ClassTree.Nodes.Add(root);
            
        }

        private void AllStudentList_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentListForm().ShowDialog();
            Show();
        }

        private void StudentListOnClass_Click(object sender, EventArgs e)
        {
            Hide();
            new StudentListInClassForm().ShowDialog();
            Show();
        }

        private void AccountMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Account().ShowDialog();
            Show();
        }

    }
}
