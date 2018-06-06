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
    public partial class Form4 : Form
    {
        List<Button> btns = new List<Button>();
        public Form4()
        {
            InitializeComponent();
            set_product();
        }

        private async void set_product()
        {
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.AutoScroll = true;
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            var Pcount = await product.get_allproduct();
            int count = Pcount.Count();
            if (count > 0)
            {
                var product_list = await product.get_allproduct();
               
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
                    pro_price.Text = "$" + Convert.ToString(product_list[i].Price);

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
                    pro_count.Text = Convert.ToString(product_list[i].Count);

                    Button btn = new Button();

                    btn.Width = 190;
                    btn.Height = 35;
                    if (product_list[i].Count != 0)
                    {
                        btn.Text = "購買!";
                        btn.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        btn.Text = "售完!   待補貨";
                        btn.BackColor = Color.OrangeRed;
                    }
                    btn.Location = new Point(5, 290);
                    btns.Add(btn);
                    btns[i].Tag = i;
                    btns[i].Click += new EventHandler(this.btns_Click);
                   


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
            if (Pcount[index].Count != 0)
            {
                Form8 f8 = new Form8(index, this);
                f8.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void RefreshForm()
        {
            flowLayoutPanel1.Controls.Clear();
            this.set_product();
        }
    }
}
