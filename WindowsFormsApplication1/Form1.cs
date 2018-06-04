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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show(this);
        }


        private void login_Click(object sender, EventArgs e)
        {
            
            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            if (user.login_success(username.ToString(), password.ToString()))
            {
                mainform f = new mainform();
                f.Show(this);
                this.Visible = false;

            }
            else {
                login_error1.Visible = true;
                login_error2.Visible = true;
            }
        }
    }
}
