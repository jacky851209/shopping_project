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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm(String mail)
        {
            InitializeComponent();
            this.email.Text = mail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void ok_Click(object sender, EventArgs e)
        {
            int allisok = 0;
            if (current.Text == "")
            {
                label10.Visible = false;
                label7.Visible = true;
            }
            else
            {
                label10.Visible = false;
                label7.Visible = false;
                allisok += 1;
            }


            if (newp.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
                allisok += 1;
            }

            if (confirmp.Text == "" || confirmp.Text!=newp.Text)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                allisok += 1;
            }

            if (allisok == 3)
            {
                WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
                if (current.Text == await user.get_password(this.email.Text))
                {
                    await user.change_password(this.email.Text, newp.Text);
                    DialogResult result = MessageBox.Show("密碼更改完畢!", "完成", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    label7.Visible = false;
                    label10.Visible = true;
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
