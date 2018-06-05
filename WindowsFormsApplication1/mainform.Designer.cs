namespace WindowsFormsApplication1
{
    partial class mainform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "當買家";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(170, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "我的資料";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(325, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "當賣家";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(10, 9);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(155, 21);
            this.email.TabIndex = 5;
            this.email.Text = "dont delete me plz";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username.Location = new System.Drawing.Point(11, 43);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(155, 21);
            this.username.TabIndex = 7;
            this.username.Text = "dont delete me plz";
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "mainform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label email;
        public System.Windows.Forms.Label username;
    }
}