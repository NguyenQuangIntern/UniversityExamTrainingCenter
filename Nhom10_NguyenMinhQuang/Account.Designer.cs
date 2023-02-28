
namespace Nhom10_NguyenMinhQuang
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountListDgv = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.OptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionPanel
            // 
            this.OptionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionPanel.BackgroundImage")));
            this.OptionPanel.Controls.Add(this.Password);
            this.OptionPanel.Controls.Add(this.DisplayName);
            this.OptionPanel.Controls.Add(this.label1);
            this.OptionPanel.Controls.Add(this.label4);
            this.OptionPanel.Controls.Add(this.LoginName);
            this.OptionPanel.Controls.Add(this.label2);
            this.OptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(909, 45);
            this.OptionPanel.TabIndex = 49;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Password.Location = new System.Drawing.Point(655, 4);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(151, 26);
            this.Password.TabIndex = 53;
            // 
            // DisplayName
            // 
            this.DisplayName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DisplayName.Location = new System.Drawing.Point(382, 4);
            this.DisplayName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(153, 26);
            this.DisplayName.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(570, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(287, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tên hiển thị:";
            // 
            // LoginName
            // 
            this.LoginName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LoginName.Location = new System.Drawing.Point(124, 6);
            this.LoginName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(148, 26);
            this.LoginName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // AccountListDgv
            // 
            this.AccountListDgv.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            this.AccountListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountListDgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AccountListDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AccountListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountListDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.TenHienThi,
            this.MatKhau});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountListDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccountListDgv.Location = new System.Drawing.Point(0, 45);
            this.AccountListDgv.Margin = new System.Windows.Forms.Padding(2);
            this.AccountListDgv.Name = "AccountListDgv";
            this.AccountListDgv.RowHeadersWidth = 51;
            this.AccountListDgv.RowTemplate.Height = 24;
            this.AccountListDgv.Size = new System.Drawing.Size(909, 238);
            this.AccountListDgv.TabIndex = 50;
            this.AccountListDgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.AccountListDgv_RowPostPaint);
            this.AccountListDgv.SelectionChanged += new System.EventHandler(this.AccountListDgv_SelectionChanged);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.TenDangNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 200;
            // 
            // TenHienThi
            // 
            this.TenHienThi.DataPropertyName = "TenHienThi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.TenHienThi.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenHienThi.HeaderText = "Tên hiển thị";
            this.TenHienThi.MinimumWidth = 6;
            this.TenHienThi.Name = "TenHienThi";
            this.TenHienThi.Width = 275;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.MatKhau.DefaultCellStyle = dataGridViewCellStyle5;
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 400;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(10, 306);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(66, 41);
            this.AddBtn.TabIndex = 53;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBtn.Location = new System.Drawing.Point(110, 305);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(66, 41);
            this.EditBtn.TabIndex = 52;
            this.EditBtn.Text = "Sửa";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(211, 306);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(66, 41);
            this.DeleteBtn.TabIndex = 51;
            this.DeleteBtn.Text = "Xóa";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.Location = new System.Drawing.Point(317, 305);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(166, 41);
            this.BackBtn.TabIndex = 54;
            this.BackBtn.Text = "Quay lại ";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 348);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AccountListDgv);
            this.Controls.Add(this.OptionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh sách tài khoản";
            this.Load += new System.EventHandler(this.Account_Load);
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AccountListDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}