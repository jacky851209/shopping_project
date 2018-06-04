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
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.ControlBox = false;
            InitializeComponent();

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void new_item_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.users.Text = this.users.Text;
            f6.Show();
        }
    }
}
