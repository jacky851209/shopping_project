﻿namespace WindowsFormsApplication1
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
            this.people = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manypeople = new System.Windows.Forms.Label();
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
            this.textBox1.Location = new System.Drawing.Point(10, 500);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(307, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 380);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品留言板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品名稱 : ";
            // 
            // pnamelabel
            // 
            this.pnamelabel.AutoSize = true;
            this.pnamelabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnamelabel.Location = new System.Drawing.Point(11, 80);
            this.pnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnamelabel.Name = "pnamelabel";
            this.pnamelabel.Size = new System.Drawing.Size(70, 21);
            this.pnamelabel.TabIndex = 5;
            this.pnamelabel.Text = "product";
            // 
            // star1
            // 
            this.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.star1.Location = new System.Drawing.Point(230, 51);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(25, 25);
            this.star1.TabIndex = 10;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // star5
            // 
            this.star5.Location = new System.Drawing.Point(350, 51);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(25, 25);
            this.star5.TabIndex = 9;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            // 
            // star4
            // 
            this.star4.Location = new System.Drawing.Point(320, 51);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(25, 25);
            this.star4.TabIndex = 8;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star3
            // 
            this.star3.Location = new System.Drawing.Point(290, 51);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(25, 25);
            this.star3.TabIndex = 7;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            // 
            // star2
            // 
            this.star2.Location = new System.Drawing.Point(260, 51);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(25, 25);
            this.star2.TabIndex = 6;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.average.Location = new System.Drawing.Point(217, 80);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(46, 21);
            this.average.TabIndex = 11;
            this.average.Text = "平均:";
            // 
            // Sourcelabel
            // 
            this.Sourcelabel.AutoSize = true;
            this.Sourcelabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sourcelabel.Location = new System.Drawing.Point(258, 80);
            this.Sourcelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sourcelabel.Name = "Sourcelabel";
            this.Sourcelabel.Size = new System.Drawing.Size(31, 21);
            this.Sourcelabel.TabIndex = 12;
            this.Sourcelabel.Text = "---";
            // 
            // people
            // 
            this.people.AutoSize = true;
            this.people.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.people.Location = new System.Drawing.Point(286, 82);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(27, 17);
            this.people.TabIndex = 13;
            this.people.Text = "/共";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(328, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "人評論";
            // 
            // manypeople
            // 
            this.manypeople.AutoSize = true;
            this.manypeople.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.manypeople.Location = new System.Drawing.Point(316, 82);
            this.manypeople.Name = "manypeople";
            this.manypeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manypeople.Size = new System.Drawing.Size(16, 17);
            this.manypeople.TabIndex = 15;
            this.manypeople.Text = "1";
            this.manypeople.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 541);
            this.Controls.Add(this.manypeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.people);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label people;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label manypeople;
    }
}