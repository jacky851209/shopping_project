namespace WindowsFormsApplication1
{
    partial class SellForm
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
            this.new_item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.notify = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.users.ForeColor = System.Drawing.Color.Maroon;
            this.users.Location = new System.Drawing.Point(93, 55);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(144, 35);
            this.users.TabIndex = 11;
            this.users.Text = "username";
            // 
            // new_item
            // 
            this.new_item.BackColor = System.Drawing.Color.LightGreen;
            this.new_item.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.new_item.ForeColor = System.Drawing.Color.Blue;
            this.new_item.Location = new System.Drawing.Point(372, 109);
            this.new_item.Name = "new_item";
            this.new_item.Size = new System.Drawing.Size(100, 34);
            this.new_item.TabIndex = 12;
            this.new_item.Text = "+ 新增商品";
            this.new_item.UseVisualStyleBackColor = false;
            this.new_item.Click += new System.EventHandler(this.new_item_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "銷售物品";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.face_photo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "______________________________________________";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Khaki;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 149);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 385);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // notify
            // 
            this.notify.BackColor = System.Drawing.Color.LightGreen;
            this.notify.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.notify.ForeColor = System.Drawing.Color.Blue;
            this.notify.Location = new System.Drawing.Point(249, 109);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(100, 34);
            this.notify.TabIndex = 24;
            this.notify.Text = "通知";
            this.notify.UseVisualStyleBackColor = false;
            this.notify.Click += new System.EventHandler(this.button1_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Red;
            this.number.Font = new System.Drawing.Font("華康儷粗黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number.ForeColor = System.Drawing.Color.PowderBlue;
            this.number.Location = new System.Drawing.Point(332, 101);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(26, 16);
            this.number.TabIndex = 25;
            this.number.Text = "12";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.number);
            this.Controls.Add(this.notify);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_item);
            this.Controls.Add(this.users);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label users;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button notify;
        private System.Windows.Forms.Label number;

    }
}