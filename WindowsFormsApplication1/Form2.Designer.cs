namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(80, 331);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(412, 25);
            this.password.TabIndex = 21;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(80, 262);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(412, 25);
            this.email.TabIndex = 20;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password1.Location = new System.Drawing.Point(80, 300);
            this.password1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(102, 25);
            this.password1.TabIndex = 18;
            this.password1.Text = "Password";
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.email1.Location = new System.Drawing.Point(80, 231);
            this.email1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(72, 25);
            this.email1.TabIndex = 17;
            this.email1.Text = "E-mail";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup.Location = new System.Drawing.Point(293, 494);
            this.signup.Margin = new System.Windows.Forms.Padding(4);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(200, 42);
            this.signup.TabIndex = 16;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // reg
            // 
            this.reg.AutoEllipsis = true;
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reg.Location = new System.Drawing.Point(183, 41);
            this.reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(204, 59);
            this.reg.TabIndex = 15;
            this.reg.Text = "Register";
            this.reg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Create yout account. It\'s free and only take a minutes.";
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(80, 406);
            this.confirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '*';
            this.confirmpassword.Size = new System.Drawing.Size(412, 25);
            this.confirmpassword.TabIndex = 24;
            this.confirmpassword.TextChanged += new System.EventHandler(this.confirmpassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(80, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Confirm Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(80, 194);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(412, 25);
            this.username.TabIndex = 26;
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.username1.Location = new System.Drawing.Point(80, 162);
            this.username1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(107, 25);
            this.username1.TabIndex = 25;
            this.username1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 43);
            this.label4.TabIndex = 27;
            this.label4.Text = "__________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(389, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 43);
            this.label5.TabIndex = 28;
            this.label5.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(271, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "X 密碼與上述不符";
            this.label3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(195, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "X 此行不能為空白";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(169, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "X 此行不能為空白";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(189, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "X 此行不能為空白";
            this.label8.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 576);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.reg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}