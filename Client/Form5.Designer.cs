namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.users = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_pass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.found = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.users.ForeColor = System.Drawing.Color.Maroon;
            this.users.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.users.Location = new System.Drawing.Point(13, 201);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(464, 37);
            this.users.TabIndex = 13;
            this.users.Text = "username";
            this.users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label1.Location = new System.Drawing.Point(63, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "使用者帳號:";
            // 
            // update_pass
            // 
            this.update_pass.BackColor = System.Drawing.Color.Cornsilk;
            this.update_pass.FlatAppearance.BorderSize = 0;
            this.update_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_pass.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.update_pass.Location = new System.Drawing.Point(12, 284);
            this.update_pass.Name = "update_pass";
            this.update_pass.Size = new System.Drawing.Size(465, 33);
            this.update_pass.TabIndex = 18;
            this.update_pass.Text = "        變更密碼                                      >";
            this.update_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_pass.UseVisualStyleBackColor = false;
            this.update_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "______________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.face_photo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(182, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.back1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 190);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.email.Location = new System.Drawing.Point(189, 248);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(180, 28);
            this.email.TabIndex = 25;
            this.email.Text = "abc@gmail.com";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Cornsilk;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.logout.ForeColor = System.Drawing.Color.Red;
            this.logout.Location = new System.Drawing.Point(12, 487);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(465, 34);
            this.logout.TabIndex = 26;
            this.logout.Text = "                                登出 ";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "______________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "______________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(8, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "______________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(8, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "______________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(6, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(473, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "______________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(6, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(473, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "______________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(473, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "______________________________________________";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(465, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "        變更頭貼                                      >";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // found
            // 
            this.found.BackColor = System.Drawing.Color.Cornsilk;
            this.found.FlatAppearance.BorderSize = 0;
            this.found.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.found.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.found.Location = new System.Drawing.Point(12, 366);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(465, 33);
            this.found.TabIndex = 36;
            this.found.Text = "        訂單查詢                                      >";
            this.found.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.found.UseVisualStyleBackColor = false;
            this.found.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.found);
            this.Controls.Add(this.update_pass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.users);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_pass;
        public System.Windows.Forms.Label users;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label email;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button found;
    }
}