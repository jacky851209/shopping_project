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
    public partial class Form9 : Form
    {
        int digiger;
        String image_path;
        String mail;
        public Form9(String email, int index)
        {
            InitializeComponent();

            this.digiger = index;
            this.mail = email;
            this.email.Text = mail;
            setvalue();

        }
        private async void setvalue()
        {
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            var pro = await product.get_product(mail);
            pro_name1.Text = pro[digiger].ProductName;
            pro_info1.Text = pro[digiger].Infomation;
            pro_price1.Text = "$ " + Convert.ToString(pro[digiger].Price);
            Quantity1.Text = Convert.ToString(pro[digiger].Count) + "  items";
            new_price.Value = pro[digiger].Price;
            new_qua.Value = pro[digiger].Count;

            byte[] imageBytes = Convert.FromBase64String(pro[digiger].Product_image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 150, 150);

            pictureBox1.Image = img2;

            image_path = await product.get_picture(pro_name1.Text, mail);
        }
        private async void ok_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            
            String set_info;
            int allisok = 0;
            if (new_info.Text == "")
            {
                set_info = pro_info1.Text;
            }
            else {
                set_info = new_info.Text;
            }

            if (new_price.Value == 0)
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
                allisok += 1;
            }

            if (new_qua.Value == 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                allisok += 1;
            }

            if (allisok == 2)
            {
                await product.update_product(mail, pro_name1.Text.ToString(), set_info.ToString(), Convert.ToInt32(new_price.Value), Convert.ToInt32(new_qua.Value), image_path);

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 開啟影像檔
            {
                String input = openFileDialog1.FileName;

                Image img1 = (Bitmap)Image.FromFile(input); // 產生一個Image物件

                Bitmap img2 = new Bitmap(img1, 150, 150);
                pictureBox1.Image = img2;

                byte[] imageArray = System.IO.File.ReadAllBytes(input);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                image_path = base64ImageRepresentation;


            }
        }
    }
}
