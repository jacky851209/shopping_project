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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            int allisok = 0;
            if (current.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
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
                
            }
        }
    }
}
