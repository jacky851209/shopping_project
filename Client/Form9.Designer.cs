namespace WindowsFormsApplication1
{
    partial class Form9
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
            this.email = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pro_price = new System.Windows.Forms.Label();
            this.new_info = new System.Windows.Forms.TextBox();
            this.pro_info = new System.Windows.Forms.Label();
            this.pro_name = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pro_name1 = new System.Windows.Forms.Label();
            this.pro_info1 = new System.Windows.Forms.Label();
            this.pro_price1 = new System.Windows.Forms.Label();
            this.Quantity1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.new_price = new System.Windows.Forms.NumericUpDown();
            this.new_qua = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.new_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_qua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.Location = new System.Drawing.Point(146, 90);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(160, 20);
            this.email.TabIndex = 73;
            this.email.Text = "abc@gmail.com       ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(23, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "E-mail Address:";
            // 
            // pro_price
            // 
            this.pro_price.AutoSize = true;
            this.pro_price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pro_price.Location = new System.Drawing.Point(23, 217);
            this.pro_price.Name = "pro_price";
            this.pro_price.Size = new System.Drawing.Size(50, 20);
            this.pro_price.TabIndex = 64;
            this.pro_price.Text = "Price:";
            // 
            // new_info
            // 
            this.new_info.Location = new System.Drawing.Point(143, 193);
            this.new_info.Name = "new_info";
            this.new_info.Size = new System.Drawing.Size(203, 22);
            this.new_info.TabIndex = 62;
            // 
            // pro_info
            // 
            this.pro_info.AutoSize = true;
            this.pro_info.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pro_info.Location = new System.Drawing.Point(23, 170);
            this.pro_info.Name = "pro_info";
            this.pro_info.Size = new System.Drawing.Size(107, 20);
            this.pro_info.TabIndex = 60;
            this.pro_info.Text = "Information: ";
            // 
            // pro_name
            // 
            this.pro_name.AutoSize = true;
            this.pro_name.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.pro_name.Location = new System.Drawing.Point(23, 130);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(127, 20);
            this.pro_name.TabIndex = 59;
            this.pro_name.Text = "Product Name: ";
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
            this.ok.Location = new System.Drawing.Point(314, 447);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 34);
            this.ok.TabIndex = 58;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // reg
            // 
            this.reg.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.reg.AutoEllipsis = true;
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.reg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reg.Location = new System.Drawing.Point(67, 24);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(288, 47);
            this.reg.TabIndex = 57;
            this.reg.Text = "Modify Product";
            this.reg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(291, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 67;
            this.label5.Text = "__________";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 66;
            this.label4.Text = "__________";
            // 
            // pro_name1
            // 
            this.pro_name1.AutoSize = true;
            this.pro_name1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.pro_name1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pro_name1.Location = new System.Drawing.Point(146, 130);
            this.pro_name1.Name = "pro_name1";
            this.pro_name1.Size = new System.Drawing.Size(48, 20);
            this.pro_name1.TabIndex = 75;
            this.pro_name1.Text = "Book";
            // 
            // pro_info1
            // 
            this.pro_info1.AutoSize = true;
            this.pro_info1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pro_info1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pro_info1.Location = new System.Drawing.Point(146, 170);
            this.pro_info1.Name = "pro_info1";
            this.pro_info1.Size = new System.Drawing.Size(40, 20);
            this.pro_info1.TabIndex = 76;
            this.pro_info1.Text = "nice";
            // 
            // pro_price1
            // 
            this.pro_price1.AutoSize = true;
            this.pro_price1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pro_price1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pro_price1.Location = new System.Drawing.Point(146, 218);
            this.pro_price1.Name = "pro_price1";
            this.pro_price1.Size = new System.Drawing.Size(49, 20);
            this.pro_price1.TabIndex = 77;
            this.pro_price1.Text = "$ 100";
            // 
            // Quantity1
            // 
            this.Quantity1.AutoSize = true;
            this.Quantity1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Quantity1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quantity1.Location = new System.Drawing.Point(146, 266);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(27, 20);
            this.Quantity1.TabIndex = 80;
            this.Quantity1.Text = "10";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Quantity.Location = new System.Drawing.Point(23, 266);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(83, 20);
            this.Quantity.TabIndex = 78;
            this.Quantity.Text = "Quantity: ";
            // 
            // new_price
            // 
            this.new_price.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.new_price.Location = new System.Drawing.Point(143, 240);
            this.new_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.new_price.Name = "new_price";
            this.new_price.Size = new System.Drawing.Size(120, 25);
            this.new_price.TabIndex = 81;
            // 
            // new_qua
            // 
            this.new_qua.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.new_qua.Location = new System.Drawing.Point(143, 288);
            this.new_qua.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.new_qua.Name = "new_qua";
            this.new_qua.Size = new System.Drawing.Size(120, 25);
            this.new_qua.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(143, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.button1.Location = new System.Drawing.Point(27, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 84;
            this.button1.Text = "上傳圖片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(264, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 85;
            this.label6.Text = "X 此行不能為0";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 86;
            this.label1.Text = "X 此行不能為0";
            this.label1.Visible = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.new_qua);
            this.Controls.Add(this.new_price);
            this.Controls.Add(this.Quantity1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.pro_price1);
            this.Controls.Add(this.pro_info1);
            this.Controls.Add(this.pro_name1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pro_price);
            this.Controls.Add(this.new_info);
            this.Controls.Add(this.pro_info);
            this.Controls.Add(this.pro_name);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.new_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_qua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pro_price;
        private System.Windows.Forms.TextBox new_info;
        private System.Windows.Forms.Label pro_info;
        private System.Windows.Forms.Label pro_name;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pro_name1;
        private System.Windows.Forms.Label pro_info1;
        private System.Windows.Forms.Label pro_price1;
        private System.Windows.Forms.Label Quantity1;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.NumericUpDown new_price;
        private System.Windows.Forms.NumericUpDown new_qua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}