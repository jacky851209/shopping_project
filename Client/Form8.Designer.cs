namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.pname = new System.Windows.Forms.Label();
            this.pinto = new System.Windows.Forms.Label();
            this.pcount = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("新細明體", 30F);
            this.pname.Location = new System.Drawing.Point(246, 321);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(136, 50);
            this.pname.TabIndex = 1;
            this.pname.Text = "label1";
            // 
            // pinto
            // 
            this.pinto.AutoSize = true;
            this.pinto.Font = new System.Drawing.Font("新細明體", 15F);
            this.pinto.Location = new System.Drawing.Point(151, 386);
            this.pinto.Name = "pinto";
            this.pinto.Size = new System.Drawing.Size(70, 25);
            this.pinto.TabIndex = 2;
            this.pinto.Text = "label1";
            // 
            // pcount
            // 
            this.pcount.AutoSize = true;
            this.pcount.Font = new System.Drawing.Font("新細明體", 15F);
            this.pcount.Location = new System.Drawing.Point(151, 491);
            this.pcount.Name = "pcount";
            this.pcount.Size = new System.Drawing.Size(70, 25);
            this.pcount.TabIndex = 3;
            this.pcount.Text = "label1";
            // 
            // pprice
            // 
            this.pprice.AutoSize = true;
            this.pprice.Font = new System.Drawing.Font("新細明體", 15F);
            this.pprice.Location = new System.Drawing.Point(151, 437);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(70, 25);
            this.pprice.TabIndex = 4;
            this.pprice.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(14, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "商品介紹 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(14, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "剩餘數量 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(14, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品價錢 : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(431, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "購買";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pcount);
            this.Controls.Add(this.pinto);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label pinto;
        private System.Windows.Forms.Label pcount;
        private System.Windows.Forms.Label pprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}