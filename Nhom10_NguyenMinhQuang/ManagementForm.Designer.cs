
namespace Nhom10_NguyenMinhQuang
{
    partial class ManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherList_item = new System.Windows.Forms.ToolStripMenuItem();
            this.AppliedTeacherList_item = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassList_item = new System.Windows.Forms.ToolStripMenuItem();
            this.ConstrucClassList_item = new System.Windows.Forms.ToolStripMenuItem();
            this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllStudentListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentListOnClass = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ClassTree = new System.Windows.Forms.TreeView();
            this.SubjectImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Temp_dgv = new System.Windows.Forms.DataGridView();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.DisplayName_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.FemaleInClass_lbl = new System.Windows.Forms.Label();
            this.MaleInClass_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ClassListCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Female_lbl = new System.Windows.Forms.Label();
            this.TotalMale_lbl = new System.Windows.Forms.Label();
            this.TotalStudent_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MainMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Temp_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáoViênToolStripMenuItem,
            this.lớpHọcToolStripMenuItem,
            this.họcSinhToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem,
            this.AccountMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1366, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeacherList_item,
            this.AppliedTeacherList_item});
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.giáoViênToolStripMenuItem.Text = "Giáo viên";
            // 
            // TeacherList_item
            // 
            this.TeacherList_item.Name = "TeacherList_item";
            this.TeacherList_item.Size = new System.Drawing.Size(240, 22);
            this.TeacherList_item.Text = "Danh sách giáo viên chính thức";
            this.TeacherList_item.Click += new System.EventHandler(this.TeacherListManagementToolStripMenuItem_Click);
            // 
            // AppliedTeacherList_item
            // 
            this.AppliedTeacherList_item.Name = "AppliedTeacherList_item";
            this.AppliedTeacherList_item.Size = new System.Drawing.Size(240, 22);
            this.AppliedTeacherList_item.Text = "Danh sách giáo viên ứng tuyển";
            this.AppliedTeacherList_item.Click += new System.EventHandler(this.AppliedListToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassList_item,
            this.ConstrucClassList_item});
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            // 
            // ClassList_item
            // 
            this.ClassList_item.Name = "ClassList_item";
            this.ClassList_item.Size = new System.Drawing.Size(223, 22);
            this.ClassList_item.Text = "Danh sách lớp đã khai giảng";
            this.ClassList_item.Click += new System.EventHandler(this.ActiveClassMenuItem_Click);
            // 
            // ConstrucClassList_item
            // 
            this.ConstrucClassList_item.Name = "ConstrucClassList_item";
            this.ConstrucClassList_item.Size = new System.Drawing.Size(223, 22);
            this.ConstrucClassList_item.Text = "Danh sách lớp khởi tạo";
            this.ConstrucClassList_item.Click += new System.EventHandler(this.EmptyClassMenuItem_Click);
            // 
            // họcSinhToolStripMenuItem
            // 
            this.họcSinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllStudentListItem,
            this.StudentListOnClass});
            this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            this.họcSinhToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.họcSinhToolStripMenuItem.Text = "Học sinh";
            // 
            // AllStudentListItem
            // 
            this.AllStudentListItem.Name = "AllStudentListItem";
            this.AllStudentListItem.Size = new System.Drawing.Size(252, 22);
            this.AllStudentListItem.Text = "Quản lý danh sách tất cả học sinh";
            this.AllStudentListItem.Click += new System.EventHandler(this.AllStudentList_Click);
            // 
            // StudentListOnClass
            // 
            this.StudentListOnClass.Name = "StudentListOnClass";
            this.StudentListOnClass.Size = new System.Drawing.Size(252, 22);
            this.StudentListOnClass.Text = "Danh sách theo lớp";
            this.StudentListOnClass.Click += new System.EventHandler(this.StudentListOnClass_Click);
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.hợpĐồngToolStripMenuItem.Text = "Quản lý hợp đồng";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.ContractManagementItem_Click);
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.Name = "AccountMenuItem";
            this.AccountMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountMenuItem.Size = new System.Drawing.Size(82, 20);
            this.AccountMenuItem.Text = "Tài khoản";
            this.AccountMenuItem.Click += new System.EventHandler(this.AccountMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 579);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.ClassTree);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 364);
            this.panel4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 10);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ClassTree
            // 
            this.ClassTree.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClassTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassTree.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTree.ForeColor = System.Drawing.SystemColors.Window;
            this.ClassTree.ImageIndex = 0;
            this.ClassTree.ImageList = this.SubjectImageList;
            this.ClassTree.LineColor = System.Drawing.Color.Snow;
            this.ClassTree.Location = new System.Drawing.Point(0, 0);
            this.ClassTree.Name = "ClassTree";
            this.ClassTree.SelectedImageIndex = 0;
            this.ClassTree.Size = new System.Drawing.Size(400, 364);
            this.ClassTree.TabIndex = 4;
            // 
            // SubjectImageList
            // 
            this.SubjectImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SubjectImageList.ImageStream")));
            this.SubjectImageList.TransparentColor = System.Drawing.Color.White;
            this.SubjectImageList.Images.SetKeyName(0, "BookIcon.ico");
            this.SubjectImageList.Images.SetKeyName(1, "Book1.ico");
            this.SubjectImageList.Images.SetKeyName(2, "Book2.ico");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Temp_dgv);
            this.panel3.Controls.Add(this.LogOutBtn);
            this.panel3.Controls.Add(this.DisplayName_lbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 99);
            this.panel3.TabIndex = 4;
            // 
            // Temp_dgv
            // 
            this.Temp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Temp_dgv.Location = new System.Drawing.Point(196, 50);
            this.Temp_dgv.Name = "Temp_dgv";
            this.Temp_dgv.Size = new System.Drawing.Size(19, 12);
            this.Temp_dgv.TabIndex = 2;
            this.Temp_dgv.Visible = false;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Red;
            this.LogOutBtn.ForeColor = System.Drawing.Color.Yellow;
            this.LogOutBtn.Location = new System.Drawing.Point(12, 50);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(91, 35);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "Đăng xuất";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // DisplayName_lbl
            // 
            this.DisplayName_lbl.AutoSize = true;
            this.DisplayName_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.DisplayName_lbl.Location = new System.Drawing.Point(140, 13);
            this.DisplayName_lbl.Name = "DisplayName_lbl";
            this.DisplayName_lbl.Size = new System.Drawing.Size(66, 22);
            this.DisplayName_lbl.TabIndex = 0;
            this.DisplayName_lbl.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản trị viên:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 10);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 112);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "TTCT";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(404, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 579);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.Total_Female_lbl);
            this.panel7.Controls.Add(this.TotalMale_lbl);
            this.panel7.Controls.Add(this.TotalStudent_lbl);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 470);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(962, 109);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.FemaleInClass_lbl);
            this.panel8.Controls.Add(this.MaleInClass_lbl);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.ClassListCbx);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(558, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 105);
            this.panel8.TabIndex = 7;
            // 
            // FemaleInClass_lbl
            // 
            this.FemaleInClass_lbl.AutoSize = true;
            this.FemaleInClass_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleInClass_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.FemaleInClass_lbl.Location = new System.Drawing.Point(364, 59);
            this.FemaleInClass_lbl.Name = "FemaleInClass_lbl";
            this.FemaleInClass_lbl.Size = new System.Drawing.Size(20, 22);
            this.FemaleInClass_lbl.TabIndex = 9;
            this.FemaleInClass_lbl.Text = "0";
            // 
            // MaleInClass_lbl
            // 
            this.MaleInClass_lbl.AutoSize = true;
            this.MaleInClass_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleInClass_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.MaleInClass_lbl.Location = new System.Drawing.Point(78, 59);
            this.MaleInClass_lbl.Name = "MaleInClass_lbl";
            this.MaleInClass_lbl.Size = new System.Drawing.Size(20, 22);
            this.MaleInClass_lbl.TabIndex = 10;
            this.MaleInClass_lbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(319, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nữ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(24, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nam:";
            // 
            // ClassListCbx
            // 
            this.ClassListCbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassListCbx.FormattingEnabled = true;
            this.ClassListCbx.Location = new System.Drawing.Point(163, 13);
            this.ClassListCbx.Name = "ClassListCbx";
            this.ClassListCbx.Size = new System.Drawing.Size(222, 27);
            this.ClassListCbx.TabIndex = 8;
            this.ClassListCbx.SelectedValueChanged += new System.EventHandler(this.ClassListCbx_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lựa chọn lớp:";
            // 
            // Total_Female_lbl
            // 
            this.Total_Female_lbl.AutoSize = true;
            this.Total_Female_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Female_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.Total_Female_lbl.Location = new System.Drawing.Point(161, 66);
            this.Total_Female_lbl.Name = "Total_Female_lbl";
            this.Total_Female_lbl.Size = new System.Drawing.Size(20, 22);
            this.Total_Female_lbl.TabIndex = 1;
            this.Total_Female_lbl.Text = "0";
            // 
            // TotalMale_lbl
            // 
            this.TotalMale_lbl.AutoSize = true;
            this.TotalMale_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMale_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.TotalMale_lbl.Location = new System.Drawing.Point(72, 66);
            this.TotalMale_lbl.Name = "TotalMale_lbl";
            this.TotalMale_lbl.Size = new System.Drawing.Size(20, 22);
            this.TotalMale_lbl.TabIndex = 1;
            this.TotalMale_lbl.Text = "0";
            // 
            // TotalStudent_lbl
            // 
            this.TotalStudent_lbl.AutoSize = true;
            this.TotalStudent_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudent_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.TotalStudent_lbl.Location = new System.Drawing.Point(169, 21);
            this.TotalStudent_lbl.Name = "TotalStudent_lbl";
            this.TotalStudent_lbl.Size = new System.Drawing.Size(20, 22);
            this.TotalStudent_lbl.TabIndex = 1;
            this.TotalStudent_lbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(120, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nữ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số học sinh:";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(962, 579);
            this.panel6.TabIndex = 0;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 603);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trung tâm luyện thi Thầy Thành, Cô Thời - Menu quản lý trung tâm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Temp_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TeacherList_item;
        private System.Windows.Forms.ToolStripMenuItem AppliedTeacherList_item;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassList_item;
        private System.Windows.Forms.ToolStripMenuItem ConstrucClassList_item;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllStudentListItem;
        private System.Windows.Forms.ToolStripMenuItem StudentListOnClass;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView ClassTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DisplayName_lbl;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TotalMale_lbl;
        private System.Windows.Forms.Label TotalStudent_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total_Female_lbl;
        private System.Windows.Forms.DataGridView Temp_dgv;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label FemaleInClass_lbl;
        private System.Windows.Forms.Label MaleInClass_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ClassListCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList SubjectImageList;
    }
}