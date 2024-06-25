namespace LoginTest
{
    partial class frmDangKy
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(251, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 32);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 232);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 32);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(133, 26);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(289, 39);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Đăng ký tài khoản";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(185, 167);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(269, 22);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(39, 167);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 20);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Mật Khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(39, 123);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Email";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(185, 85);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(269, 22);
            this.txtMaNhanVien.TabIndex = 15;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(39, 83);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(114, 20);
            this.lblMaNhanVien.TabIndex = 14;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 290);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
    }
}