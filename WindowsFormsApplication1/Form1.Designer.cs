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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.register.Location = new System.Drawing.Point(219, 383);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(150, 34);
            this.register.TabIndex = 12;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password.Location = new System.Drawing.Point(65, 302);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 20);
            this.password.TabIndex = 11;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.username.Location = new System.Drawing.Point(65, 241);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(84, 20);
            this.username.TabIndex = 10;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.login.Location = new System.Drawing.Point(59, 383);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 34);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // sign_in
            // 
            this.sign_in.AutoEllipsis = true;
            this.sign_in.AutoSize = true;
            this.sign_in.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sign_in.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sign_in.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sign_in.Location = new System.Drawing.Point(158, 167);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(132, 44);
            this.sign_in.TabIndex = 8;
            this.sign_in.Text = "Sign In";
            this.sign_in.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label sign_in;
    }
}

