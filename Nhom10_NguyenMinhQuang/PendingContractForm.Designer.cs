
namespace Nhom10_NguyenMinhQuang
{
    partial class PendingContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingContractForm));
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDNumberTxb = new System.Windows.Forms.TextBox();
            this.IssuedDateDTP = new System.Windows.Forms.DateTimePicker();
            this.DurationTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.SalaryTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTimeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AcceptBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptBtn.Location = new System.Drawing.Point(245, 92);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(185, 46);
            this.AcceptBtn.TabIndex = 67;
            this.AcceptBtn.Text = "Phê duyệt/ Cấp hợp đồng";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            this.AcceptBtn.MouseEnter += new System.EventHandler(this.AcceptBtn_MouseEnter);
            this.AcceptBtn.MouseLeave += new System.EventHandler(this.AcceptBtn_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ngày cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mã GV/ Số CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Thời hạn hợp đồng (tháng):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(363, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Lương theo buổi:";
            // 
            // IDNumberTxb
            // 
            this.IDNumberTxb.Location = new System.Drawing.Point(158, 6);
            this.IDNumberTxb.Name = "IDNumberTxb";
            this.IDNumberTxb.ReadOnly = true;
            this.IDNumberTxb.Size = new System.Drawing.Size(140, 26);
            this.IDNumberTxb.TabIndex = 68;
            // 
            // IssuedDateDTP
            // 
            this.IssuedDateDTP.CustomFormat = "dd/MM/yyyy";
            this.IssuedDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssuedDateDTP.Location = new System.Drawing.Point(158, 53);
            this.IssuedDateDTP.Name = "IssuedDateDTP";
            this.IssuedDateDTP.Size = new System.Drawing.Size(140, 26);
            this.IssuedDateDTP.TabIndex = 69;
            // 
            // DurationTimeNUD
            // 
            this.DurationTimeNUD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationTimeNUD.Location = new System.Drawing.Point(588, 13);
            this.DurationTimeNUD.Name = "DurationTimeNUD";
            this.DurationTimeNUD.Size = new System.Drawing.Size(48, 26);
            this.DurationTimeNUD.TabIndex = 71;
            // 
            // SalaryTxb
            // 
            this.SalaryTxb.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SalaryTxb.Location = new System.Drawing.Point(519, 53);
            this.SalaryTxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SalaryTxb.Name = "SalaryTxb";
            this.SalaryTxb.Size = new System.Drawing.Size(117, 26);
            this.SalaryTxb.TabIndex = 70;
            // 
            // PendingContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(706, 141);
            this.Controls.Add(this.DurationTimeNUD);
            this.Controls.Add(this.SalaryTxb);
            this.Controls.Add(this.IssuedDateDTP);
            this.Controls.Add(this.IDNumberTxb);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PendingContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phê duyệt giáo viên";
            ((System.ComponentModel.ISupportInitialize)(this.DurationTimeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker IssuedDateDTP;
        public System.Windows.Forms.NumericUpDown DurationTimeNUD;
        public System.Windows.Forms.TextBox SalaryTxb;
        public System.Windows.Forms.TextBox IDNumberTxb;
    }
}