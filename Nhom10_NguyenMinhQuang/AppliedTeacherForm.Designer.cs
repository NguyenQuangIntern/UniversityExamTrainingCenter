
namespace Nhom10_NguyenMinhQuang
{
    partial class AppliedTeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppliedTeacherForm));
            this.DataPanel = new System.Windows.Forms.Panel();
            this.TeacherListDgv = new System.Windows.Forms.DataGridView();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoNamKinhNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Option_cbx = new System.Windows.Forms.ComboBox();
            this.ExperienceNumUD = new System.Windows.Forms.NumericUpDown();
            this.SubjectListCbx = new System.Windows.Forms.ComboBox();
            this.GenderCbx = new System.Windows.Forms.ComboBox();
            this.DateBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumberTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FullNameTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumberTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherListDgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.TeacherListDgv);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 84);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1415, 322);
            this.DataPanel.TabIndex = 49;
            // 
            // TeacherListDgv
            // 
            this.TeacherListDgv.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            this.TeacherListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeacherListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherListDgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TeacherListDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeacherListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherListDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCMND,
            this.TenGV,
            this.NgaySinh,
            this.SoDT,
            this.GioiTinh,
            this.SoNamKinhNghiem,
            this.MonHoc});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherListDgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.TeacherListDgv.Location = new System.Drawing.Point(0, 7);
            this.TeacherListDgv.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherListDgv.Name = "TeacherListDgv";
            this.TeacherListDgv.RowHeadersWidth = 51;
            this.TeacherListDgv.RowTemplate.Height = 24;
            this.TeacherListDgv.Size = new System.Drawing.Size(1415, 315);
            this.TeacherListDgv.TabIndex = 29;
            this.TeacherListDgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.TeacherListDgv_RowPostPaint);
            this.TeacherListDgv.SelectionChanged += new System.EventHandler(this.TeacherListDgv_SelectionChanged);
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SoCMND.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoCMND.HeaderText = "Số căn cước/CMND";
            this.SoCMND.MinimumWidth = 6;
            this.SoCMND.Name = "SoCMND";
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.TenGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenGV.HeaderText = "Họ và tên ";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgaySinh.HeaderText = "Ngày, tháng, năm sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SoDT
            // 
            this.SoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDT.DataPropertyName = "SoDT";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoDT.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GioiTinh.TrueValue = "True";
            // 
            // SoNamKinhNghiem
            // 
            this.SoNamKinhNghiem.DataPropertyName = "SoNamKinhNghiem";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoNamKinhNghiem.DefaultCellStyle = dataGridViewCellStyle7;
            this.SoNamKinhNghiem.HeaderText = "Số năm kinh nghiệm";
            this.SoNamKinhNghiem.Name = "SoNamKinhNghiem";
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "MonHoc";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.MonHoc.DefaultCellStyle = dataGridViewCellStyle8;
            this.MonHoc.HeaderText = "Giảng dạy môn";
            this.MonHoc.Name = "MonHoc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Controls.Add(this.EditBtn);
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Controls.Add(this.AcceptBtn);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1415, 52);
            this.panel3.TabIndex = 50;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(48, 5);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(66, 41);
            this.AddBtn.TabIndex = 47;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseEnter += new System.EventHandler(this.AddBtn_MouseEnter);
            this.AddBtn.MouseLeave += new System.EventHandler(this.AddBtn_MouseLeave);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBtn.Location = new System.Drawing.Point(148, 4);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(66, 41);
            this.EditBtn.TabIndex = 46;
            this.EditBtn.Text = "Sửa";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            this.EditBtn.MouseEnter += new System.EventHandler(this.EditBtn_MouseEnter);
            this.EditBtn.MouseLeave += new System.EventHandler(this.EditBtn_MouseLeave);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.Location = new System.Drawing.Point(560, 5);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(166, 41);
            this.BackBtn.TabIndex = 45;
            this.BackBtn.Text = "Quay lại ";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
            this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AcceptBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptBtn.Location = new System.Drawing.Point(356, 5);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(186, 41);
            this.AcceptBtn.TabIndex = 45;
            this.AcceptBtn.Text = "Phê duyệt/ Cấp hợp đồng";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            this.AcceptBtn.MouseEnter += new System.EventHandler(this.AcceptBtn_MouseEnter);
            this.AcceptBtn.MouseLeave += new System.EventHandler(this.AcceptBtn_MouseLeave);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(249, 5);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(66, 41);
            this.DeleteBtn.TabIndex = 45;
            this.DeleteBtn.Text = "Xóa";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseEnter += new System.EventHandler(this.DeleteBtn_MouseEnter);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            // 
            // OptionPanel
            // 
            this.OptionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionPanel.BackgroundImage")));
            this.OptionPanel.Controls.Add(this.panel4);
            this.OptionPanel.Controls.Add(this.Option_cbx);
            this.OptionPanel.Controls.Add(this.ExperienceNumUD);
            this.OptionPanel.Controls.Add(this.SubjectListCbx);
            this.OptionPanel.Controls.Add(this.GenderCbx);
            this.OptionPanel.Controls.Add(this.DateBirthDTP);
            this.OptionPanel.Controls.Add(this.PhoneNumberTxb);
            this.OptionPanel.Controls.Add(this.label1);
            this.OptionPanel.Controls.Add(this.label4);
            this.OptionPanel.Controls.Add(this.label6);
            this.OptionPanel.Controls.Add(this.label7);
            this.OptionPanel.Controls.Add(this.label5);
            this.OptionPanel.Controls.Add(this.FullNameTxb);
            this.OptionPanel.Controls.Add(this.label3);
            this.OptionPanel.Controls.Add(this.IDNumberTxb);
            this.OptionPanel.Controls.Add(this.label2);
            this.OptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(1415, 84);
            this.OptionPanel.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.SearchIcon);
            this.panel4.Controls.Add(this.SearchBox);
            this.panel4.Location = new System.Drawing.Point(53, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 26);
            this.panel4.TabIndex = 61;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIcon.BackgroundImage")));
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchIcon.Location = new System.Drawing.Point(211, 0);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(40, 26);
            this.SearchIcon.TabIndex = 61;
            this.SearchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(283, 26);
            this.SearchBox.TabIndex = 60;
            this.SearchBox.Text = "Tìm kiếm giáo viên theo họ tên...";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Option_cbx
            // 
            this.Option_cbx.DisplayMember = "(none)";
            this.Option_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option_cbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Option_cbx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Option_cbx.FormattingEnabled = true;
            this.Option_cbx.Items.AddRange(new object[] {
            "Danh sách tất cả giáo viên",
            "Sắp xếp theo tuổi tăng dần",
            "Sắp xếp theo tuổi giảm dần",
            "Lọc theo giới tính: \"Nam\"",
            "Lọc theo giới tính: \"Nữ\"",
            "Số năm kinh nghiệm thấp đến cao",
            "Số năm kinh nghiệm cao xuống thấp"});
            this.Option_cbx.Location = new System.Drawing.Point(53, 48);
            this.Option_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Option_cbx.Name = "Option_cbx";
            this.Option_cbx.Size = new System.Drawing.Size(251, 27);
            this.Option_cbx.TabIndex = 60;
            this.Option_cbx.SelectedIndexChanged += new System.EventHandler(this.Option_cbx_SelectedIndexChanged);
            // 
            // ExperienceNumUD
            // 
            this.ExperienceNumUD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperienceNumUD.Location = new System.Drawing.Point(962, 49);
            this.ExperienceNumUD.Name = "ExperienceNumUD";
            this.ExperienceNumUD.Size = new System.Drawing.Size(53, 26);
            this.ExperienceNumUD.TabIndex = 58;
            // 
            // SubjectListCbx
            // 
            this.SubjectListCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectListCbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubjectListCbx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SubjectListCbx.FormattingEnabled = true;
            this.SubjectListCbx.Location = new System.Drawing.Point(1155, 11);
            this.SubjectListCbx.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectListCbx.Name = "SubjectListCbx";
            this.SubjectListCbx.Size = new System.Drawing.Size(108, 27);
            this.SubjectListCbx.TabIndex = 57;
            // 
            // GenderCbx
            // 
            this.GenderCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenderCbx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.GenderCbx.FormattingEnabled = true;
            this.GenderCbx.Items.AddRange(new object[] {
            "Nam\t",
            "Nữ"});
            this.GenderCbx.Location = new System.Drawing.Point(961, 13);
            this.GenderCbx.Margin = new System.Windows.Forms.Padding(2);
            this.GenderCbx.Name = "GenderCbx";
            this.GenderCbx.Size = new System.Drawing.Size(53, 27);
            this.GenderCbx.TabIndex = 57;
            // 
            // DateBirthDTP
            // 
            this.DateBirthDTP.CustomFormat = "dd/MM/yyyy";
            this.DateBirthDTP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DateBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateBirthDTP.Location = new System.Drawing.Point(641, 52);
            this.DateBirthDTP.Margin = new System.Windows.Forms.Padding(2);
            this.DateBirthDTP.Name = "DateBirthDTP";
            this.DateBirthDTP.Size = new System.Drawing.Size(164, 26);
            this.DateBirthDTP.TabIndex = 56;
            // 
            // PhoneNumberTxb
            // 
            this.PhoneNumberTxb.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PhoneNumberTxb.Location = new System.Drawing.Point(404, 47);
            this.PhoneNumberTxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PhoneNumberTxb.Name = "PhoneNumberTxb";
            this.PhoneNumberTxb.Size = new System.Drawing.Size(138, 26);
            this.PhoneNumberTxb.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(811, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Số năm kinh nghiệm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(320, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "SĐT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1035, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Giảng dạy môn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(811, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(555, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày sinh:";
            // 
            // FullNameTxb
            // 
            this.FullNameTxb.AcceptsReturn = true;
            this.FullNameTxb.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FullNameTxb.Location = new System.Drawing.Point(641, 13);
            this.FullNameTxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FullNameTxb.Name = "FullNameTxb";
            this.FullNameTxb.Size = new System.Drawing.Size(162, 26);
            this.FullNameTxb.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(556, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Họ tên:";
            // 
            // IDNumberTxb
            // 
            this.IDNumberTxb.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.IDNumberTxb.Location = new System.Drawing.Point(404, 11);
            this.IDNumberTxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDNumberTxb.Name = "IDNumberTxb";
            this.IDNumberTxb.Size = new System.Drawing.Size(138, 26);
            this.IDNumberTxb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(317, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Số CMND:";
            // 
            // AppliedTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1415, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.OptionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppliedTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giáo viên ứng tuyển";
            this.Load += new System.EventHandler(this.TeacherListForm_Load);
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherListDgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceNumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox Option_cbx;
        private System.Windows.Forms.NumericUpDown ExperienceNumUD;
        private System.Windows.Forms.ComboBox SubjectListCbx;
        private System.Windows.Forms.ComboBox GenderCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDNumberTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.DataGridView TeacherListDgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNamKinhNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.Button AcceptBtn;
        public System.Windows.Forms.DateTimePicker DateBirthDTP;
        private System.Windows.Forms.TextBox PhoneNumberTxb;
        private System.Windows.Forms.TextBox FullNameTxb;
    }
}