namespace WindowsFormsApplication1
{
    partial class MessageForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnamelabel = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.average = new System.Windows.Forms.Label();
            this.Sourcelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(13, 625);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(409, 625);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 131);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(486, 474);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品留言板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品名稱 : ";
            // 
            // pnamelabel
            // 
            this.pnamelabel.AutoSize = true;
            this.pnamelabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnamelabel.Location = new System.Drawing.Point(15, 99);
            this.pnamelabel.Name = "pnamelabel";
            this.pnamelabel.Size = new System.Drawing.Size(90, 25);
            this.pnamelabel.TabIndex = 5;
            this.pnamelabel.Text = "product";
            // 
            // star1
            // 
            this.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.star1.Location = new System.Drawing.Point(307, 64);
            this.star1.Margin = new System.Windows.Forms.Padding(4);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(33, 31);
            this.star1.TabIndex = 10;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // star5
            // 
            this.star5.Location = new System.Drawing.Point(467, 64);
            this.star5.Margin = new System.Windows.Forms.Padding(4);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(33, 31);
            this.star5.TabIndex = 9;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            // 
            // star4
            // 
            this.star4.Location = new System.Drawing.Point(427, 64);
            this.star4.Margin = new System.Windows.Forms.Padding(4);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(33, 31);
            this.star4.TabIndex = 8;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star3
            // 
            this.star3.Location = new System.Drawing.Point(387, 64);
            this.star3.Margin = new System.Windows.Forms.Padding(4);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(33, 31);
            this.star3.TabIndex = 7;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            // 
            // star2
            // 
            this.star2.Location = new System.Drawing.Point(347, 64);
            this.star2.Margin = new System.Windows.Forms.Padding(4);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(33, 31);
            this.star2.TabIndex = 6;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.average.Location = new System.Drawing.Point(365, 99);
            this.average.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(57, 25);
            this.average.TabIndex = 11;
            this.average.Text = "平均:";
            // 
            // Sourcelabel
            // 
            this.Sourcelabel.AutoSize = true;
            this.Sourcelabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sourcelabel.Location = new System.Drawing.Point(423, 99);
            this.Sourcelabel.Name = "Sourcelabel";
            this.Sourcelabel.Size = new System.Drawing.Size(79, 25);
            this.Sourcelabel.TabIndex = 12;
            this.Sourcelabel.Text = "Source";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(512, 676);
            this.Controls.Add(this.Sourcelabel);
            this.Controls.Add(this.average);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.pnamelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pnamelabel;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label Sourcelabel;
    }
}