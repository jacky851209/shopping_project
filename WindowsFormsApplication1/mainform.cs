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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            email.Text = user.get_user_name(email.Text.ToString()).ToString();
            button1_Click(null, null);
        }


        private void OpenForm(Form objFrm)
        {

            objFrm.MdiParent = this;
            objFrm.Dock = DockStyle.Fill;
            //frm.Size = this.ClientSize;
            objFrm.ShowInTaskbar = false;
            //frm.WindowState = FormWindowState.Maximized;

            objFrm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            OpenForm(new Form4());

            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form5 f5 = new Form5();
            f5.users.Text = email.Text;
            OpenForm(f5);

            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form3 f3 = new Form3();
            f3.users.Text = email.Text;
            OpenForm(f3);

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = false;
        }
    }
}
