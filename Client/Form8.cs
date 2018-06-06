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
            pcount.Text = Convert.ToString(product_list[index].Count) + "件";
            pprice.Text = Convert.ToString(product_list[index].Price);
            set_pro_pic(pictureBox1, product_list[index].Product_image);
            buy_howmuch.Maximum = product_list[index].Count;

        }

        private void set_pro_pic(PictureBox p1, string inputString)
        {

            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
           

            p1.Image = image;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Resources.ProductDB product = new WindowsFormsApplication1.Resources.ProductDB();
            var product_list = await product.get_allproduct();
            int buyone = product_list[digiger].Count - (int)buy_howmuch.Value;
            DialogResult result = MessageBox.Show("總金額為: "+ (int)buy_howmuch.Value * product_list[digiger].Price + "元\n是否確定要購買此商品", "注意", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == result)
            {


                await product.buy_product(product_list[digiger].OwnerEmail, product_list[digiger].ProductName, buyone);
                this.Close();
                DialogResult result1 = MessageBox.Show("您可以在\"我的資料\"中的\"訂單查詢\"\n持續追蹤您的訂單資訊!", "購買成功", MessageBoxButtons.OK);
                
            }
        }
    }
}
