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
    public partial class Form3 : Form
    {
        String mail;
        public Form3(String email)
        {
            this.ControlBox = false;
            InitializeComponent();
            flowLayoutPanel1.VerticalScroll.Visible = true;
            this.mail = email;
            //set_pic();

        }


        private void new_item_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(mail.ToString());
            f6.users.Text = this.users.Text;
            f6.Show();
        }

        private void users_Click(object sender, EventArgs e)
        {

        }
        /*private async void set_pic()
        {

            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            String inputString = await user.get_picture(this.mail.ToString());

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 80, 80);

            pictureBox1.Image = img2;
        }*/
    }
}
