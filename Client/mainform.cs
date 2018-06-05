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
        public mainform(String email)
        {
            InitializeComponent();
            settext(email);
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
        private async void settext(String email) {
 
            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            this.email.Text = email;
            username.Text = await user.get_user_name(email);

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

            Form5 f5 = new Form5(email.Text.ToString());
            f5.users.Text = username.Text;
            f5.email.Text = email.Text;
            OpenForm(f5);

            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form3 f3 = new Form3(email.Text.ToString());
            f3.users.Text = username.Text;
            OpenForm(f3);

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = false;
        }
        void Form_Closed(object sender, FormClosedEventArgs e) {
            this.Close();//or Close();
        }

    }
}
