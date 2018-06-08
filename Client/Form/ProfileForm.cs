using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class ProfileForm : Form
    {

        public ProfileForm(String mail)
        {
            InitializeComponent();
            this.email.Text = mail;
            set_pic();
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f7 = new ChangePasswordForm(this.email.Text.ToString());
            f7.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否確定要登出!", "注意", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                Application.Restart();
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 開啟影像檔
            {
                String input = openFileDialog1.FileName;
                WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
                await user.add_picture(this.email.Text.ToString(), input);
                DialogResult result = MessageBox.Show("大頭貼更新完成!", "成功", MessageBoxButtons.OK);

               set_pic();
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 開啟影像檔
            {
                String input = openFileDialog1.FileName;
                WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
                await user.add_picture(this.email.Text.ToString(), input);
                DialogResult result = MessageBox.Show("大頭貼更新完成!", "成功", MessageBoxButtons.OK);

                set_pic();
            }
        }

       private async void set_pic() {

            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            String inputString = await user.get_picture(this.email.Text.ToString());

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 120, 120);

            pictureBox1.Image = img2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderForm od = new OrderForm(email.Text.ToString());
            od.Show();
        }
    }
}
