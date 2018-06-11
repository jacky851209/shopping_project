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
    public partial class NotifyOwnerForm : Form
    {
        String mail;
        public NotifyOwnerForm(String email)
        {
            InitializeComponent();
            this.mail = email;
            set_order();
        }

        private async void set_order()
        {
            List<Resources.Buy> orders;
            WindowsFormsApplication1.Resources.BuyDB buy = new WindowsFormsApplication1.Resources.BuyDB();
            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            orders = await buy.order_notify(mail);
            int count = buy.howmanybuyer(mail);

            for (int i = 0; i < count; i++)
            {
                String username = await user.get_user_name(orders[i].BuyerEmail);
                String[] row = { orders[i].ProductName, username, orders[i].BuyerEmail, orders[i].Count.ToString() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);

            }
        }
    }
}
