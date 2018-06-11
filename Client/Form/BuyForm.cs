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
    public partial class BuyForm : Form
    {
        String mail;
        
        public BuyForm(String email)
        {
            InitializeComponent();
            this.mail = email;
            this.comboBox1.Items.Add("價格: 低到高");
            this.comboBox1.Items.Add("價格: 高到低");
            set_product(0, -1);
        }

        private async void set_product(int number, int select)
        {
            List<Button> btns = new List<Button>();
            List<Button> btns2 = new List<Button>();
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.AutoScroll = true;
            List<Resources.Product> production;
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            if (number == 0)
            {
                production = await product.get_allproduct();
            }
            else
            {
                production = await product.search(search.Text.ToString(), select);
            }


            int count = production.Count();
            if (count > 0)
            {

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
                    pro_name.Text = production[i].ProductName;

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
                    pro_info.Text = production[i].Infomation;

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
                    pro_price.Text = "$ " + Convert.ToString(production[i].Price);

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
                    pro_count.Text = Convert.ToString(production[i].Count);

                    Button btn = new Button();

                    btn.Width = 115;
                    btn.Height = 35;
                    if (production[i].OwnerEmail == mail)
                    {

                        btn.Text = "您的商品!";
                        btn.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        if (production[i].Count != 0)
                        {
                            btn.Text = "購買!";
                            btn.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            btn.Text = "售完! 待補貨";
                            btn.BackColor = Color.OrangeRed;
                        }
                    }
                    btn.Location = new Point(5, 290);
                    btns.Add(btn);
                    btns[i].Tag = i;
                    btns[i].Click += new EventHandler(this.btns_Click);

                    Button btn2 = new Button();
                    btn2.BackColor = Color.GreenYellow;
                    btn2.Width = 70;
                    btn2.Height = 35;
                    btn2.Text = "留言";
                    btn2.Location = new Point(125, 290);
                    btns2.Add(btn2);
                    btns2[i].Tag = i;
                    btns2[i].Click += new EventHandler(this.btns2_Click);

                    //picbox.Image = WindowsFormsApplication1.Properties.Resources.face_photo;
                    set_pro_pic(picbox, production[i].Product_image);
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

        private async void btns_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            var Pcount = await product.get_allproduct();


            int index = (int)(sender as Button).Tag;
            if (Pcount[index].Count != 0 && Pcount[index].OwnerEmail != mail)
            {
                BuyProductForm f8 = new BuyProductForm(index, this, mail, Pcount[index].OwnerEmail);
                f8.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int select = comboBox1.SelectedIndex;
            this.set_product(1, select);
        }
        private async void btns2_Click(object sender, EventArgs e)
        {
           

        }
        public void RefreshForm()
        {
            flowLayoutPanel1.Controls.Clear();
            this.set_product(0, -1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
