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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show(this);
        }


        private void login_Click(object sender, EventArgs e)
        {
            
            WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
            if (user.login_success(email.Text.ToString(), password.Text.ToString()) == 0)
            {
                mainform f = new mainform(email.Text.ToString());
                f.Show(this);
                this.Visible = false;
            }
            else if (user.login_success(email.Text.ToString(), password.Text.ToString()) == 1)
            {
                login_error1.Visible = true;
                login_error2.Visible = false;
            }
            else
            {
                login_error1.Visible = false;
                login_error2.Visible = true;
            }
            
/*
            SocketClient sc = SocketClient.GetInstance();
            int returnCode = sc.doLogin(email.Text.ToString(), password.Text.ToString());
            if (returnCode == 0)
            {
                mainform f = new mainform(email.Text.ToString());
                f.Show(this);
                this.Visible = false;
            }
            else if (returnCode == 1)
            {
                login_error1.Visible = true;
                login_error2.Visible = false;
            }
            else
            {
                login_error1.Visible = false;
                login_error2.Visible = true;
            }*/
        }
    }
}
