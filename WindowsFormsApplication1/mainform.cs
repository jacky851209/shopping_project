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

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void idenityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form objFrm)
        {
            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }



        private void toolStripLabel1_Click(object sender, EventArgs e) => OpenForm(new Form3());

        private void toolStripLabel3_Click(object sender, EventArgs e) => OpenForm(new Form3());
    }
}
