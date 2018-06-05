namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newp = new System.Windows.Forms.TextBox();
            this.current = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(278, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "X 此行不能為空白";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(278, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "X 此行不能為空白";
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(278, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "X 密碼與上述不符";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(291, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "__________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 46;
            this.label4.Text = "__________";
            // 
            // confirmp
            // 
            this.confirmp.Location = new System.Drawing.Point(68, 312);
            this.confirmp.Name = "confirmp";
            this.confirmp.PasswordChar = '*';
            this.confirmp.Size = new System.Drawing.Size(310, 22);
            this.confirmp.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(64, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Confirm Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "To change your password,  provide the following ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newp
            // 
            this.newp.Location = new System.Drawing.Point(68, 252);
            this.newp.Name = "newp";
            this.newp.PasswordChar = '*';
            this.newp.Size = new System.Drawing.Size(310, 22);
            this.newp.TabIndex = 40;
            // 
            // current
            // 
            this.current.Location = new System.Drawing.Point(68, 197);
            this.current.Name = "current";
            this.current.PasswordChar = '*';
            this.current.Size = new System.Drawing.Size(310, 22);
            this.current.TabIndex = 39;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password1.Location = new System.Drawing.Point(64, 229);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(122, 20);
            this.password1.TabIndex = 38;
            this.password1.Text = "New Password:";
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.email1.Location = new System.Drawing.Point(64, 174);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(150, 20);
            this.email1.TabIndex = 37;
            this.email1.Text = "Current Password: ";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok.Location = new System.Drawing.Point(276, 365);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 34);
            this.ok.TabIndex = 36;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // reg
            // 
            this.reg.AutoEllipsis = true;
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reg.Location = new System.Drawing.Point(67, 34);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(297, 47);
            this.reg.TabIndex = 35;
            this.reg.Text = "Account Setting";
            this.reg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "infomation, and then click OK.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(64, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "E-mail Address:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.Location = new System.Drawing.Point(208, 137);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(189, 24);
            this.email.TabIndex = 55;
            this.email.Text = "abc@gmail.com       ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(278, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "X 密碼不正確";
            this.label10.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newp);
            this.Controls.Add(this.current);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newp;
        private System.Windows.Forms.TextBox current;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label10;
    }
}