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
    public partial class TreeViewForm : Form
    {
        static TrungTamThayThanhContext db = new TrungTamThayThanhContext();

        public TreeViewForm()
        {
            InitializeComponent();
        }
        private void ShowClass()
        {
            var lop = from LopTheoMons in db.LopTheoMons group LopTheoMons by new{LopTheoMons.TenMon} into g
                      select new{ g.Key.TenMon, SoLuongLop = g.Count(p => p.MaLop != null)};
            dataGridView1.DataSource = lop.ToList();

            TreeNode root = new TreeNode();
            root.Text = "Danh sách các lớp học hoạt động";
            root.ImageIndex = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var tenmon = row.Cells["TenMon"].Value.ToString();
                TreeNode root2 = new TreeNode();
                root2.Text = tenmon;
                root2.ImageIndex = 0;
                
                var ds = (from lh in db.LopTheoMons where lh.TenMon == tenmon select lh).ToArray();
                for(int i = 0; i< ds.Length; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = ds.ElementAt(i).TenLop;
                    node.ImageIndex = 0;
                    root2.Nodes.Add(node);
                }
                root.Nodes.Add(root2);
            }
            ClassTree.Nodes.Add(root);
        }
        private void TreeViewForm_Load(object sender, EventArgs e)
        {
            ShowClass();
        }

    }
}
