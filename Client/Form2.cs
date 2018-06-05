using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            int allisok = 0;
            if (username.Text == "")
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
                allisok += 1;
            }


            if (email.Text == "")
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

            if (password.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
                allisok += 1;
            }
            if (confirmpassword.Text != password.Text)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                allisok += 1;
            }
            if (allisok == 4)
            {
                WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
                if (user.find_the_user(email.Text.ToString()) == false)
                {
                    user.InsertOne(username.Text.ToString(), email.Text.ToString(), password.Text.ToString());
                    this.Close();
                }
                else
                {
                    label7.Visible = false;
                    label10.Visible = true;
                }
            }


        }
    }
}
