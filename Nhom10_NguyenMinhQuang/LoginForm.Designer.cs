
using System;

namespace Nhom10_NguyenMinhQuang
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Title = new System.Windows.Forms.Label();
            this.Slogan = new System.Windows.Forms.Label();
            this.UsernameTxb = new System.Windows.Forms.TextBox();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(142, 55);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(393, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Trung tâm thầy Thành - cô Thời";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Slogan.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Slogan.Location = new System.Drawing.Point(217, 441);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(241, 22);
            this.Slogan.TabIndex = 0;
            this.Slogan.Text = "Học chủ động, sống tích cực!";
            // 
            // UsernameTxb
            // 
            this.UsernameTxb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameTxb.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.UsernameTxb.Location = new System.Drawing.Point(329, 198);
            this.UsernameTxb.Name = "UsernameTxb";
            this.UsernameTxb.Size = new System.Drawing.Size(254, 29);
            this.UsernameTxb.TabIndex = 1;
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordTxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxb.Location = new System.Drawing.Point(329, 258);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.PasswordChar = '*';
            this.PasswordTxb.Size = new System.Drawing.Size(254, 29);
            this.PasswordTxb.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.Location = new System.Drawing.Point(132, 198);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(156, 27);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Tên đăng nhập";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(132, 261);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(156, 27);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Mật khẩu";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LogInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInButton.Location = new System.Drawing.Point(279, 313);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(151, 48);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Đăng nhập";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Nhom10_NguyenMinhQuang.Properties.Resources.AnhBia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 478);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTxb);
            this.Controls.Add(this.UsernameTxb);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cổng đăng nhập quản lý Trung tâm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (UsernameTxb.Text == "Enter text here...")
            {
                UsernameTxb.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxb.Text))
                UsernameTxb.Text = "Enter text here...";
        }
        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.TextBox UsernameTxb;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogInButton;
    }
}

