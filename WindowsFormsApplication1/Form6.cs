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
        public Form6()
        {
            InitializeComponent();
 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void accept_Click(object sender, EventArgs e)
        {
            int allisok = 0;
            if (item.Text == "")
            {
                label6.Visible = true;
            }
            else
            {
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


            if (allisok == 4)
            {
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你是否確定要取消上傳商品", "注意", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }

        }

        private void item_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
