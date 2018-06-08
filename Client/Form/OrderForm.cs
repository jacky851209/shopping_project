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
    public partial class OrderForm : Form
    {
        String mail;
        public OrderForm(String email)
        {
            this.mail = email;
            InitializeComponent();
            listView1.Scrollable = true;
            set_order();
        }
        private async void set_order()
        {
            List<Resources.Buy> orders;
            WindowsFormsApplication1.Resources.BuyDB buy = new WindowsFormsApplication1.Resources.BuyDB();
            orders = await buy.get_order(mail);
            int count = buy.order_count(mail);
            for(int i = 0; i<count;i++)
            {
                String[] row = {orders[i].ProductName,orders[i].Count.ToString(),(orders[i].Price*orders[i].Count).ToString()};
                var item = new ListViewItem(row);
                listView1.Items.Add(item);

            }

            
        }
    }
}
