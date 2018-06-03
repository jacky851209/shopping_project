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
        }


        private void OpenForm(Form objFrm)
        {
            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(this.f4);
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenForm(this.f5);
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            OpenForm(this.f3);
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = false;
        }


    }
}
