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
    public partial class Form8 : Form
    {
        int digiger;
        public Form8(int index)
        {
            InitializeComponent();
            this.digiger = index;
            set_product(digiger);
        }

        private async void set_product(int index)
        {
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            var product_list = await product.get_allproduct();
            pname.Text = product_list[index].ProductName;
            pinto.Text = product_list[index].Infomation;
            pcount.Text = Convert.ToString(product_list[index].Count);
            pprice.Text = Convert.ToString(product_list[index].Price);
            set_pro_pic(pictureBox1, product_list[index].Product_image);
     
        }

        private void set_pro_pic(PictureBox p1, string inputString)
        {

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
           

            p1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否確定要購買此商品", "注意", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                this.Close();
                DialogResult result1 = MessageBox.Show("您可以在我的資料中的訂單查詢追蹤你的訂單資訊", "購買成功", MessageBoxButtons.OK);
                
            }
        }
    }
}
