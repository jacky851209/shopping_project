namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.password1 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_error1 = new System.Windows.Forms.Label();
            this.login_error2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(151, 305);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(218, 22);
            this.password.TabIndex = 14;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(151, 246);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 22);
            this.email.TabIndex = 13;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(225, 383);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(150, 38);
            this.register.TabIndex = 12;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password1.Location = new System.Drawing.Point(65, 307);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(80, 20);
            this.password1.TabIndex = 11;
            this.password1.Text = "Password";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.username1.Location = new System.Drawing.Point(65, 246);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(57, 20);
            this.username1.TabIndex = 10;
            this.username1.Text = "E-mail";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(63, 383);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 38);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // sign_in
            // 
            this.sign_in.AutoEllipsis = true;
            this.sign_in.AutoSize = true;
            this.sign_in.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sign_in.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sign_in.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sign_in.Location = new System.Drawing.Point(160, 167);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(132, 44);
            this.sign_in.TabIndex = 8;
            this.sign_in.Text = "Sign In";
            this.sign_in.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.login_icon3;
            this.pictureBox1.Location = new System.Drawing.Point(160, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // login_error1
            // 
            this.login_error1.AutoSize = true;
            this.login_error1.ForeColor = System.Drawing.Color.Red;
            this.login_error1.Location = new System.Drawing.Point(149, 231);
            this.login_error1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_error1.Name = "login_error1";
            this.login_error1.Size = new System.Drawing.Size(64, 12);
            this.login_error1.TabIndex = 30;
            this.login_error1.Text = "X 無此帳號";
            this.login_error1.Visible = false;
            // 
            // login_error2
            // 
            this.login_error2.AutoSize = true;
            this.login_error2.ForeColor = System.Drawing.Color.Red;
            this.login_error2.Location = new System.Drawing.Point(149, 290);
            this.login_error2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_error2.Name = "login_error2";
            this.login_error2.Size = new System.Drawing.Size(76, 12);
            this.login_error2.TabIndex = 31;
            this.login_error2.Text = "X 密碼不正確";
            this.login_error2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.login_error2);
            this.Controls.Add(this.login_error1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.register);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.sign_in);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label sign_in;
        private System.Windows.Forms.Label login_error1;
        private System.Windows.Forms.Label login_error2;
    }
}

