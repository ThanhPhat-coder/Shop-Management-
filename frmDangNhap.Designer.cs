namespace LoginTest
{
    partial class frmDangNhap
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbShowPassWord = new System.Windows.Forms.CheckBox();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(298, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(389, 39);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Đăng nhập vào hệ thống";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(273, 327);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(273, 372);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 20);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật Khẩu";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(380, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(380, 370);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(269, 22);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(534, 438);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(380, 438);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 32);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(859, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbShowPassWord
            // 
            this.cbShowPassWord.AutoSize = true;
            this.cbShowPassWord.Location = new System.Drawing.Point(380, 401);
            this.cbShowPassWord.Name = "cbShowPassWord";
            this.cbShowPassWord.Size = new System.Drawing.Size(130, 20);
            this.cbShowPassWord.TabIndex = 8;
            this.cbShowPassWord.Text = "Hiển thị mật khẩu";
            this.cbShowPassWord.UseVisualStyleBackColor = true;
            this.cbShowPassWord.CheckedChanged += new System.EventHandler(this.cbShowPassWord_CheckedChanged);
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::LoginTest.Properties.Resources._5a489f6a5e82467e47d57d0959f91488;
            this.ptbImage.Location = new System.Drawing.Point(305, 51);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(382, 270);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 9;
            this.ptbImage.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 525);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.cbShowPassWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmLogin";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbShowPassWord;
        private System.Windows.Forms.PictureBox ptbImage;
    }
}

