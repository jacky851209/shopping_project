namespace WindowsFormsApplication1
{
    partial class BuyProductForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pinto = new System.Windows.Forms.Label();
            this.pcount = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pname = new System.Windows.Forms.Label();
            this.buy_howmuch = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_howmuch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pinto
            // 
            this.pinto.AutoSize = true;
            this.pinto.Font = new System.Drawing.Font("新細明體", 15F);
            this.pinto.Location = new System.Drawing.Point(215, 315);
            this.pinto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pinto.Name = "pinto";
            this.pinto.Size = new System.Drawing.Size(53, 20);
            this.pinto.TabIndex = 2;
            this.pinto.Text = "label1";
            // 
            // pcount
            // 
            this.pcount.AutoSize = true;
            this.pcount.Font = new System.Drawing.Font("新細明體", 15F);
            this.pcount.Location = new System.Drawing.Point(215, 385);
            this.pcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pcount.Name = "pcount";
            this.pcount.Size = new System.Drawing.Size(53, 20);
            this.pcount.TabIndex = 3;
            this.pcount.Text = "label1";
            // 
            // pprice
            // 
            this.pprice.AutoSize = true;
            this.pprice.Font = new System.Drawing.Font("新細明體", 15F);
            this.pprice.Location = new System.Drawing.Point(215, 350);
            this.pprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(53, 20);
            this.pprice.TabIndex = 4;
            this.pprice.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(112, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "商品介紹 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(112, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "剩餘數量 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(112, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品價錢 : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(133, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "購買";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pname
            // 
            this.pname.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.pname.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pname.ForeColor = System.Drawing.Color.Maroon;
            this.pname.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pname.Location = new System.Drawing.Point(-9, 250);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(400, 43);
            this.pname.TabIndex = 14;
            this.pname.Text = "Product Name";
            this.pname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy_howmuch
            // 
            this.buy_howmuch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buy_howmuch.Location = new System.Drawing.Point(219, 421);
            this.buy_howmuch.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.buy_howmuch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.buy_howmuch.Name = "buy_howmuch";
            this.buy_howmuch.Size = new System.Drawing.Size(74, 25);
            this.buy_howmuch.TabIndex = 20;
            this.buy_howmuch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(112, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "購買數量 : ";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buy_howmuch);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pcount);
            this.Controls.Add(this.pinto);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_howmuch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pinto;
        private System.Windows.Forms.Label pcount;
        private System.Windows.Forms.Label pprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label pname;
        private System.Windows.Forms.NumericUpDown buy_howmuch;
        private System.Windows.Forms.Label label4;
    }
}