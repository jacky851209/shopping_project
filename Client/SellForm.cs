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
    public partial class SellForm : Form
    {
   
        String mail;
        public SellForm(String email)
        {
            this.ControlBox = false;
            InitializeComponent();
            this.mail = email;
            set_pic();
            set_product();

        }


        private void new_item_Click(object sender, EventArgs e)
        {
            UploadProductForm f6 = new UploadProductForm(mail.ToString(), this);
            f6.users.Text = this.users.Text;
            f6.Show();

        }
        private async void set_pic()
        {

            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            String inputString = await user.get_picture(this.mail.ToString());

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 80, 80);

            pictureBox1.Image = img2;
        }

        private async void set_product()
        {
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.AutoScroll = true;
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            int count = product.sell_product(this.mail.ToString());
            if (count > 0)
            {
                var product_list = await product.get_product(this.mail.ToString());
                List<Button> btns = new List<Button>();
                List<Button> btns2 = new List<Button>();
                for (int i = 0; i < count; i++)
                {
                    GroupBox gb = new GroupBox();
                    gb.Width = 200;
                    gb.Height = 335;
                    gb.Margin = new Padding(15, 20, 0, 20);


                    PictureBox picbox = new PictureBox();
                    picbox.Width = 200;
                    picbox.Height = 200;

                    Label l1 = new Label();
                    l1.Font = new Font("Arial", 12, FontStyle.Regular);
                    l1.AutoSize = true;
                    l1.Location = new Point(5, 205);
                    l1.Visible = true;
                    l1.Text = "商品名稱:";

                    Label pro_name = new Label();
                    pro_name.Font = new Font("Arial", 12, FontStyle.Regular);
                    pro_name.AutoSize = true;
                    pro_name.Location = new Point(80, 205);
                    pro_name.Visible = true;
                    pro_name.Text = product_list[i].ProductName;

                    Label l2 = new Label();
                    l2.Font = new Font("Arial", 12, FontStyle.Regular);
                    l2.AutoSize = true;
                    l2.Location = new Point(5, 225);
                    l2.Visible = true;
                    l2.Text = "商品資訊:";

                    Label pro_info = new Label();
                    pro_info.Font = new Font("Arial", 12, FontStyle.Regular);
                    pro_info.AutoSize = true;
                    pro_info.Location = new Point(80, 225);
                    pro_info.Visible = true;
                    pro_info.Text = product_list[i].Infomation;

                    Label l3 = new Label();
                    l3.Font = new Font("Arial", 12, FontStyle.Regular);
                    l3.AutoSize = true;
                    l3.Location = new Point(5, 245);
                    l3.Visible = true;
                    l3.Text = "商品價格:";

                    Label pro_price = new Label();
                    pro_price.Font = new Font("Arial", 12, FontStyle.Regular);
                    pro_price.AutoSize = true;
                    pro_price.Location = new Point(80, 245);
                    pro_price.Visible = true;
                    pro_price.Text = "$ " + Convert.ToString(product_list[i].Price);

                    Label l4 = new Label();
                    l4.Font = new Font("Arial", 12, FontStyle.Regular);
                    l4.AutoSize = true;
                    l4.Location = new Point(5, 265);
                    l4.Visible = true;
                    l4.Text = "剩餘數量:";

                    Label pro_count = new Label();
                    pro_count.Font = new Font("Arial", 12, FontStyle.Regular);
                    pro_count.AutoSize = true;
                    pro_count.Location = new Point(80, 265);
                    pro_count.Visible = true;
                    pro_count.Text = Convert.ToString(product_list[i].Count) + "件";

                    Button btn = new Button();
                    btn.BackColor = Color.GreenYellow;
                    btn.Width = 90;
                    btn.Height = 35;
                    btn.Text = "修改!";
                    btn.Location = new Point(5, 290);
                    btns.Add(btn);
                    btns[i].Tag = i;
                    btns[i].Click += new EventHandler(this.btns_Click);

                    Button btn2 = new Button();
                    btn2.BackColor = Color.OrangeRed;
                    btn2.Width = 90;
                    btn2.Height = 35;
                    btn2.Text = "刪除!";
                    btn2.Location = new Point(105, 290);
                    btns2.Add(btn2);
                    btns2[i].Tag = i;
                    btns2[i].Click += new EventHandler(this.btns2_Click);

                    //picbox.Image = WindowsFormsApplication1.Properties.Resources.face_photo;
                    set_pro_pic(picbox, product_list[i].Product_image);
                    picbox.Size = new System.Drawing.Size(200, 200);
                    picbox.SizeMode = PictureBoxSizeMode.Zoom;


                    gb.Controls.Add(picbox);
                    gb.Controls.Add(l1);
                    gb.Controls.Add(pro_name);
                    gb.Controls.Add(l2);
                    gb.Controls.Add(pro_info);
                    gb.Controls.Add(l3);
                    gb.Controls.Add(pro_price);
                    gb.Controls.Add(l4);
                    gb.Controls.Add(pro_count);
                    gb.Controls.Add(btn);
                    gb.Controls.Add(btn2);
                    flowLayoutPanel1.Controls.Add(gb);

                }
            }
        }

        private void set_pro_pic(PictureBox p1, string inputString)
        {

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 200, 200);

            p1.Image = img2;
        }
        private void btns_Click(object sender, EventArgs e)
        {
            int index = (int)(sender as Button).Tag;
            ModifyProductForm f9 = new ModifyProductForm(this.mail, index, this);
            f9.Show();
        }

        private async void btns2_Click(object sender, EventArgs e)
        {
            int index = (int)(sender as Button).Tag;
            DialogResult result = MessageBox.Show("是否確定要刪除此商品!", "注意", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
                var product_list = await product.get_product(this.mail.ToString());
                await product.delete_product(product_list[index].OwnerEmail, product_list[index].ProductName);
                RefreshForm();
            }

        }
        public void RefreshForm()
        {
            flowLayoutPanel1.Controls.Clear();
            this.set_product();
        }
    }
}
