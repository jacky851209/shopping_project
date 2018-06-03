namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iteminfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.howmuch = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howmuch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.users.Location = new System.Drawing.Point(98, 64);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(112, 28);
            this.users.TabIndex = 13;
            this.users.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.face_photo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品名字: ";
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(120, 125);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(338, 22);
            this.item.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "商品資訊: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iteminfo
            // 
            this.iteminfo.Location = new System.Drawing.Point(120, 163);
            this.iteminfo.Name = "iteminfo";
            this.iteminfo.Size = new System.Drawing.Size(338, 22);
            this.iteminfo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "價格: ";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price.Location = new System.Drawing.Point(120, 200);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 25);
            this.price.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "數量: ";
            // 
            // howmuch
            // 
            this.howmuch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.howmuch.Location = new System.Drawing.Point(120, 240);
            this.howmuch.Name = "howmuch";
            this.howmuch.Size = new System.Drawing.Size(120, 25);
            this.howmuch.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "______________________________________________";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(17, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "上傳圖片";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(17, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 194);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.SystemColors.HotTrack;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.accept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accept.Location = new System.Drawing.Point(258, 536);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(150, 38);
            this.accept.TabIndex = 26;
            this.accept.Text = "確認";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(89, 536);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 38);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.howmuch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iteminfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.users);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howmuch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label users;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iteminfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown howmuch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
    }
}