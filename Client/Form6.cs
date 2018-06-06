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
    public partial class Form6 : Form
    {
        int w, h;
        Bitmap img1;
        String email;
        String image_path;

        public Form6(String email)
        {
            InitializeComponent();
            this.email = email;
            set_pic();
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
        }

        private  void accept_Click(object sender, EventArgs e)
        {
            int allisok = 0;
            if (item.Text == "")
            {
                label6.Visible = true;
                label15.Visible = false;
            }
            else
            {
                label15.Visible = false;
                label6.Visible = false;
                allisok += 1;
            }
            
            if (iteminfo.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
                allisok += 1;
            }
      
            if (price.Value == 0)
            {

                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
                allisok += 1;
            }

            if (count.Value == 0)
            {

                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
                allisok += 1;
            }

            if (image_path == null)
            {
                label14.Visible = true;
            }
            else {
                label14.Visible = false;
                allisok += 1;
            }

            if (allisok == 5)
            {
                WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
                if (product.find_item_is_exist(item.Text.ToString(), email.ToString()) == true)
                {
                    label15.Visible = true;
                }
                else
                {
                    label15.Visible = false;
                    product.add_pro(item.Text.ToString(), iteminfo.Text.ToString(), email.ToString(), Convert.ToInt32(price.Value), Convert.ToInt32(count.Value), image_path);
                    DialogResult result = MessageBox.Show("商品上傳成功!", "完成", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否確定要取消上傳商品", "注意", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 開啟影像檔
            {
                String input = openFileDialog1.FileName;

                img1 = (Bitmap)Image.FromFile(input); // 產生一個Image物件
                w = img1.Width;
                h = img1.Height;

                if ((this.ClientSize.Width < w) || (this.ClientSize.Height < h))
                {
                    Bitmap img2 = new Bitmap(img1, 460, 230);
                    pictureBox2.Image = img2;
                }
                else
                {
                    pictureBox2.Image = img1;
                }
               
                pictureBox2.Refresh(); // 要求重畫
                image_path = input;
            }

        }
        private async void set_pic()
        {

            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            String inputString = await user.get_picture(this.email.ToString());

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 80, 80);

            pictureBox1.Image = img2;
        }
    }
}
